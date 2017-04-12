<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

<h2>Hello JSP</h2>

<% out.print("welcome to jsp"); %> 
<%! int data=50; %>  
<%!   
int cube(int n){  
return n*n*n;  
}  
%>  
<br/>
Current Time: <%= java.util.Calendar.getInstance().getTime() %>  
<form action="welcome.jsp">  
<input type="text" name="uname">  
<% out.print("Today is:"+java.util.Calendar.getInstance().getTime()); %> 
<input type="submit" value="go"><br/> 
</form>  
<%= "Cube of 3 is:"+cube(3) %>  
<br/>
<%= "Value of the variable is:"+data %>  
</body>
</html>