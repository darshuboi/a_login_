<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="a_login_.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
        <div>
            <asp:Label ID="txtEml" runat="server" Text="email :"></asp:Label>
&nbsp;      <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="txtPass" runat="server" Text="Password :"></asp:Label>
&nbsp;      <asp:TextBox ID="txtpass1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLog" runat="server" Text="Login" OnClick="btnSub_Click" />
            <br />
        </div>
    </form>
</body>
</html>
