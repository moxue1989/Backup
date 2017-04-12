var temp = "";

$(document).ready(function() {	
	
	$('#logout').click(function(event) {
		event.preventDefault();
		$.get('Logout', {}, function(response) {
			window.location.replace("login.jsp");
		});
	});

	$('#customers td').dblclick(function(event) {
		$(this).attr("contenteditable", true);
		temp = $(this).text();
		$(this).focus();
	});
	
	$('#customers td').focusout(function(event) {
		var data = $(this).text();
		if(data == temp){
			return;
		}
		var colname = $(this).attr("class");
		var custid = $(this).parent().children(":first").text();			

		$.ajax({
			context : this,
			url : 'api/customers',
			type : 'POST',
			data : { col : colname,	id : custid, value : data },
			success : function(response) {
				if(response == 1){
					alert("Updated!");
				} else {
					alert("Invalid input!");
					$(this).text(temp);
				}
				$(this).attr("contenteditable", false);
			}
		});		
	});

	$(".custDelete").click(function(event) {

		var row = $(this).parent().parent();
		var custid = row.children(":first").text();
		var fd = new FormData();
		fd.append("id", custid);
		$.ajax({
			context : this,
			url : 'api/customers',
			type : 'DELETE',
			data : { id : custid },
			success : function(result) {
				alert(result);
				row.remove();
			}
		});
		event.preventDefault();
	});

	$(".custBookings").click(function(event) {
		var row = $(this).parent().parent();
		var custid = row.children(":first").text();
		$.ajax({
			context : this,
			url : 'api/bookings/html',
			type : 'GET',
			headers: { Accept: "text/html" },   
			data : { id : custid },
			success : function(result) {
				$('#bookings').html(result);
			}
		});
		event.preventDefault();
	});
	
	$("#bookings").on('click', '.bookingDetails', function(event) {
		var row = $(this).parent().parent();
		var bookingid = row.children(":first").text();
		$.ajax({
			context : this,
			url : 'api/bookingdetails/html',
			type : 'GET',
			headers: { Accept: "text/html" },   
			data : { id : bookingid },
			success : function(result) {
				$('#details').html(result);
				$('#detailsModal').modal('show');
				
			}
		});
		event.preventDefault();
	});		
});