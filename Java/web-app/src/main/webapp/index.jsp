<%@page import="models.OrmLiteDB"%>
<%@page import="models.Agent"%>
<%@page import="models.Package"%>
<%@page import="java.util.List"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<% response.setHeader("Cache-Control","no-cache"); //HTTP 1.1 
 response.setHeader("Pragma","no-cache"); //HTTP 1.0 
 response.setDateHeader ("Expires", 0); //prevents caching at the proxy server  
%>
	
<%!Agent agent;%>
<%
	if (session.getAttribute("agent") == null) {
		String address = "/login.jsp";
		RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(address);
		dispatcher.forward(request, response);
	} else {
		agent = (Agent) session.getAttribute("agent");
	}
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet"
	href="https://bootswatch.com/cyborg/bootstrap.css" media="screen">
<link rel="stylesheet"
	href="https://bootswatch.com/assets/css/custom.min.css">
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
<script
	src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<script type="text/javascript" src="agentlanding.js"></script>

<title>Travel Experts</title>
</head>
<body style="padding-top: 0px">
	<jsp:include page="agentNav.html"></jsp:include>
	<%!
		List<Package> packages = OrmLiteDB.getAllPackages();
	%>

	<div id="myCarousel" class="carousel slide" data-ride="carousel">
		<!-- Indicators -->
		<ol class="carousel-indicators">
			<%
				for (int x = 0; x < packages.size(); x++) {
					if (x == 0) {
						out.append("<li data-target='#myCarousel' data-slide-to='" + x + "' class='active'></li>");
					} else {
						out.append("<li data-target='#myCarousel' data-slide-to='" + x + "'></li>");
					}
				}
			%>
		</ol>

		<!-- Wrapper for slides -->
		<div class="carousel-inner" role="listbox">
			<%
				for (int x = 0; x < packages.size(); x++) {
					Package p = packages.get(x);
					if (x == 0){
						out.append("<div class='item active'>");
					} else {
						out.append("<div class='item'>");
					}
					out.append("<img src='https://placehold.it/1200x400?text=" + p.getPkgName() + "' style='width:100%'>");
					out.append("<div class='carousel-caption'>");
					out.append("<h3>" + p.getPkgDesc() + "</h3>");
					out.append("<p>" + p.getPkgBasePrice() + "</p>");					
					out.append("</div></div>");
				}
			%>
		</div>

		<!-- Left and right controls -->
		<a class="left carousel-control" href="#myCarousel" role="button"
			data-slide="prev"> <span class="glyphicon glyphicon-chevron-left"
			aria-hidden="true"></span> <span class="sr-only">Previous</span>
		</a> <a class="right carousel-control" href="#myCarousel" role="button"
			data-slide="next"> <span
			class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
			<span class="sr-only">Next</span>
		</a>
	</div>
</body>
</html>