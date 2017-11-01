<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title>Home Page</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <link href="Content/css/CustomStyle.css" rel="stylesheet" />

</head>
<body>

<nav class="navbar navbar-default navbar-inverse" role="navigation">
  <div class="container-fluid">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand" href="#">Login dropdown</a>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">
        <li ><a href="CategoryPage.aspx?id=2">Laptops</a></li>
        <li><a href="CategoryPage.aspx?id=3">Tablets</a></li>
        <li><a href="CategoryPage.aspx?id=1">Cellphone</a></li>
          <li><a href="ShoppingCart.aspx">Shopping Cart</a></li>
        <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown">Categories <span class="caret"></span></a>
          <ul class="dropdown-menu" role="menu">
            <li><a href="#">Action</a></li>
              <li><asp:Label ID="laptopCountLabel" runat="server" Text="Laptop Count:"></asp:Label></li>
              <li><asp:Label ID="tabletCountLabel" runat="server" Text="Tablet Count:"></asp:Label></li>
              <li><asp:Label ID="cellphoneCountLabel" runat="server" Text="Cellphone Count:"></asp:Label></li>
            <li><a href="#">Another action</a></li>
            <li><a href="#">Something else here</a></li>
            <li class="divider"></li>
            <li><a href="#">Separated link</a></li>
            <li class="divider"></li>
            <li><a href="#">One more separated link</a></li>
          </ul>
        </li>
      </ul>

        <!-- add form tag opening -->
    <form class="form" id="form1" runat="server">
       <%-- <form class="navbar-form navbar-left" role="search">
            <div class="form-group">
                <asp:textbox id="searchtb" runat="server"></asp:textbox>          

            </div>
              <asp:Button id="searchButton" OnClick="searchButton_Click" runat="server" text="search" />
        </form>--%>

        
      <ul class="nav navbar-nav navbar-right">
          
          <asp:Panel ID="logoutPanel" Visible="false" runat="server">
              <asp:Button ID="logoutButton" OnClick="logoutButton_Click" runat="server" Text="Logout" />
          </asp:Panel>

        <asp:Panel ID="loginPanel" Visible="true" runat="server">

            <li class="dropdown">
              <a href="#" id="loginLink" class="dropdown-toggle" data-toggle="dropdown"><b>Login</b> <span class="caret"></span></a>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
			    <ul id="login-dp" class="dropdown-menu">
				    <li>
					     <div class="row">
							    <div class="col-md-12">
								    Login via
								    <div class="social-buttons">
									    <a href="#" class="btn btn-fb"><i class="fa fa-facebook"></i> Facebook</a>
									    <a href="#" class="btn btn-tw"><i class="fa fa-twitter"></i> Twitter</a>
								    </div>
                                    or
								 
										    <div class="form-group">
                                                <asp:TextBox ID="usernameTb" placeholder="Username" CssClass="form-control" runat="server"></asp:TextBox>
										    </div>
										    <div class="form-group">
											     <asp:TextBox ID="passwordTb" placeholder="Password" CssClass="form-control" runat="server"></asp:TextBox>
                                                 <div class="help-block text-right"><a href="#">Forget the password ?</a></div>
										    </div>
										    <div class="form-group">
                                                <asp:Button ID="loginButton" OnClick="loginButton_Click" runat="server" Text="Login" CssClass="btn btn-primary btn-block" />
										    </div>
										    <div class="checkbox">
											     <label>
											     <input type="checkbox"> keep me logged-in
											     </label>
										    </div>
								 
							    </div>
							    <div class="bottom text-center">
								    New here ? <a href="RegistrationForm"><b>Join Us</b></a>
							    </div>
					     </div>
				    </li>
			    </ul>


            </li>
        </asp:Panel>
      </ul>
        </form>

        <!-- /closing form tag -->
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav>

<%-- Carousel --%>
<div class="container">
  <div id="myCarousel" class="carousel slide" data-ride="carousel">
    <!-- Indicators -->
    <ol class="carousel-indicators">
      <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
      <li data-target="#myCarousel" data-slide-to="1"></li>
      <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>

    <!-- Wrapper for slides -->
    <div class="carousel-inner">
      <div class="item active">
        <img src="Content/images/iphone8.jpg" alt="iPhone 8" style="width:100%; height:500px">
      </div>

      <div class="item">
        <img src="Content/images/macbookair.jpg" alt="Macbook Air" style="width:100%;height:500px;">
      </div>
    
      <div class="item">
        <img src="Content/images/ipadpro.jpg" alt="iPad Pro" style="width:100%;height:500px;">
      </div>
    </div>

    <!-- Left and right controls -->
    <a class="left carousel-control" href="#myCarousel" data-slide="prev">
      <span class="glyphicon glyphicon-chevron-left"></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#myCarousel" data-slide="next">
      <span class="glyphicon glyphicon-chevron-right"></span>
      <span class="sr-only">Next</span>
    </a>
  </div>
</div><%-- /Carousel --%>

</body>
</html>