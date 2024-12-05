<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkboxlist.aspx.cs" Inherits="MyTest.checkboxlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="ckb_items" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ckb_items_SelectedIndexChanged">
                <asp:ListItem>Item1</asp:ListItem>
                <asp:ListItem>Item2</asp:ListItem>
                <asp:ListItem>Item3</asp:ListItem>
                <asp:ListItem>Item4</asp:ListItem>
                <asp:ListItem>Item5</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="lbl_TB" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
