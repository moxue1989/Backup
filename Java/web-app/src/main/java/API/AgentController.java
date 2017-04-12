package API;

import java.util.List;

import javax.ws.rs.*;
import javax.ws.rs.core.*;

import models.Agent;
import models.OrmLiteDB;

@Path("/agents")
public class AgentController {

	@GET
	@Path("/hello")
	@Produces(MediaType.TEXT_PLAIN)
	public String hello() {
		return "Hello World!";		
	}
	
	@GET
	@Path("")	
	@Produces(MediaType.APPLICATION_JSON)
	public List<Agent> GetAgents() {
		
		List<Agent> agents = OrmLiteDB.getAgents();		
		return agents;
	}
	
	@POST
    @Path("")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.TEXT_HTML)
    public String UpdateAgent(Agent agent) {
		return OrmLiteDB.updateAgent(agent) + "";        
    }
	
	@POST
	@Path("new")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.TEXT_HTML)
	public String CreateAgent(Agent agent) {
		return OrmLiteDB.createAgent(agent) + "";
	}
	
	@DELETE
	@Path("")
	@Produces(MediaType.TEXT_HTML)
	public String DeleteAgent(@FormParam("id") String agentId) {
		return OrmLiteDB.deleteAgent(agentId) + "";
	}
}
