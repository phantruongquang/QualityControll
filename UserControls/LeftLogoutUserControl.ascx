<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftLogoutUserControl.ascx.cs" Inherits="UserControls_LeftLogoutUserControl" %>
<table border="0" cellpadding="0" cellspacing="0" style="height: 526px">
    <tr>
        <td align="center" style="background-color: darkblue" valign="middle">
            <br />
            <br />
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" PostBackUrl="~/Default.aspx" Width="123px">Home</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" PostBackUrl="~/frmContactUs.aspx" Width="123px">Contact Us</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" PostBackUrl="~/frmAboutUs.aspx" Width="120px">About Us</asp:LinkButton>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" PostBackUrl="~/frmFeedBack.aspx" Width="120px">FeedBack</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" OnClick="LinkButton5_Click" PostBackUrl="~/frmLogin.aspx"
                        Width="120px">Logout</asp:LinkButton>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>
