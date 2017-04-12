<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Agent Login</title>
</head>
<body>
	<form action="Login" method="post">
		UserID: <input type="text" name="userid" /><br/>
		Password: <input type="password" name="password" /><br/>
		<input type="submit" value="Log In" onclick="return confirm('Submit?')" />
	</form>
</body>
</html>