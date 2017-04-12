package service;

import java.io.IOException;
import java.sql.SQLException;
import java.util.List;

import com.j256.ormlite.dao.Dao;
import com.j256.ormlite.dao.DaoManager;
import com.j256.ormlite.jdbc.JdbcConnectionSource;
import com.j256.ormlite.support.ConnectionSource;

import models.Agent;
import models.Customer;

// OrmLite database mapping to agent class
public class OrmLiteDB {
	
	// database connection credentials
	static String databaseUrl = "jdbc:mysql://localhost:3306/travelexperts";
	static String user = "root";
	static String password = "password";

	// get list of all agents
	public static List<Agent> getAgents(){		
		try (ConnectionSource connectionSource = new JdbcConnectionSource(databaseUrl, user, password)){		
			Dao<Agent, Integer> agentDao = DaoManager.createDao(connectionSource, Agent.class);
			List<Agent> agents = agentDao.queryForAll();
			return agents;		
		} catch (SQLException | IOException e) {
			e.printStackTrace();
		}
		return null;
	}
	
	// updates agent
	public static void updateAgent(Agent agent) {		
		try (ConnectionSource connectionSource = new JdbcConnectionSource(databaseUrl, user, password)){		
			Dao<Agent, Integer> agentDao = DaoManager.createDao(connectionSource, Agent.class);
			agentDao.update(agent);
		} catch (SQLException | IOException e) {
			e.printStackTrace();
		}
	}
	
	public static List<Customer> getCustomers(){		
		try (ConnectionSource connectionSource = new JdbcConnectionSource(databaseUrl, user, password)){		
			Dao<Customer, Integer> customerDao = DaoManager.createDao(connectionSource, Customer.class);
			List<Customer> customers = customerDao.queryForAll();
			return customers;		
		} catch (SQLException | IOException e) {
			e.printStackTrace();
		}
		return null;
	}
}
