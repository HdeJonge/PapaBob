<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="PapaBob.Web.Orders" %>

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
            <h1>Orders</h1>
            <p class="lead">Manage your orders here</p>
        </div>
        <asp:GridView ID="ordersGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="rowSelected" CssClass="table-condensed table-hover">
            <Columns>
                <asp:BoundField DataField="OrderId" HeaderText="OrderId" />
                <asp:BoundField DataField="Size" HeaderText="Size" />
                <asp:BoundField DataField="Crust" HeaderText="Crust" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="Zip" HeaderText="Zip" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:CheckBoxField DataField="Sausage" HeaderText="Sausage" />
                <asp:CheckBoxField DataField="Pepperoni" HeaderText="Pepperoni" />
                <asp:CheckBoxField DataField="GreenPeppers" HeaderText="Green Peppers" />
                <asp:CheckBoxField DataField="Onions" HeaderText="Onions" />
                <asp:BoundField DataField="Payment" HeaderText="Payment" />
                <asp:BoundField DataField="TotalCost" HeaderText="Total Cost" />
                <asp:ButtonField Text="Completed" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
