﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchResultsPage.aspx.cs" Inherits="SearchResultsPage" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title>Search Page</title>
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
                    <li><a href="#">Another action</a></li>
                    <li><a href="#">Something else here</a></li>
                    <li class="divider"></li>
                    <li><a href="#">Separated link</a></li>
                    <li class="divider"></li>
                    <li><a href="#">One more separated link</a></li>
                  </ul>
                </li>
              </ul>
              <form class="navbar-form navbar-left" role="search">
                <div class="form-group">
                  <input type="text" class="form-control" placeholder="Search">
                </div>
                <button type="submit" class="btn btn-default">Submit</button>
              </form>
      
            </div><!-- /.navbar-collapse -->
          </div><!-- /.container-fluid -->
        </nav>





        <form id="form1" runat="server">
    <div>
        <asp:GridView ID="Gdview" runat="server"
            BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
            AutoGenerateColumns="False" >
            <%--<RowStyle BackColor="White" ForeColor="#003399" /> --%>

            <Columns>
                <asp:BoundField DataField = "productId" HeaderText = "ID" ItemStyle-Width = "150"/>
                <asp:BoundField DataField = "productName" HeaderText = "Product Name" ItemStyle-Width = "150"/>
                <asp:BoundField DataField = "productPrice" HeaderText = "Price" ItemStyle-Width = "150"/>
                <%--<asp:BoundField DataField = "productImg" HeaderText = "Image" ItemStyle-Width = "150"/>--%>
                <asp:ImageField DataImageUrlField = "productImg"
                    ControlStyle-Width = "100" ControlStyle-Height = "100"
                    HeaderText = "Preview Image"/>
            
                <asp:BoundField DataField="productId" HtmlEncode="False" ItemStyle-Width = "150" DataFormatString="<a target='_blank' href='ProductPage.aspx?productId={0}'>View Product</a>" />
            </Columns>

        </asp:GridView>
        <!-- END OF GRIDVIEW -->

    </div>

 </form>




        





    </body>
</html>
