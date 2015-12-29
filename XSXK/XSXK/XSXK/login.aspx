<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="XSXK.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body link="#000000" vlink="#000000" alink="#000000">
		<form id="Form1" runat="server">
			<table  align="center" cellpadding="0" cellspacing="0" height="257" width=60%>
				<tr class=MFont>
					<td bgcolor="#e8f5ff" align="center">
						<p>帐号:
								<asp:TextBox id="txtAdmin" runat="server" Width="104px" BorderStyle="Solid" BorderWidth="1px"
									Font-Names="宋体" Font-Size="Medium"></asp:TextBox>
						</p>
						<p>密码:
								<asp:TextBox id="txtPassword" runat="server" Width="104px" 
                                BorderStyle="Solid" BorderWidth="1px"
									Font-Names="宋体" Font-Size="Medium" TextMode="Password"></asp:TextBox><br>
						</p>
					</td>
				</tr>
				<tr>
					<td bgcolor="#e8f5ff" align="center">
						<P><font color="#000000">
								&nbsp;&nbsp;&nbsp;&nbsp;
								<asp:Button id="lnBtn" runat="server" Text="登陆" onclick="lnBtn_Click"></asp:Button>&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button 
                                ID="Button3" runat="server" Height="20px" onclick="Button3_Click" Text="注册" />
                            &nbsp;&nbsp;&nbsp;&nbsp;
								
						   </font>
						</P>
					</td>
				</tr>
			</table>
		</form>
	</body>
</html>
