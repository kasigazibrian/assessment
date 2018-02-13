<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASSESSMENT.Default" %>

<!DOCTYPE>
<html>
<head runat="server">
	<meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Default</title>
	<link rel="stylesheet" type="text/css" href="css/mystyle.css">
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
   <style type="text/css">
	body {
    background-image: url(images/image3.jpg);   
    background-repeat: no-repeat;
    background-position: center;
    background-attachment: fixed;
    background-size: cover;

		}
	</style>

</head>

<body runat="server">
<form runat="server">
  <br />
    <div style="margin-left:10px">
        <asp:Button ID="backtoservicebroker" class="button1" OnClick="backtoservicebroker_Click" runat="server" Text="Back to Service Broker" />
        <asp:Button ID="finishlab" class="button1" OnClick="finishlab_Click" runat="server" Text="Finish Lab" />
		<%--<span style="font-size: 20px; font-weight: bold">Time Remaining: </span>--%>
        <label   style="font-size:20px" ><b>TIME REMAINING:</b></label>
         <span id="countdown" style=" font-size:20px" class="timer"></span>
      <br />
	
     
<script type="text/javascript">
    var seconds = 1800;
    function secondPassed() {
        var minutes = Math.round((seconds - 30) / 60);
        var remainingSeconds = seconds % 60;
        if (remainingSeconds < 10) {
            remainingSeconds = "0" + remainingSeconds;
        }
        document.getElementById('countdown').innerHTML = minutes + ":" + remainingSeconds;
        if (seconds == 0) {
            clearInterval(countdownTimer);
            document.getElementById('countdown').innerHTML = window.location="instructions.aspx";
        } else {
            seconds--;
        }
    }

    var countdownTimer = setInterval('secondPassed()', 1000);
</script>
    

 	<iframe src="https://www.youtube.com/embed" height="450" width="800" class="iframe"></iframe>
    </div>
 </form>
</body>
</html>