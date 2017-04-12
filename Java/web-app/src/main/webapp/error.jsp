<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
<title>404 Not Found</title>
</head>

<body>
	<script type="text/javascript">
		
		var rdtimer = 5;
		
		setTimeout(function () {
			window.location = "https://travel-experts.appspot.com";
		}, rdtimer*1000 + 1000); 
		
		setInterval(countdown, 1000);		
		
		function countdown() {			
			$('#timer').text("Redirecting to main page in: " + rdtimer + " seconds!");
			rdtimer--;
		}
	</script>
	<h1>Page not found!</h1>
	<h2 id="timer"></h2>	
	
</body>
</html>