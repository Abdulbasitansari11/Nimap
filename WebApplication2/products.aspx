<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="WebApplication2.products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Panel ID="Panel1" runat="server" Height="406px" HorizontalAlign="Center">
                <h1 style="text-align: center">PRODUCT
                </h1>
                <asp:Label ID="Label1" runat="server" Text="PRODUCT NAME"></asp:Label>
                <br /><br />
                <asp:TextBox ID="TextBox1" runat="server" Height="20px"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button1" runat="server" Text="SAVE" OnClick="Button1_Click1" />
                <br /><br />
                <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
                </asp:GridView>
            </asp:Panel> 
        </div>
    </form>
</body>
</html>
