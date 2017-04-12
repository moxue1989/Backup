package travelexperts.travelapp.Models;

import android.graphics.Bitmap;

import java.io.Serializable;
import java.math.BigDecimal;
import java.util.List;

/**
 * Created by 750118 on 4/12/2017.
 */

public class Package implements Serializable{

    private int packageId;

    private BigDecimal pkgAgencyCommission;

    private BigDecimal pkgBasePrice;

    private String pkgDesc;

    private Long pkgEndDate;

    private String pkgName;

    private Long pkgStartDate;

    private Bitmap image;

    public Package() {

    }

    public Bitmap getImage() {
        return image;
    }

    public void setImage(Bitmap image) {
        this.image = image;
    }

    public int getPackageId() {
        return packageId;
    }

    public void setPackageId(int packageId) {
        this.packageId = packageId;
    }

    public BigDecimal getPkgAgencyCommission() {
        return pkgAgencyCommission;
    }

    public void setPkgAgencyCommission(BigDecimal pkgAgencyCommission) {
        this.pkgAgencyCommission = pkgAgencyCommission;
    }

    public BigDecimal getPkgBasePrice() {
        return pkgBasePrice;
    }

    public void setPkgBasePrice(BigDecimal pkgBasePrice) {
        this.pkgBasePrice = pkgBasePrice;
    }

    public String getPkgDesc() {
        return pkgDesc;
    }

    public void setPkgDesc(String pkgDesc) {
        this.pkgDesc = pkgDesc;
    }

    public Long getPkgEndDate() {
        return pkgEndDate;
    }

    public void setPkgEndDate(Long pkgEndDate) {
        this.pkgEndDate = pkgEndDate;
    }

    public String getPkgName() {
        return pkgName;
    }

    public void setPkgName(String pkgName) {
        this.pkgName = pkgName;
    }

    public Long getPkgStartDate() {
        return pkgStartDate;
    }

    public void setPkgStartDate(Long pkgStartDate) {
        this.pkgStartDate = pkgStartDate;
    }
}
