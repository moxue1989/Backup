package models;

import java.io.Serializable;
import javax.persistence.*;
import javax.xml.bind.annotation.XmlRootElement;

import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;


@DatabaseTable(tableName = "agencies")
@XmlRootElement
public class Agency implements Serializable {

	@DatabaseField(generatedId = true)
	private int agencyId;
	@DatabaseField
	private String agncyAddress;
	@DatabaseField
	private String agncyCity;
	@DatabaseField
	private String agncyCountry;
	@DatabaseField
	private String agncyFax;
	@DatabaseField
	private String agncyPhone;
	@DatabaseField
	private String agncyPostal;
	@DatabaseField
	private String agncyProv;
	
	public Agency() {
	}

	public int getAgencyId() {
		return this.agencyId;
	}

	public void setAgencyId(int agencyId) {
		this.agencyId = agencyId;
	}

	public String getAgncyAddress() {
		return this.agncyAddress;
	}

	public void setAgncyAddress(String agncyAddress) {
		this.agncyAddress = agncyAddress;
	}

	public String getAgncyCity() {
		return this.agncyCity;
	}

	public void setAgncyCity(String agncyCity) {
		this.agncyCity = agncyCity;
	}

	public String getAgncyCountry() {
		return this.agncyCountry;
	}

	public void setAgncyCountry(String agncyCountry) {
		this.agncyCountry = agncyCountry;
	}

	public String getAgncyFax() {
		return this.agncyFax;
	}

	public void setAgncyFax(String agncyFax) {
		this.agncyFax = agncyFax;
	}

	public String getAgncyPhone() {
		return this.agncyPhone;
	}

	public void setAgncyPhone(String agncyPhone) {
		this.agncyPhone = agncyPhone;
	}

	public String getAgncyPostal() {
		return this.agncyPostal;
	}

	public void setAgncyPostal(String agncyPostal) {
		this.agncyPostal = agncyPostal;
	}

	public String getAgncyProv() {
		return this.agncyProv;
	}

	public void setAgncyProv(String agncyProv) {
		this.agncyProv = agncyProv;
	}

}