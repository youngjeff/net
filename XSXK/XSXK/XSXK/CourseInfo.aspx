<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseInfo.aspx.cs" Inherits="XSXK.CourseInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        KCH&nbsp;
        <asp:TextBox ID="KCH" runat="server" Width="146px"></asp:TextBox>
        <br />
        <br />
        KCM&nbsp;
        <asp:TextBox ID="KCM" runat="server" Width="146px"></asp:TextBox>
        <br />
        <br />
        LB&nbsp;
        <asp:TextBox ID="LB" runat="server" Width="146px"></asp:TextBox>
        <br />
        <br />
        XQ&nbsp;
        <asp:TextBox ID="XQ" runat="server" Width="146px"></asp:TextBox>
        <br />
        <br />
        XS&nbsp;
        <asp:TextBox ID="XS" runat="server" Width="146px"></asp:TextBox>
        <br />
        <br />
        XF&nbsp;
        <asp:TextBox ID="XF" runat="server" Width="146px"></asp:TextBox>
        <br />
&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="finBtn" runat="server" onclick="finBtn_Click" Text="完成" />
        <br />
    
    </div>
    </form>
</body>
</html>
