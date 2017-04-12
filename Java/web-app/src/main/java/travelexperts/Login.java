package travelexperts;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import models.Agent;
import models.Customer;
import models.OrmLiteDB;

/**
 * Servlet implementation class Login
 */
public class Login extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Login() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append(OrmLiteDB.Test());
		String user = request.getParameter("user");
		String pass = request.getParameter("pass");		
			
		Agent agent = AgentLogin(user, pass);
		
		if (agent != null) {
			HttpSession session = request.getSession();
			session.setAttribute("agent", agent);
			List<Customer> customers = agent.getCustomers();
			session.setAttribute("customers", customers);			
			response.getWriter().write("login"); 
		}
		else 
		{		
		response.setContentType("text/plain");
		response.setCharacterEncoding("UTF-8"); 
		response.getWriter().write("Wrong Username/Password"); 
		}
	}
	
	private Agent AgentLogin(String user, String pass) {
		// TODO Auto-generated method stub
		return OrmLiteDB.AgentLogin(user, pass);
	}
	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
