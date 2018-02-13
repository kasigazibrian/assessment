<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructions.aspx.cs" Inherits="ASSESSMENT.instructions" %>


<!DOCTYPE html>
<html >
<head>
    <title>Instructions</title>
<script src='//production-assets.codepen.io/assets/editor/live/console_runner-079c09a0e3b9ff743e39ee2d5637b9216b3545af0de366d4b9aad9dc87e26bfd.js'></script>
<script src='//production-assets.codepen.io/assets/editor/live/events_runner-73716630c22bbc8cff4bd0f07b135f00a0bdc5d14629260c3ec49e5606f98fdd.js'></script>
<script src='//production-assets.codepen.io/assets/editor/live/css_live_reload_init-2c0dc5167d60a5af3ee189d570b1835129687ea2a61bee3513dee3a50c115a77.js'></script>
<meta charset='UTF-8'>
<meta name="robots" content="noindex">
<link rel="shortcut icon" type="image/x-icon" href="//production-assets.codepen.io/assets/favicon/favicon-8ea04875e70c4b0bb41da869e81236e54394d63638a1ef12fa558a4a835f1164.ico" />
<link rel="mask-icon" type="" href="//production-assets.codepen.io/assets/favicon/logo-pin-f2d2b6d2c61838f7e76325261b7195c27224080bc099486ddd6dccb469b8e8e6.svg" />
<link rel="canonical" href="https://codepen.io/ca/pen/gabLWN?limit=all&page=61&q=service" />
<link rel="stylesheet" type="text/css" href="css/instructions.css">
<style class="cp-pen-styles">
</style>

</head>
<body>
    <form runat="server" method="post">
<div class="services">


    <div>
        <h1 class="instructions"> INSTRUCTIONS </h1>
    </div>
    <div class="service-container sc1">
        <div class="service-icons">
              <div class="diamond-narrow"></div>
        </div>
        <h1 class="h1-design" style="color: white">Time</h1>
        <p class="p-strategie" style="color: white">The maximium time for doing the assessment is 45 minutes.
        The timer starts when you click the start button and once your time elapses there is no additional time for assessment.

         </p>

    </div>
  
    <div class="service-container sc3">
        <div class="service-icons">
            
            <div class="diamond-narrow"></div>
        </div>
        <h1 class="h1-design" style="color: white">Start button</h1>
        <p class="p-design" style="color: white" >This button is used if it's your first time to do the assessment.
        Make sure you enter your details correctly to avoid inconviniences </p>
    </div>

 
    <div class="service-container sc4">
        <div class="service-icons">
            
              <div class="diamond-narrow"></div>
        </div>
        <h1 class="h1-ux" style="color: white">Continue button</h1>
        <p class="p-ux" style="color: white">Use this button only when you were interrapted during the assessment e.g loss of internet connection or power surge inorder to resume the assessment from where you had stopped. </p>
    </div>

    <div class="service-container sc5">
        <div class="service-icons">
            
            <div class="diamond-narrow"></div>
        </div>
        <h1 class="h1-acc" style="color: white">Submit</h1>
        <p class="p-acc" style="color: white">Clicking this button implies you have completed the assessmnet. You can only do the assessment once!</p>
    </div>

    <div class="service-container sc5">
        <div class="service-icons">
            
            <div class="diamond-narrow"></div>
        </div>
        <h1 class="h1-acc" style="color: white">GOOD LUCK</h1>
       
    </div>
    <div class="button1" runat="server">
        <asp:Button ID="continuetoassessment1" style="width:280px; height: 80px; font-size: 18px; color:blue;  border-radius: 12px" OnClick="continuetoassessment1_Click"  runat="server" Text="CONTINUE TO ASSESSMENT" />
    </div>

</div>
</form>
</body>

 </html>