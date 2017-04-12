package service;

import java.util.List;

import javax.ws.rs.*;
import javax.ws.rs.core.*;

import models.Customer;

@Path("customers")
public class CustomerController {
	
	@GET
	@Path("")
	@Produces(MediaType.APPLICATION_JSON)
	public List<Customer> GetCustomers(){
		return OrmLiteDB.getCustomers();
	}

}
