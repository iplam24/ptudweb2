<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HienCB1.aspx.cs" Inherits="MyTest.HienCB1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tblhiencb" runat="server">
                <asp:TableRow runat="server" CssClass="tieude">
                    <asp:TableCell runat="server">STT</asp:TableCell>
                    <asp:TableCell runat="server">Mã CB</asp:TableCell>
                    <asp:TableCell runat="server">Họ tên</asp:TableCell>
                    <asp:TableCell runat="server">Ngày sinh</asp:TableCell>
                    <asp:TableCell runat="server">Giới tính</asp:TableCell>
                    <asp:TableCell runat="server">Quê</asp:TableCell>
                    <asp:TableCell runat="server">Chức vu</asp:TableCell>
                     <asp:TableCell runat="server">Ảnh thẻ</asp:TableCell>
                    <asp:TableCell runat="server">Cập nhật</asp:TableCell>
             
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />
        </div>
    </form>
    <div>
        <a href="ThemCB.aspx">Thêm cán bộ</a>
    </div>
</body>
</html>
