package models;

import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

import com.google.appengine.api.search.query.ExpressionParser.index_return;
import com.j256.ormlite.dao.Dao;
import com.j256.ormlite.dao.DaoManager;
import com.j256.ormlite.jdbc.JdbcConnectionSource;
import com.j256.ormlite.jdbc.JdbcSingleConnectionSource;
import com.j256.ormlite.support.ConnectionSource;
import com.j256.ormlite.stmt.UpdateBuilder;
import com.j256.ormlite.stmt.DeleteBuilder;

// OrmLite database mapping to agent class
public class OrmLiteDB {
	
	// database connection credentials
	static String databaseUrl = "jdbc:mysql://127.0.0.1/travelexperts?user=root";
	static String url = System.getProperty("database-url");
	
	/* -------------------- TEST METHODS ------------------- */
	public static String Test() {
		try {
			Class.forName("com.mysql.jdbc.GoogleDriver");
			Connection conn = DriverManager.getConnection(url);
			ResultSet rs = conn.prepareStatement("select * from agents;").executeQuery();
			if(rs.next()) {
				
				String output = rs.getString(2);
				conn.close();
				return output;
			}
			conn.close();
			return "success";
		} catch (SQLException | ClassNotFoundException e) {
			return e.toString();
		}		
	}
	
	public static String testAgents(){
		try {
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Agent, Integer> agentDao = DaoManager.createDao(connectionSource, Agent.class);
			List<Agent> agents = agentDao.queryForAll();
			connectionSource.close();
			conn.close();
			return agents.size() + "";		
		} catch (SQLException e) {
			return e.toString();
		}
	}
		
	/* -------------------- GENERAL METHODS ------------------- */
	// make connection method
	private static Connection getConnection() throws SQLException {
		try {
			Class.forName("com.mysql.jdbc.GoogleDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
		Connection conn = DriverManager.getConnection(url);
		return conn;
	}	

	// login method for agents
	public static Agent AgentLogin(String agtuserid, String agtpass) 
	{		
		try {
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Agent, Integer> agentDao = DaoManager.createDao(connectionSource, Agent.class);
			List<Agent> agents = agentDao.queryBuilder().where().eq("userid", agtuserid).and().eq("password", agtpass).query();
			connectionSource.close();
			conn.close();
			if(agents.size() > 0) 
			{				
				return agents.get(0);			
			}			
		} 
		catch (SQLException e) 
		{
			e.printStackTrace();
		}
		return null;		
	}

	/* -------------------- AGENT METHODS ------------------- */
	// get list of all agents
	public static List<Agent> getAgents(){
		try {
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Agent, Integer> agentDao = DaoManager.createDao(connectionSource, Agent.class);
			List<Agent> agents = agentDao.queryForAll();
			connectionSource.close();
			conn.close();
			return agents;		
		} catch (SQLException e) {
			e.printStackTrace();
		}		
		return null;
	}
	
	// updates agent
	public static int updateAgent(Agent agent) {
		try {
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Agent, Integer> agentDao = DaoManager.createDao(connectionSource, Agent.class);			
			int output = agentDao.update(agent);
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {			
			e.printStackTrace();			
		}
		return -1;
	}
	
	// insert agent into database
	public static int createAgent(Agent agent) {
		try {
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Agent, Integer> agentDao = DaoManager.createDao(connectionSource, Agent.class);
			int output = agentDao.create(agent);
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();			
		}
		return -1;
	}
	
	// delete agent from database
	public static int deleteAgent(String agentId) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Agent, Integer> agentDao = DaoManager.createDao(connectionSource, Agent.class);
			DeleteBuilder<Agent, Integer> deleteBuilder = agentDao.deleteBuilder();
			deleteBuilder.where().eq("AgentId", agentId);
			int output = deleteBuilder.delete();
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}
	
	/* -------------------- CUSTOMER METHODS ------------------- */
	// Customer Login
	public static Customer customerLogin(String user, String pass) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);
			Customer customer = customerDao.queryBuilder().where().eq("user", user).and().eq("pass", pass).queryForFirst();
			connectionSource.close();
			conn.close();
			return customer;		
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
		}

	
	// get all customer for agent
	public static List<Customer> getAgtCustomers(int agentid) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);
			List<Customer> customers = customerDao.queryBuilder().where().eq("AgentId", agentid).query();
			connectionSource.close();
			conn.close();
			return customers;		
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}
	
	// get all customers
	public static List<Customer> getCustomers(){
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);
			List<Customer> customers = customerDao.queryForAll();
			connectionSource.close();
			conn.close();
			return customers;		
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}
			
	// get a single customer from id
	public static Customer getCustomersById(int custid) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);
			List<Customer> customers = customerDao.queryBuilder().where().eq("CustomerId", custid).query();
			connectionSource.close();
			conn.close();
			if(customers.size() > 0) {
				return customers.get(0);	
			}			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}

	// update customer single column
	public static int updateCustomer(String col, String custid, String value) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);			
			UpdateBuilder<Customer, Integer> updateBuilder = customerDao.updateBuilder();
			updateBuilder.updateColumnValue(col, value);
			updateBuilder.where().eq("CustomerId", custid);
			int output = updateBuilder.update();
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}
	
	// update customer complete object
	public static int updateCustomer(Customer cust) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);
			int output = customerDao.update(cust);
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}

	// remove customer from database
	public static int deleteCustomer(String custid) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);
			DeleteBuilder<Customer, Integer> deleteBuilder = customerDao.deleteBuilder();
			deleteBuilder.where().eq("CustomerId", custid);
			int output = deleteBuilder.delete();
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}

	// add customer to database
	public static int createCustomer(Customer cust) {
		
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);			
			int output = customerDao.create(cust);
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}
	
	/* -------------------- BOOKING METHODS ------------------- */
	// get all booking for a customer
	public static List<Booking> getBookingsByCust(int custid) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Booking, Integer> bookingDao = DaoManager.createDao(connectionSource, Booking.class);
			List<Booking> bookings = bookingDao.queryBuilder().where().eq("CustomerId", custid).query();
			connectionSource.close();
			conn.close();
			return bookings;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}

	// get all bookings
	public static List<Booking> getBookings() {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Booking, Integer> bookingDao = DaoManager.createDao(connectionSource, Booking.class);
			List<Booking> bookings = bookingDao.queryForAll();
			connectionSource.close();
			conn.close();
			return bookings;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}
	
	// update a booking info
	public static int updateBooking(Booking booking) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Booking, Integer> bookingDao = DaoManager.createDao(connectionSource, Booking.class);
			int output = bookingDao.update(booking);
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}

	// delete a bookings
	public static int deleteBooking(String bookingid) {
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Booking, Integer> bookingDao = DaoManager.createDao(connectionSource, Booking.class);
			DeleteBuilder<Booking, Integer> deleteBuilder = bookingDao.deleteBuilder();
			deleteBuilder.where().eq("BookingId", bookingid);
			int output = deleteBuilder.delete();
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}
	
	// create a booking
	public static int createBooking(Booking booking) {
		
		try {		
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Booking, Integer> bookingDao = DaoManager.createDao(connectionSource, Booking.class);		
			int output = bookingDao.create(booking);
			connectionSource.close();
			conn.close();
			return output;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}
	
	/* -------------------- BOOKING DETAIL METHODS ------------------- */
	// get booking details for a booking
	public static List<BookingDetail> getBookingDetailsByBooking(int bookingId) {
		try {	
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<BookingDetail, Integer> bookingDetailsDao = DaoManager.createDao(connectionSource, BookingDetail.class);
			List<BookingDetail> details = bookingDetailsDao.queryBuilder().where().eq("BookingId", bookingId).query();
			connectionSource.close();
			conn.close();
			return details;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}
	// get all booking details
	public static List<BookingDetail> getBookingDetails() {
		try {	
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<BookingDetail, Integer> bookingDetailsDao = DaoManager.createDao(connectionSource, BookingDetail.class);
			List<BookingDetail> details = bookingDetailsDao.queryForAll();
			connectionSource.close();
			conn.close();
			return details;
		} catch (Exception e) {
			e.printStackTrace();
		}
		return null;
	}

	/*--------------------- PACKAGE METHODS ----------------------- */
	// get all packages
	public static List<Package> getAllPackages() {
		try {	
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Package, Integer> packageDao = DaoManager.createDao(connectionSource, Package.class);
			List<Package> packages = packageDao.queryForAll();
			connectionSource.close();
			conn.close();
			return packages;
		} catch (Exception e) {
			e.printStackTrace();
		}
		return null;
	}

	public static List<Agency> getAgencies() {
		try {	
			Connection conn = getConnection();
			JdbcSingleConnectionSource connectionSource = new JdbcSingleConnectionSource(databaseUrl, conn);
			connectionSource.initialize();
			Dao<Agency, Integer> agencyDao = DaoManager.createDao(connectionSource, Agency.class);
			List<Agency> agencies = agencyDao.queryForAll();
			connectionSource.close();
			conn.close();
			return agencies;
		} catch (Exception e) {
			e.printStackTrace();
		}
		return null;
	}
}
