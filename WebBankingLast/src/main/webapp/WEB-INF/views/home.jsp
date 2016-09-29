<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ page session="false" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %> 
<html>
<head>
	<title>Home</title>
</head>
<body>
<h1>
	Account Info  
</h1>
<button type="button" onclick="location ='/bank/Registration'">New Account</button>
<table border="1">
	<thead>
		<tr>
			<td>Account Name</td>
			<td>Current Amount</td>
		</tr>
	</thead>
	<tbody>
		<tr>
		<td>${userAccount.getName()}</td>
		<td>${userAccount.getCurrentAmount()}</td>
		</tr>
	</tbody>
</table>
<br>
<form action="/bank/LoginSave" method="GET" >

Operation: 
<br>
<select name="operations">
  <option value="deposit">Deposit</option>
  <option value="withdraw">Withdraw</option>
</select>
  <br>
 <input type="hidden" name="name" value="${userAccount.getName() }">
  <input type="hidden" name=currentAmount value="${userAccount.getCurrentAmount() }">
  Amount to change: 
<br>
<input type="text" name="amountToChange">

  <input type="submit">
</form>
</body>
</html>
