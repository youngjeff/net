<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelCourse.aspx.cs" Inherits="Student.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 学生选课<br />
    
        <asp:GridView ID="GVcourse" runat="server" >
        </asp:GridView>
        <br />
         学&nbsp;&nbsp; 号：<asp:TextBox ID="txtXH" runat="server"></asp:TextBox>
    <br />
    <br />
    课 程 号 ：<asp:TextBox ID="txtKCH" runat="server"></asp:TextBox>
    <br />
        <br />
        <asp:Button ID="stuTJ" runat="server" onclick="Button1_Click" Text="提交" />
        &nbsp;
        <asp:Button ID="StuTX" runat="server" onclick="StuTX_Click" Text="退选" />
&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="更新" />
        <br />
    <br />
    
    </div>
    </form>
</body>
</html>
