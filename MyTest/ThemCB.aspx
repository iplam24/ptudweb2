<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemCB.aspx.cs" Inherits="MyTest.ThemCB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 45%;
            border: 2px solid #3333FF;
        }
        .auto-style2 {
            height: 27px;
        }
    </style>
</head>
<body>
   <body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="3" cellspacing="3" class="auto-style1">
                <tr>
                    <td colspan="2" align="center"><h2>THÊM THÔNG TIN CÁN BỘ</h2></td>
                </tr>
                <tr>
                    <td>Mã cán bộ</td>
                    <td>
                        <asp:TextBox ID="txtmacb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Họ tên</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtten" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ngày sinh</td>
                    <td>
                        <asp:TextBox ID="txtngaysinh" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Giới tính</td>
                    <td>
                        <asp:TextBox ID="txtgioitinh" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Quê quán</td>
                    <td>
                        <asp:TextBox ID="txtque" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Chức vụ</td>
                    <td>
                        <asp:TextBox ID="txtchucvu" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ảnh thẻ&nbsp;</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btlLuu" runat="server" Text="LƯU THÔNG TIN" OnClick="btlLuu_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>

</body>
</html>
