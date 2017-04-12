<%@page import="API.HtmlHelper"%>
<%@page import="models.Agent"%>
<%@page import="java.util.List"%>
<%@page language="java" contentType="text/html; charset=ISO-8859-1"
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

<title>Agent Landing</title>

</head>
<body style="padding-top: 0px">
	<jsp:include page="agentNav.html"></jsp:include>

	<div class="container-fluid">
		<div class="row content">
			<div class="col-sm-2"></div>
			<div class="col-sm-8">
				<h3>
					Welcome
					<%
					out.append(agent.getAgtFirstName() + " " + agent.getAgtLastName());
				%>
				</h3>
			</div>
			<div class="col-sm-2"></div>
		</div>

		<div class="row content">
			<div class="col-sm-0"></div>
			<div class="col-sm-12" style="overflow-y: auto;">
				<table class="table table-striped table-hover table-responsive"
					id="customers">
					<%
						out.append(HtmlHelper.getCustomerTable(agent.getCustomers()));
					%>
				</table>

				<table class="table table-striped table-hover" id="bookings">

				</table>
			</div>
			<div class="col-sm-0"></div>
		</div>

		<div class="modal fade" id="detailsModal" role="dialog">
			<div class="modal-dialog modal-lg">

				<div class="modal-content">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal">&times;</button>
						<h4 class="modal-title">Booking Details</h4>
					</div>
					<div class="modal-body">
						<table class="table table-striped table-hover" id="details">
						</table>
					</div>
					<div class="modal-footer">
						<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
					</div>
				</div>

			</div>
		</div>
	</div>
</body>
</html>