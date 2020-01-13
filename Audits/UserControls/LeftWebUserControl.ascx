<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftWebUserControl.ascx.cs" Inherits="Audits_UserControls_LeftWebUserControl" %>
<table border="0" cellpadding="0" cellspacing="0" style="height: 526px">
    <tr>
        <td align="center" style="background-color: darkblue; width: 170px;" valign="middle">
            <br />
            <br />
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:LinkButton ID="lnkHome" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF" Width="123px">Home</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkBrowse" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF" Width="144px">Doc. Review</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkCreate" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF" Width="162px">Pre. Assesment</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkModify" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF"
                        Width="120px">Conformance</asp:LinkButton>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="145px">I Survillance</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="145px">II Survillance</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Font-Size="18pt"
                        ForeColor="#C0FFFF" Width="164px">III Survillance</asp:LinkButton><br />
                    <br />
                    <asp:LinkButton ID="lnkLogOut" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#C0FFFF" Width="120px">LogOut</asp:LinkButton>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>
