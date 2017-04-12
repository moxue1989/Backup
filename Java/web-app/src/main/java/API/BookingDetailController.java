package API;

import java.util.List;

import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;
import javax.ws.rs.core.MediaType;

import models.Booking;
import models.BookingDetail;
import models.OrmLiteDB;

@Path("bookingdetails")
public class BookingDetailController {

	@GET
	@Path("all")	
	@Produces(MediaType.APPLICATION_JSON)
	public List<BookingDetail> GetAllDetails(){
		return OrmLiteDB.getBookingDetails();
	}
	
	@GET
	@Path("")	
	@Produces(MediaType.APPLICATION_JSON)
	public List<BookingDetail> GetDetailsById(@QueryParam("id") int bookingid){
		List<BookingDetail> details = OrmLiteDB.getBookingDetailsByBooking(bookingid);
		return details;
	}
	
	@GET
	@Path("html")
	@Produces(MediaType.TEXT_HTML)
	public String GetDetailsByIdHtml(@QueryParam("id") int bookingid){
		List<BookingDetail> details = OrmLiteDB.getBookingDetailsByBooking(bookingid);		
		return HtmlHelper.getBookingsDetailsList(details);
	}
}
