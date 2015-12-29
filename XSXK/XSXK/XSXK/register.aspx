<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="XSXK.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 注册<br />
        <br />
    
        XH&nbsp;
        <asp:TextBox ID="XH" runat="server" Width="125px"></asp:TextBox>
        <br />
        <br />
        XM&nbsp;
        <asp:TextBox ID="XM" runat="server" Width="125px"></asp:TextBox>
        <br />
        <br />
        XB&nbsp;
        <asp:TextBox ID="XB" runat="server" Width="125px"></asp:TextBox>
        <br />
        <br />
        CSSJ&nbsp;
        <asp:TextBox ID="CSSJ" runat="server" Width="125px"></asp:TextBox>
        <br />
        <br />
        ZY&nbsp;
        <asp:TextBox ID="ZY" runat="server" Width="125px"></asp:TextBox>
        <br />
        <br />
        ZXF&nbsp;
        <asp:TextBox ID="ZXF" runat="server" Width="125px"></asp:TextBox>
        <br />
        <br />
        JXJ&nbsp;
        <asp:TextBox ID="JXJ" runat="server" Width="125px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="finBtn" runat="server" onclick="finBtn_Click" Text="提交" />
    
    </div>
    </form>
</body>
</html>
