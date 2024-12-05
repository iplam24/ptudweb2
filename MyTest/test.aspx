<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="MyTest.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lbl_TB" runat="server"></asp:Label>
            <br />
            Số điện thoại nhà riêng:&nbsp;
            <asp:TextBox ID="txt_home" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            Số điện thoại cơ quan:&nbsp;&nbsp;
            <asp:TextBox ID="txt_work" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chk_copy" runat="server" AutoPostBack="True" OnCheckedChanged="chk_copy_CheckedChanged" Text="Sao chép" />
            <br />
        </div>
    </form>
</body>
</html>
