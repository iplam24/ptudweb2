<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vd_validator.aspx.cs" Inherits="MyTest.vd_validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 533px;
            border: 1px solid #000080;
        }
        .auto-style2 {
            width: 364px;
        }
        .auto-style3 {
            margin-left: 1px;
        }
        .auto-style4 {
            width: 141px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="get" action="XuLu_Form.aspx">
        <div>
            <table cellpadding="2" class="auto-style1">
                <tr>
                    <td colspan="2">THÔNG TIN ĐĂNG KÝ THÀNH VIÊN</td>
                </tr>
                <tr>
                    <td class="auto-style4">Tên đăng nhập:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtname" runat="server" CssClass="auto-style3"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" Display="Dynamic" ErrorMessage="Không được để trống tên đăng nhập">Không được để trống tên đăng nhập</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Mật khẩu:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Nhập khẩu nhập lại:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtRepass" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpass" ControlToValidate="txtRepass" Display="Dynamic" ErrorMessage="Mật khẩu nhập lại không đúng"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Độ tuổi:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" Display="Dynamic" ErrorMessage="Độ tuổi phải từ 6 đến 12 tuổi" MaximumValue="12" MinimumValue="6" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Email:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Số điện thoại:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtsdt" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtsdt" Display="Dynamic" ErrorMessage="Số điện thoại không đúng định dạng" ValidationExpression="[0-9]{3}-[0-9]{3}\s[0-9]{4}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Đăng ký" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
