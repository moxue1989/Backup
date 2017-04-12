package API;

import java.text.DateFormat;
import java.text.NumberFormat;
import java.text.SimpleDateFormat;
import java.util.List;

import models.Booking;
import models.BookingDetail;
import models.Customer;

public class HtmlHelper {
	
	
	public static String getCustomerTable(List<Customer> customers) {		
		if (customers.size() == 0) {
			return "<tr><th>No customers</th></tr>";
		}
		StringBuffer output = new StringBuffer();
		output.append("<thead><tr><th>First Name</th><th>Last Name</th><th>Address</th><th>City</th><th>Province</th><th>Postal Code</th><th>Country</th><th>Home Phone</th><th>Business Phone</th><th>Email</th><th></th></tr></thead><tbody>");
		for (Customer cust : customers) {
			output.append("<tr>");
			output.append("<td style='display:none;'>" + cust.getCustomerId() + "</td>");
			output.append("<td class='CustFirstName'>" + cust.getCustFirstName() + "</td>");
			output.append("<td class='CustLastName'>" + cust.getCustLastName() + "</td>");
			output.append("<td class='CustAddress'>" + cust.getCustAddress() + "</td>");
			output.append("<td class='CustCity'>" + cust.getCustCity() + "</td>");
			output.append("<td class='CustProv'>" + cust.getCustProv() + "</td>");
			output.append("<td class='CustPostal'>" + cust.getCustPostal() + "</td>");
			output.append("<td class='CustCountry'>" + cust.getCustCountry() + "</td>");
			output.append("<td class='CustHomePhone'>" + cust.getCustHomePhone() + "</td>");
			output.append("<td class='CustBusPhone'>" + cust.getCustBusPhone() + "</td>");
			output.append("<td class='CustEmail'>" + cust.getCustEmail() + "</td>");
			output.append("<th><a href='' class='custBookings'>Bookings</a></th>");
			output.append("</tr>");
		}
		output.append("</tbody>");
		return output.toString();
	}

	public static String getBookingsTable(List<Booking> bookings) {
		if (bookings.size() == 0) {
			return "<tr><th>No bookings</th></tr>";
		}
		StringBuffer output = new StringBuffer();
		DateFormat df = new SimpleDateFormat("MM/dd/yyyy");
		output.append("<thead><tr><th>Booking Number</th><th>Booking Date</th><th>Travellers</th><th></th></tr></thead></tbody>");
		for(Booking b:bookings) {
			output.append("<tr>");
			output.append("<td style='display:none'>"+b.getBookingId()+"</td>");
			output.append("<td>"+b.getBookingNo()+"</td>");
			output.append("<td>"+df.format(b.getBookingDate())+"</td>");
			output.append("<td>"+b.getTravelerCount()+"</td>");
			output.append("<th><a href='' class='bookingDetails'>Details</a></th>");
			output.append("</tr>");
		}
		
		output.append("</tbody>");
		return output.toString();
	}

	public static String getBookingsDetailsList(List<BookingDetail> details) {
		StringBuffer output = new StringBuffer();
		DateFormat df = new SimpleDateFormat("MM/dd/yyyy");
		NumberFormat cf = NumberFormat.getCurrencyInstance();
		NumberFormat intf =NumberFormat.getIntegerInstance();
		output.append("<thead><tr><th>Itenerary No</th><th>Start Date</th><th>End Date</th><th>Description</th><th>Destination</th><th>Price</th></tr></thead></tbody>");
		for(BookingDetail b:details) {
			output.append("<tr><td style='display:none'>"+b.getBookingDetailId()+"</td>");
			output.append("<td>"+intf.format(b.getItineraryNo())+"</td>");
			output.append("<td>"+df.format(b.getTripStart())+"</td>");
			output.append("<td>"+df.format(b.getTripEnd())+"</td>");
			output.append("<td>"+b.getDescription()+"</td>");
			output.append("<td>"+b.getDestination()+"</td>");
			output.append("<td>"+cf.format(b.getBasePrice())+"</td></tr>");
		}
		
		output.append("</tbody>");
		return output.toString();
	}
}
