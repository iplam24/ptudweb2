<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdownlist.aspx.cs" Inherits="MyTest.dropdownlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_city" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_city_SelectedIndexChanged">
                <asp:ListItem>Hà Nội</asp:ListItem>
                <asp:ListItem>Bắc Ninh</asp:ListItem>
                <asp:ListItem>Hưng Yên</asp:ListItem>
                <asp:ListItem>Thái Bình</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lbl_TB" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
