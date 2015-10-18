<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBob.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="page-header">
            <h1>Papa Bobs Pizza</h1>
            <p class="lead">Pizza to Code By</p>
        </div>

        <div class="form-group">
            <label>Size: </label>
            <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" OnSelectedIndexChanged="getTotal" AutoPostBack="True">
                <asp:ListItem Text="Select Size..." />
                <asp:ListItem Text="Small - 12,=" Value="Small" />
                <asp:ListItem Text="Medium - 14,=" Value="Medium" />
                <asp:ListItem Text="Large - 16,=" Value="Large" />
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <label>Crust: </label>
            <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" OnSelectedIndexChanged="getTotal" AutoPostBack="True">
                <asp:ListItem Text="Select Crust..." />
                <asp:ListItem Text="Thin" Value="Thin" />
                <asp:ListItem Text="Regular" Value="Regular" />
                <asp:ListItem Text="Thick (+ 2,=)" Value="Thick" />
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <div class="checkbox"><label><asp:CheckBox ID="sausageCheckbox" runat="server" AutoPostBack="True" OnCheckedChanged="getTotal"/>Sausage</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckbox" runat="server" AutoPostBack="True" OnCheckedChanged="getTotal"/>Pepperoni</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="onionsCheckbox" runat="server" AutoPostBack="True" OnCheckedChanged="getTotal"/>Onions</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="greenPeppersCheckbox" runat="server" AutoPostBack="True" OnCheckedChanged="getTotal" />Green Peppers</label></div>
        </div>

        <div class="form-group">
            <h2>Deliver To:</h2>
            <label>Name</label>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Address</label>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Zip</label>
            <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Phone</label>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

            <h2>Payment</h2>
            <div class="radio">
                <label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="paymentGroup" Checked="true"/>cash</label>
            </div>
            <div class="radio">
                <label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="paymentGroup"/>credit</label>
            </div>

            <p><asp:Label ID="resultLabel" runat="server" class="bg-danger"></asp:Label></p>

            <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-primary" OnClick="orderButton_Click" />


            <h2>Total Cost: <asp:Label ID="totalCostLabel" runat="server"></asp:Label></h2>
    </div>
    </form>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
