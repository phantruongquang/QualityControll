<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftWebUserControl.ascx.cs" Inherits="Reports_UserControls_LeftWebUserControl" %>
<table border="0" cellpadding="0" cellspacing="0" style="height: 526px">
    <tr>
        <td align="center" style="background-color: darkblue" valign="middle">
            <br />
            <br />
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:LinkButton ID="lnkHome" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkHome_Click" Width="123px">Home</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkCompany" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF" Width="123px" OnClick="lnkCompany_Click">Company</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkCommunication" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkCommunication_Click" Width="123px">Communication</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkFeedBack" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        Width="120px" OnClick="lnkFeedBack_Click">FeedBack</asp:LinkButton>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkCertificate" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="120px" OnClick="LinkCertificate_Click">Certificate</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkAuditor" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="120px" OnClick="LinkAuditor_Click">Auditor</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkAudit" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        Width="120px">Audit</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkByDates" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="120px" OnClick="LinkByDates_Click">By Dates</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkAvailAuditors" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="166px" OnClick="LinkAvailAuditors_Click">Avail. Auditors</asp:LinkButton><br />
                    <br />
                   <asp:LinkButton ID="lnkLogOut" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkLogOut_Click" Width="120px">LogOut</asp:LinkButton>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>
