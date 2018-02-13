<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FINALPAGE.aspx.cs" Inherits="ASSESSMENT.FINALPAGE" %>

<!DOCTYPE html>
<html>
<head>
	<title>final page</title>
	<link rel="stylesheet" type="text/css" href="css/mystyle.css">
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	
	
</head>
<body runat="server">
	<div class="container" runat="server">
		<form runat="server">
			<p class="final">FIN</p>
		<p class="final">Congratulations</p>
		<p class="final1">Thou hast cometh to an end!</p>
		<p class="final2">"The cost of excellence is time and practice but the end-result is precious!"</p>
            <asp:Button ID="finalbacktoservicebroker" CssClass="button7" OnClick="finalbacktoservicebroker_Click" runat="server" Text="Back to service broker" />

		</form>
		
		
	</div>
</body>
</html>

