package service;

import java.util.List;

import javax.ws.rs.*;
import javax.ws.rs.core.*;

import models.Agent;

@Path("agents")
public class AgentController {

	@GET
	@Path("hello")
	@Produces(MediaType.TEXT_PLAIN)
	public String hello() {
		return "Hello World!";		
	}
	
	@GET
	@Path("xml")
	@Produces({MediaType.APPLICATION_XML,MediaType.APPLICATION_JSON})
	public List<Agent> getAgents() {
		
		List<Agent> agents = OrmLiteDB.getAgents();		
		return agents;		
	}
	
	@GET
	@Path("")	
	@Produces({MediaType.APPLICATION_JSON,MediaType.APPLICATION_XML})
	public List<Agent> getAgentsJson() {
		
		List<Agent> agents = OrmLiteDB.getAgents();		
		return agents;
	}
	
	@POST
    @Path("")
    @Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
    public Response createDataInJSON(String data) { 

        return Response.status(201).entity(OrmLiteDB.getAgents()).build(); 
    }
}
