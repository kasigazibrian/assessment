<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ANSWER.aspx.cs" Inherits="ASSESSMENT.ANSWER" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>QUESTIONS</title>
    <meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css"/>
	<link rel="stylesheet" type="text/css" href="css/mystyles.css"/>
    <style type="text/css">
	body {
    background-image: url(images/ilab.png);   
    background-position: center;
    background-attachment: fixed;
    background-size: auto;

		}
	</style>
</head>
<body>
     <form runat="server" method="post">
        <div class="content">
            <div class="container">
        <asp:Button ID="showfirstqtn" Width="250px" CssClass="btn" runat="server" OnClick="showfirstqtn_Click" Text="Show First Question" />
        <asp:Button ID="next" Width="250px" OnClick="next_Click" CssClass="btn" runat="server" Text="next" />
        <asp:Button ID="back" Width="250px" OnClick="back_Click" CssClass="btn" runat="server" Text="back" />
        <asp:Button ID="submit" Width="250px" OnClick="submit_Click" CssClass="btn" runat="server" Text="submit" />
           </div>

        <div class="content1">
        
            <p id="qtn" runat="server"><b><asp:Label ID="qtnlabel" Font-Size="15" runat="server" Text="QUESTION"></asp:Label> <asp:Label ID="QTNO" Font-Size="15" runat="server" Text=""></asp:Label></b></p>

                <asp:Label ID="question" Font-Size="15" runat="server" Text=""></asp:Label><br />

                <asp:RadioButton ID="selectedansA" Font-Size="15" GroupName="ans" value="A" runat="server" /><br/>
                <asp:RadioButton ID="selectedansB" GroupName="ans" Font-Size="15" value="B" runat="server" /><br/>
                <asp:RadioButton ID="selectedansC" Font-Size="15" GroupName="ans" value="C" runat="server" /><br/>
                <asp:RadioButton ID="selectedansD" Font-Size="15" GroupName="ans" value="D" runat="server" /><br/>

     <%--     <div class="text-center">
            <asp:ScriptManager ID ="sp" runat="server"> </asp:ScriptManager>
            <asp:Timer ID="timerTest" runat="server" OnTick="timerTest_Tick" Interval="1000" ></asp:Timer>
            <asp:UpdatePanel ID="up" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Literal ID="litMsg" runat="server"></asp:Literal>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="timerTest" EventName="tick" />
                </Triggers>
            </asp:UpdatePanel>
          </div>--%>


               <asp:Label ID="error" Font-Size="25" ForeColor="Red" runat="server" Text=""></asp:Label>
            </div>
           </div>
        </form>
     
   
          
        
    
</body>
</html>
