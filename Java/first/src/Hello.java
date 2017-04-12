

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.eclipse.jdt.internal.compiler.codegen.CaseLabel;

/**
 * Servlet implementation class Hello
 */
@WebServlet("/Hello")
public class Hello extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Hello() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub	
//		String uri = request.getRequestURI();
//		
//		switch (uri) {
//		case "/first":
//			this.getServletContext().getRequestDispatcher("/index.jsp").forward(request, response);
//			break;
//			
//		default:
//			break;	
//		}
		
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		out.print("<html><body>");
		out.print("<h3>Page not exist</h3>");
		out.print("<h1>" + request.getRequestURI() + " does not exist" + "</h1>");
		out.print("</body></html>");
		//this.getServletContext().getRequestDispatcher("/index.jsp").forward(request, response);
	}	

}
