package API;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.List;

import javax.ws.rs.Consumes;
import javax.ws.rs.DELETE;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.PUT;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;
import javax.ws.rs.core.MediaType;

import models.Agent;
import models.Booking;
import models.BookingDetail;
import models.Customer;
import models.OrmLiteDB;

@Path("bookings")
public class BookingController {

	@GET
	@Path("all")	
	@Produces(MediaType.APPLICATION_JSON)
	public List<Booking> GetAllBookings(){
		return OrmLiteDB.getBookings();
	}
	
	@GET
	@Path("")
	@Produces(MediaType.APPLICATION_JSON)
	public List<Booking> GetBookingsByCust(@QueryParam("id") int custid){
		Customer customer = OrmLiteDB.getCustomersById(custid);
		return customer.getBookings();
	}
	
	@GET
	@Path("html")
	@Produces(MediaType.TEXT_HTML)
	public String GetBookingsByCustHtml(@QueryParam("id") int custid){
		Customer customer = OrmLiteDB.getCustomersById(custid);
		List<Booking> bookings = customer.getBookings();		
		return HtmlHelper.getBookingsTable(bookings);
	}
	
	@POST
    @Path("")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.TEXT_HTML)
    public String UpdatBooking(Booking booking) {
		return OrmLiteDB.updateBooking(booking) + "";        
    }
	
	@POST
	@Path("new")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.TEXT_HTML)
	public String CreateBooking(Booking booking) {
		return OrmLiteDB.createBooking(booking) + "";
	}
	
	@DELETE
	@Path("")
	@Produces(MediaType.TEXT_HTML)
	public String DeleteBooking(String bookingId) {
		return OrmLiteDB.deleteBooking(bookingId) + "";
	}
}
