package API;

import java.util.List;

import javax.ws.rs.*;
import javax.ws.rs.core.*;

import models.Agent;
import models.OrmLiteDB;
import models.Package;

@Path("/packages")
public class PackageController {
	
	@GET
	@Path("")	
	@Produces(MediaType.APPLICATION_JSON)
	public List<Package> GetPackages() {
		
		return OrmLiteDB.getAllPackages();
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
