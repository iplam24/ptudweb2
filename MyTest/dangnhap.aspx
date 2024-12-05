<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="MyTest.dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 450px;
            border: 2px solid #3333CC;
        }
        .auto-style2 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Panel ID="Panel1" runat="server">
            <table cellpadding="2" cellspacing="3" class="auto-style1">
                <tr>
                    <td colspan="2" align="center">ĐĂNG NHẬP</td>
                </tr>
                <tr>
                    <td>Tên đăng nhập:</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Mật khẩu</td>
                    <td>
                        <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2" align="center">
                        <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" OnClick="btnLogin_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        </div>
        
    </form>
</body>
</html>
