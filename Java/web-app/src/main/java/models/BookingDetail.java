package models;

import java.io.Serializable;
import javax.persistence.*;
import javax.xml.bind.annotation.XmlRootElement;

import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;

import java.math.BigDecimal;
import java.util.Date;

@DatabaseTable(tableName = "bookingdetails")
@XmlRootElement

public class BookingDetail implements Serializable {

	@DatabaseField(generatedId = true)
	private int bookingDetailId;

	@DatabaseField
	private BigDecimal agencyCommission;

	@DatabaseField
	private BigDecimal basePrice;

	@DatabaseField
	private int bookingId;

	@DatabaseField
	private String classId;

	@DatabaseField
	private String description;

	@DatabaseField
	private String destination;

	@DatabaseField
	private String feeId;

	@DatabaseField
	private double itineraryNo;

	@DatabaseField
	private int productSupplierId;

	@DatabaseField
	private String regionId;

	@DatabaseField
	private Date tripEnd;

	@DatabaseField
	private Date tripStart;

	public BookingDetail() {
	}

	public int getBookingDetailId() {
		return this.bookingDetailId;
	}

	public void setBookingDetailId(int bookingDetailId) {
		this.bookingDetailId = bookingDetailId;
	}

	public BigDecimal getAgencyCommission() {
		return this.agencyCommission;
	}

	public void setAgencyCommission(BigDecimal agencyCommission) {
		this.agencyCommission = agencyCommission;
	}

	public BigDecimal getBasePrice() {
		return this.basePrice;
	}

	public void setBasePrice(BigDecimal basePrice) {
		this.basePrice = basePrice;
	}

	public int getBookingId() {
		return this.bookingId;
	}

	public void setBookingId(int bookingId) {
		this.bookingId = bookingId;
	}

	public String getClassId() {
		return this.classId;
	}

	public void setClassId(String classId) {
		this.classId = classId;
	}

	public String getDescription() {
		return this.description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public String getDestination() {
		return this.destination;
	}

	public void setDestination(String destination) {
		this.destination = destination;
	}

	public String getFeeId() {
		return this.feeId;
	}

	public void setFeeId(String feeId) {
		this.feeId = feeId;
	}

	public double getItineraryNo() {
		return this.itineraryNo;
	}

	public void setItineraryNo(double itineraryNo) {
		this.itineraryNo = itineraryNo;
	}

	public int getProductSupplierId() {
		return this.productSupplierId;
	}

	public void setProductSupplierId(int productSupplierId) {
		this.productSupplierId = productSupplierId;
	}

	public String getRegionId() {
		return this.regionId;
	}

	public void setRegionId(String regionId) {
		this.regionId = regionId;
	}

	public Date getTripEnd() {
		return this.tripEnd;
	}

	public void setTripEnd(Date tripEnd) {
		this.tripEnd = tripEnd;
	}

	public Date getTripStart() {
		return this.tripStart;
	}

	public void setTripStart(Date tripStart) {
		this.tripStart = tripStart;
	}

}