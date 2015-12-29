<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="three.aspx.cs" Inherits="XSXK.selectCourse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp; 主界面<br />
        添加课程信息&nbsp; 
        <asp:Button ID="tianJia" runat="server" onclick="tianJia_Click" Text="进入" />
        <br />
        <br />
        学生选课&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="sele" runat="server" onclick="sele_Click" Text="进入" />
        <br />
        <br />
        课程信息维护&nbsp; 
        <asp:Button ID="weiHu" runat="server" onclick="weiHu_Click" 
            style="height: 21px" Text="进入" />
        <br />
    
    </div>
    </form>
</body>
</html>
