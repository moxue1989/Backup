package API;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.List;

import javax.ws.rs.*;
import javax.ws.rs.core.*;

import models.Booking;
import models.Customer;
import models.OrmLiteDB;

@Path("customers")
public class CustomerController {		
	
	@GET
	@Path("all")
	@Produces(MediaType.APPLICATION_JSON)
	public List<Customer> GetAllCustomers(){
		return OrmLiteDB.getCustomers();
	}
	
	@GET
	@Path("")
	@Produces(MediaType.APPLICATION_JSON)
	public Customer GetCustomerById(@QueryParam("id") String custId){
		return OrmLiteDB.getCustomersById(Integer.parseInt(custId));
	}
	
	@GET
	@Path("agent")
	@Produces(MediaType.TEXT_HTML)
	public String GetCustomersByAgentHtml(@QueryParam("id") String agentid){
		List<Customer> customers = OrmLiteDB.getAgtCustomers(Integer.parseInt(agentid));		
		return HtmlHelper.getCustomerTable(customers);
	}
	
	@GET
	@Path("login")	
	@Produces(MediaType.APPLICATION_JSON)
	public Customer CustomerLogin(@QueryParam("user") String user, @QueryParam("pass") String pass) {
		return OrmLiteDB.customerLogin(user, pass);
	}
	
	@POST
	@Path("")	
	@Produces(MediaType.TEXT_HTML)
	public String UpdateCustomer(@FormParam("col") String col, @FormParam("id") String custid, @FormParam("value") String value) {
		return OrmLiteDB.updateCustomer(col, custid, value)+"";
	}
	
	@POST
	@Path("")	
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.TEXT_HTML)
	public String UpdateCustomer(Customer cust) {
		return OrmLiteDB.updateCustomer(cust)+"";
	}
	
	@POST
	@Path("new")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.TEXT_HTML)
	public String CreateCustomer(Customer cust) {
		return OrmLiteDB.createCustomer(cust)+"";
	}
	
	@DELETE
	@Path("")
	@Produces(MediaType.TEXT_HTML)
	public String DeleteCustomer(@FormParam("id") String custid) {
		return OrmLiteDB.deleteCustomer(custid)+"";
	}	
}
