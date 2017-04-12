package models;

import java.io.Serializable;
import java.util.Date;
import java.util.List;

import javax.xml.bind.annotation.XmlRootElement;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;

//Booking Class with OrmLite annotations for mapping
@DatabaseTable(tableName = "bookings")
@XmlRootElement

public class Booking implements Serializable {

	@DatabaseField(generatedId = true)
	private int bookingId;
	@DatabaseField
	private Date bookingDate;
	@DatabaseField
	private String bookingNo;
	@DatabaseField
	private int customerId;
	@DatabaseField
	private int travelerCount;
	@DatabaseField
	private String tripTypeId;
	
	@JsonIgnore
	public List<BookingDetail> getBookingDetails() {
		return OrmLiteDB.getBookingDetailsByBooking(bookingId);
	}	

	public Booking() {
		
	}

	public int getBookingId() {
		return this.bookingId;
	}

	public void setBookingId(int bookingId) {
		this.bookingId = bookingId;
	}

	public Date getBookingDate() {
		return this.bookingDate;
	}

	public void setBookingDate(Date bookingDate) {
		this.bookingDate = bookingDate;
	}

	public String getBookingNo() {
		return this.bookingNo;
	}

	public void setBookingNo(String bookingNo) {
		this.bookingNo = bookingNo;
	}

	public int getCustomerId() {
		return this.customerId;
	}

	public void setCustomerId(int customerId) {
		this.customerId = customerId;
	}

	public int getTravelerCount() {
		return this.travelerCount;
	}

	public void setTravelerCount(int travelerCount) {
		this.travelerCount = travelerCount;
	}

	public String getTripTypeId() {
		return this.tripTypeId;
	}

	public void setTripTypeId(String tripTypeId) {
		this.tripTypeId = tripTypeId;
	}

}