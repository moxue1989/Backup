package API;

import java.util.List;

import javax.ws.rs.*;
import javax.ws.rs.core.*;

import models.Agency;
import models.Agent;
import models.OrmLiteDB;

@Path("/agency")
public class AgencyController {
	
	@GET
	@Path("")	
	@Produces(MediaType.APPLICATION_JSON)
	public List<Agency> GetAgencies() {
		
		List<Agency> agencies = OrmLiteDB.getAgencies();		
		return agencies;
	}	
}
