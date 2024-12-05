<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vd_Table.aspx.cs" Inherits="MyTest.vd_Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tbl_vd" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Cột 1</asp:TableCell>
                    <asp:TableCell runat="server">Cột 2</asp:TableCell>
                    <asp:TableCell runat="server">Cột 3</asp:TableCell>
                    <asp:TableCell runat="server">Cột 4</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
