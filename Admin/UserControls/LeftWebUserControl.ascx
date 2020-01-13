<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftWebUserControl.ascx.cs" Inherits="Admin_UserControls_LeftWebUserControl" %>
<table border="0" cellpadding="0" cellspacing="0" style="height: 526px">
    <tr>
        <td align="left" style="background-color: darkblue" valign="middle">
            <br />
            <br />
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:LinkButton ID="lnkHome" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkHome_Click" Width="123px">Home</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkUser" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkUser_Click" Width="123px">User</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkAccreBody" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkAccreBody_Click" Width="123px">Accr. Body</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkCertificate" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        Width="120px" OnClick="lnkCertificate_Click">Certificate</asp:LinkButton>
                    <br />
                    <br />
                    <asp:LinkButton ID="lnkAuditFreq" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" OnClick="lnkAuditFreq_Click" Width="120px">Audit Freq.</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkAuditor" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" OnClick="lnkAuditor_Click" Width="120px">Auditor</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkCommunication" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" OnClick="lnkCommunication_Click" Width="120px">Communication</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkFeedback" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" OnClick="lnkFeedback_Click" Width="120px">Feedback</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkAudit" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkAudit_Click" Width="120px">Audit</asp:LinkButton><br />
                    <br />
                   <asp:LinkButton ID="lnkLogOut" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkLogOut_Click" Width="120px">LogOut</asp:LinkButton>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>
