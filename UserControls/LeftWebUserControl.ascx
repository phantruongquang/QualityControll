<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftWebUserControl.ascx.cs" Inherits="UserControls_MainPageWebUserControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<table border="0" cellpadding="0" cellspacing="0" style="height: 526px" >
    <tr>
        <td style="background-color: darkblue;" valign="middle" align="center">
   
            <br />
            <br />
            <br />
            <br />
          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
            <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Font-Size="18pt"
                ForeColor="#C0FFFF" Width="123px" PostBackUrl="~/Default.aspx">Home</asp:LinkButton><br />
                    <br />
   
            <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="18pt"
                ForeColor="#C0FFFF" Width="123px" PostBackUrl="~/frmContactUs.aspx">Contact Us</asp:LinkButton><br />
                    <br />
            <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Font-Size="18pt"
                ForeColor="#C0FFFF" Width="120px" PostBackUrl="~/frmAboutUs.aspx">About Us</asp:LinkButton>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="120px" PostBackUrl="~/frmFeedBack.aspx">FeedBack</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="120px" PostBackUrl="~/frmLogin.aspx">Login</asp:LinkButton>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>

