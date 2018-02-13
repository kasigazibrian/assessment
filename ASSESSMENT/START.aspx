<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="START.aspx.cs" Inherits="ASSESSMENT.START" %>

 <!DOCTYPE html>
 <html>
 <head>
 	<title>Start page</title>
 	<meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0" runat="server"/>
 	 
    
      
    <link href="https://fonts.googleapis.com/css?family=Oleo+Script:400,700" rel="stylesheet">
   	<link href="https://fonts.googleapis.com/css?family=Teko:400,700" rel="stylesheet">
  <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" runat="server" />
     
   <link href="css/font-awesome.min.css" rel="stylesheet" runat="server"/>
   <link rel="stylesheet" type="text/css" href="css/stylesheet.css" runat="server" />
 </head>
 <body>
 <section id="contact" runat="server">
			<div class="section-content">
				<h1 class="section-header">iLABS@MAK <span class="content-header wow fadeIn " data-wow-delay="0.2s" data-wow-duration="2s"> Assessment System</span></h1>
			</div>
			<div class="contact-section" runat="server">
			<div class="container" runat="server">
				<form runat="server">
                    <div class="row">
					<div class="col-md-6 form-line" runat="server">
			  			<div class="form-group">
			  				<label for="exampleInputUsername" runat="server">Your name</label>
                              <asp:TextBox ID="stdname" class="form-control" runat="server" required="required" placeholder="Enter your Name"></asp:TextBox>
				  		</div>
				  		<div class="form-group">
					    	<label for="exampleInputRegno" runat="server">Registration Number</label>
                              <asp:TextBox ID="regno" class="form-control" required="required" placeholder="Enter Reg No." runat="server"></asp:TextBox>
					  	</div>	
					  	<div class="form-group">
					    	<label for="Studentno" runat="server">Student Number</label>
                              <asp:TextBox ID="stdno" class="form-control" required="required" placeholder="Enter Student No." runat="server"></asp:TextBox>
			  			</div>
			  			<div class="form-group">
			  				<label for="course" runat="server">Course</label>
                              <asp:DropDownList ID="course" runat="server">
                                  <asp:ListItem Value="Electrical">Electrical</asp:ListItem>
                                   <asp:ListItem Value="Telecom">Telecom</asp:ListItem>
                                   <asp:ListItem Value="Computer">Computer</asp:ListItem>
                                   <asp:ListItem Value="Biomedical">Biomedical</asp:ListItem>
                              </asp:DropDownList>
			  			</div>

			  			<div class="form-group" runat="server">
			  				<label for="year">Year</label>
                              <asp:DropDownList ID="year" runat="server">
                                  <asp:ListItem Value="I">I</asp:ListItem>
                                  <asp:ListItem Value="II">II</asp:ListItem>
                                  <asp:ListItem Value="III">III</asp:ListItem>
                                  <asp:ListItem Value="IV">IV</asp:ListItem>
                              </asp:DropDownList>
			  			</div>
                        <div>
                            <asp:Label ID="error" Font-Size="20" ForeColor="Red" runat="server" Text=""></asp:Label>
                        </div>
			  	  </div>
                    <div class="col-md-6">
			  			<div class="form-group">
			  				 <img src="images/ilabs_logo.jpg" alt="iLabs Logo" style="width:500px; height:400px;"> 
			  			</div>
                        <div>
                            <button type="submit" ID="start" class="btn btn-default submit" onserverclick="start_ServerClick" runat="server"><i class="fa fa-paper-plane" aria-hidden="true"></i> Start </button>
                        </div>
                        <div>
                             <button type="submit" ID="continue" class="btn btn-default submit" onserverclick="continue_ServerClick" runat="server"><i class="fa fa-paper-plane" aria-hidden="true"></i> Continue </button>
                        </div>
                        
                    </div>
				    </div>
	  	
			  	</form>
                </div>
                </div>
    
 </section>
 </body>
 </html>
   

