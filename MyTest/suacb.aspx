<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="suacb.aspx.cs" Inherits="MyTest.suacb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            border: 2px solid #0033CC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="3" cellspacing="3" class="auto-style1">
                <tr>
                    <td colspan="2" align="center"><h2>SỬA THÔNG TIN CÁN BỘ</h2></td>
                </tr>
                <tr>
                    <td>Mã CB:</td>
                    <td>
                        <asp:TextBox ID="txtmacb" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Họ và tên:</td>
                    <td>
                        <asp:TextBox ID="txttencb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ngày sinh:</td>
                    <td>
                        <asp:TextBox ID="txtnsinh" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Giới tính:</td>
                    <td>
                        <asp:TextBox ID="txtgioitinh" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Quê quán:</td>
                    <td>
                        <asp:TextBox ID="txtque" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Chức vụ:</td>
                    <td>
                        <asp:TextBox ID="txtchucvu" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btn_update" runat="server" Text="Lưu thông tin" OnClick="btn_update_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
