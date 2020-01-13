<%@ Page language="c#" Inherits="AqaIndia.sorry" EnableViewStateMac="true" CodeFile="sorry.aspx.cs" %>
<HTML>
	<HEAD>
		<title>RMS Unauthentication Screen</title>
		<LINK href="images/aqastyle.css" rel="stylesheet" type="text/css">
			<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
	</HEAD>
	<body bgcolor="#010066" text="#000000">
		<form name="sorryform" id="sorryform" runat="server">
			<div align="center">
				<table width="783" border="0" cellspacing="0" cellpadding="0" background="images/sorryauthorise.jpg" style="height: 510px">
					<tr>
						<td style="height: 618px">
							<p>&nbsp;</p>
							<p align="center">&nbsp;</p>
							<p align="center">&nbsp;</p>
							<p align="center"><font color="#ffffff" face="verdana" size="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font><asp:ImageButton ID="btnrelogin" Runat="server" ImageUrl="~/Images/sorryauthorise.jpg" OnClick="btnrelogin_click" /></p>
						</td>
					</tr>
				</table>
				<p>&nbsp;</p>
				<p>
				</p>
			</div>
		</form>
	</body>
</HTML>
