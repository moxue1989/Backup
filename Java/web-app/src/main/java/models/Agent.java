package models;

import java.io.Serializable;
import java.util.List;

import javax.xml.bind.annotation.XmlRootElement;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;

// Agent Class with OrmLite annotations for mapping
@DatabaseTable(tableName = "agents")
@XmlRootElement

public class Agent implements Serializable {
	
	@DatabaseField(generatedId = true)
	private int AgentId;
	@DatabaseField
	private String AgtFirstName;
	@DatabaseField
	private String AgtMiddleInitial;
	@DatabaseField
	private String AgtLastName;
	@DatabaseField
	private String AgtBusPhone;
	@DatabaseField
	private String AgtEmail;
	@DatabaseField
	private String AgtPosition;
	@DatabaseField
	private int AgencyId;
	@DatabaseField
	@JsonIgnore
	private String userid;
	
	@DatabaseField
	@JsonIgnore
	private String password;
		
	public Agent() {
	}		
	
	@Override
	public String toString() {
		return AgtFirstName + " " + AgtLastName;
	}

	public int getAgentId() {
		return AgentId;
	}

	public void setAgentId(int agentId) {
		AgentId = agentId;
	}

	public String getAgtFirstName() {
		return AgtFirstName;
	}

	public void setAgtFirstName(String agtFirstName) {
		AgtFirstName = agtFirstName;
	}

	public String getAgtMiddleInitial() {
		return AgtMiddleInitial;
	}

	public void setAgtMiddleInitial(String agtMiddleInitial) {
		AgtMiddleInitial = agtMiddleInitial;
	}

	public String getAgtLastName() {
		return AgtLastName;
	}

	public void setAgtLastName(String agtLastName) {
		AgtLastName = agtLastName;
	}

	public String getAgtBusPhone() {
		return AgtBusPhone;
	}

	public void setAgtBusPhone(String agtBusPhone) {
		AgtBusPhone = agtBusPhone;
	}

	public String getAgtEmail() {
		return AgtEmail;
	}

	public void setAgtEmail(String agtEmail) {
		AgtEmail = agtEmail;
	}

	public String getAgtPosition() {
		return AgtPosition;
	}

	public void setAgtPosition(String agtPosition) {
		AgtPosition = agtPosition;
	}

	public int getAgencyId() {
		return AgencyId;
	}

	public void setAgencyId(int agencyId) {
		AgencyId = agencyId;
	}

	@JsonIgnore
	public List<Customer> getCustomers() {
		return OrmLiteDB.getAgtCustomers(AgentId);
	}
	
}
