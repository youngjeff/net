<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuSel.aspx.cs" Inherits="Student.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp; 课程信息维护</div>
    <asp:GridView ID="GVstu" runat="server" 
   >
    </asp:GridView>
    <br />
    学&nbsp;&nbsp; 号：<asp:TextBox ID="txtXH" runat="server"></asp:TextBox>
    <br />
    <br />
    课 程 号 ：<asp:TextBox ID="txtKCH" runat="server"></asp:TextBox>
    <br />
    <br />
    成&nbsp;&nbsp; 绩：<asp:TextBox ID="txtCJ" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="查询" />
&nbsp;
    <asp:Button ID="StuXG" runat="server" onclick="Button1_Click" Text="修改" />
&nbsp;
    <asp:Button ID="StuZJ" runat="server" onclick="StuZJ_Click" Text="增加" />
&nbsp;
    <asp:Button ID="StuSC" runat="server" onclick="StuSC_Click" Text="删除" />
&nbsp;
    <asp:Button ID="StuGX" runat="server" onclick="StuGX_Click" Text="更新" />
    </form>
</body>
</html>
