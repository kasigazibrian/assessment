<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Timeout.aspx.cs" Inherits="ASSESSMENT.Timeout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TIME OUT!</title>
   
</head>
    
<body>
     <h1>OOPS, YOUR TIME HAS RAN OUT!</h1>
    <form id="form1" runat="server">
        <div>
            
            <p>YOU WILL BE RDIRECTED TO THE FINAL PAGE</p>
            <asp:Label ID="error" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
