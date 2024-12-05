<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HienCB.aspx.cs" Inherits="MyTest.HienCB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server" CssClass="tieude">
                    <asp:TableCell runat="server">STT</asp:TableCell>
                    <asp:TableCell runat="server">Mã CB</asp:TableCell>
                    <asp:TableCell runat="server">Họ tên</asp:TableCell>
                    <asp:TableCell runat="server">Ngày sinh</asp:TableCell>
                    <asp:TableCell runat="server">Giới tính</asp:TableCell>
                    <asp:TableCell runat="server">Quê quán</asp:TableCell>
                    <asp:TableCell runat="server">Chức vụ</asp:TableCell>
                    <asp:TableCell runat="server">Cập nhật</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
