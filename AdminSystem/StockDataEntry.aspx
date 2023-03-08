<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblItem_Id" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Item ID"></asp:Label>

            <asp:TextBox ID="txtItemId" runat="server" style="z-index: 1; left: 74px; top: 15px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblItemName" runat="server" BorderStyle="None" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Item Name"></asp:Label>
            <asp:TextBox ID="txtItemName" runat="server" style="z-index: 1; left: 90px; top: 53px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblItemDescription" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Item Description"></asp:Label>
            <asp:TextBox ID="txtItemDescription" runat="server" style="z-index: 1; left: 122px; top: 91px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblItemAvailable" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Item Available"></asp:Label>
            <asp:RadioButton ID="radYes" runat="server" style="z-index: 1; left: 106px; top: 129px; position: absolute" Text="Yes" />
            <asp:RadioButton ID="radNo" runat="server" style="z-index: 1; left: 170px; top: 129px; position: absolute" Text="No" />
            <br />
            <br />
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Quantity Available"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 138px; top: 167px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPPI" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Price Per Item"></asp:Label>
            <asp:TextBox ID="txtPPI" runat="server" style="z-index: 1; left: 106px; top: 205px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRestockDate" runat="server" style="z-index: 1; left: 10px; top: 243px; position: absolute" Text="Restock Date"></asp:Label>
            <asp:TextBox ID="txtRestock" runat="server" style="z-index: 1; left: 106px; top: 243px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 106px; top: 300px; position: absolute" Text="Submit" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 218px; top: 300px; position: absolute" Text="Cancel" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
