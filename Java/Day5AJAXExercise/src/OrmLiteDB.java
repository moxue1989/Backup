import java.io.IOException;
import java.sql.SQLException;
import java.util.List;

import com.j256.ormlite.dao.Dao;
import com.j256.ormlite.dao.DaoManager;
import com.j256.ormlite.jdbc.JdbcConnectionSource;
import com.j256.ormlite.support.ConnectionSource;
import com.j256.ormlite.stmt.UpdateBuilder;
import com.j256.ormlite.stmt.DeleteBuilder;


public class OrmLiteDB {
	
	// database connection credentials
	static String databaseUrl = "jdbc:mysql://localhost:3306/travelexperts";
	static String user = "root";
	static String password = "password";


	public static List<State> getStatesByCountry(int countryCode) {
		try (ConnectionSource connectionSource = new JdbcConnectionSource(databaseUrl, user, password)){		
			Dao<State, Integer> stateDao = DaoManager.createDao(connectionSource, State.class);
			List<State> states = stateDao.queryBuilder().where().eq("countryCode", countryCode).query();
			return states;		
		} catch (SQLException | IOException e) {
			e.printStackTrace();
		}
		return null;
	}
}
