<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testCookies.aspx.cs" Inherits="MyTest.testCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 267px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">Đăng nhập&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Tài khoản</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" Width="304px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_dangNhap" runat="server" OnClick="btn_dangNhap_Click" Text="Lưu cookies" />
                </td>
            </tr>
        </table>
        <div>
            <asp:Label ID="lbltest" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
