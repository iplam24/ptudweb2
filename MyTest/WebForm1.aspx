<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyTest.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="3" cellspacing="4" style="width: 450px; border: 1px solid #CCFFFF">
        <tr>
            <td colspan="2">Đăng nhập&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 112px">Tài khoản</td>
            <td>
                <asp:TextBox ID="txtusername" runat="server" Height="23px" Width="218px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 112px">Mật khẩu</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" Height="23px" TextMode="Password" Width="218px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Height="37px" OnClick="Button1_Click" Text="Đăng nhập" Width="83px" />
            </td>
        </tr>
    </table>
</asp:Content>
