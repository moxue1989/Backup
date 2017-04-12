package models;

import java.io.Serializable;
import java.math.BigDecimal;
import java.util.Date;

import javax.xml.bind.annotation.XmlRootElement;

import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;

@DatabaseTable(tableName = "packages")
@XmlRootElement

public class Package implements Serializable {
	private static final long serialVersionUID = 1L;

	@DatabaseField(generatedId = true)
	private int packageId;

	@DatabaseField
	private BigDecimal pkgAgencyCommission;

	@DatabaseField
	private BigDecimal pkgBasePrice;

	@DatabaseField
	private String pkgDesc;

	@DatabaseField
	private Date pkgEndDate;

	@DatabaseField
	private String pkgName;

	@DatabaseField
	private Date pkgStartDate;

	public Package() {
	}

	public int getPackageId() {
		return this.packageId;
	}

	public void setPackageId(int packageId) {
		this.packageId = packageId;
	}

	public BigDecimal getPkgAgencyCommission() {
		return this.pkgAgencyCommission;
	}

	public void setPkgAgencyCommission(BigDecimal pkgAgencyCommission) {
		this.pkgAgencyCommission = pkgAgencyCommission;
	}

	public BigDecimal getPkgBasePrice() {
		return this.pkgBasePrice;
	}

	public void setPkgBasePrice(BigDecimal pkgBasePrice) {
		this.pkgBasePrice = pkgBasePrice;
	}

	public String getPkgDesc() {
		return this.pkgDesc;
	}

	public void setPkgDesc(String pkgDesc) {
		this.pkgDesc = pkgDesc;
	}

	public Date getPkgEndDate() {
		return this.pkgEndDate;
	}

	public void setPkgEndDate(Date pkgEndDate) {
		this.pkgEndDate = pkgEndDate;
	}

	public String getPkgName() {
		return this.pkgName;
	}

	public void setPkgName(String pkgName) {
		this.pkgName = pkgName;
	}

	public Date getPkgStartDate() {
		return this.pkgStartDate;
	}

	public void setPkgStartDate(Date pkgStartDate) {
		this.pkgStartDate = pkgStartDate;
	}

}