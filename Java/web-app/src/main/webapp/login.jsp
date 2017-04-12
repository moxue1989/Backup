<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
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
<script>
	$(document).ready(function() {
		$('#submit').click(function(event) {			
			var username = $('#user').val();
			var password = $('#password').val();
			if(username == "" || password == "")
				{
				return;
				}		
			event.preventDefault();
			$.get('Login', {
				user : username,
				pass : password
			}, function(response) {
				if (response == "login") {
					window.location.replace("index.jsp")
					//$('#loginmessage').text(response);
				} else {
					$('#loginmessage').text(response);
					start();
					$('#stopButton').show();
				}
			});
		});
		
		$('#stopButton').click(function(event) {
			stop();
			$(this).hide();
			$('#loginmessage').text('');
		});
		
	});
</script>
<title>Login</title>
</head>
<body style="padding-top: 0px">
	<div class="jumbotron">
		<div class="container text-center">
			<h1>Agent Login</h1>
		</div>
	</div>

<jsp:include page="Madness.html"></jsp:include>
	<div class="container-fluid text-center">
		<div class="row content">
			<div class="col-lg-3 col-md-2 col-sm-0">
			</div>
			<div class="col-lg-6 col-md-8 col-sm-12">
				<form id="agentLogin">
					<input class="form-control" type="text" id="user" placeholder="Username" required/><br /> 
					<input class="form-control" type="password" id="password" placeholder="Password" required/><br /> 
					<input class="btn btn-primary btn-lg btn-block" type="submit" id="submit" value="Ajax Login" />										
				</form>
				<h2 class="text-danger" id="loginmessage"></h2>

				<div class="row content">
					<div class="col-lg-3 col-md-2 col-sm-0"></div>
					<div class="col-lg-6 col-md-8 col-sm-12" >
						<button id="stopButton" style="display: none;" class="btn btn-danger btn-lg btn-block">Stop The Madness</button>
					</div>
					<div class="col-lg-3 col-md-2 col-sm-0"></div>
				</div>

			<div class="col-lg-3 col-md-2 col-sm-0">
			</div>
		</div>
	</div>   
	
</body>
</html>