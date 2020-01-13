<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftWebUserControl.ascx.cs" Inherits="Enquiry_UserControls_LeftWebUserControl" %>
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
                    <asp:LinkButton ID="lnkBrowse" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkBrowse_Click" Width="123px">Browse</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkCreate" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkCreate_Click" Width="123px">Create</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkModify" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        Width="120px" OnClick="lnkModify_Click">Modify</asp:LinkButton>
                    <br />
                        <asp:LinkButton ID="lnkLogOut" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        OnClick="lnkLogOut_Click" Width="120px">LogOut</asp:LinkButton>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>
