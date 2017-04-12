import com.j256.ormlite.dao.Dao;
import com.j256.ormlite.dao.DaoManager;
import com.j256.ormlite.jdbc.JdbcConnectionSource;
import com.j256.ormlite.support.ConnectionSource;
import com.j256.ormlite.table.TableUtils;

public class TestPerson {
	public static void main(String[] args) throws Exception {

		// this uses h2 by default but change to match your database
		String databaseUrl = "jdbc:mysql://localhost:3306/test";
		String user = "root";
		String password = "password";
		// create a connection source to our database
		ConnectionSource connectionSource = new JdbcConnectionSource(databaseUrl, user, password);

		// instantiate the dao
		Dao<Person, String> personDao = DaoManager.createDao(connectionSource, Person.class);

		// if you need to create the 'persons' table make this call
		//TableUtils.createTable(connectionSource, Person.class);
		
		Person person = new Person();
        person.setName("Jim Coakley3");
        person.setPassword("goodpass");

        // persist the person object to the database
        personDao.create(person);

        // retrieve the person from the database by its id field (name)
        Person person2 = personDao.queryForId("Jim Coakley");
        
        java.util.List<Person> people = personDao.queryForAll();
        
        for (Person p : people) {
        	System.out.println(p.getName() + " " + p.getPassword());
		}
        
        System.out.println("Person: " + person2.getName());

        // close the connection source
        connectionSource.close();
	}
}
