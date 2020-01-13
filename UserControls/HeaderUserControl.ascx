<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderUserControl.ascx.cs" Inherits="UserControls_HeaderUserControl" %>
<table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
    <tr>
        <td>
            <asp:Button ID="btnEnquiry" runat="server" Text="Enquiry" OnClick="btnEnquiry_Click" /></td>
        <td style="background-color: #99ffff">
        </td>
        <td>
            <asp:Button ID="btnQuotation" runat="server" Text="Quotation" OnClick="btnQuotation_Click" /></td>
        <td  style="background-color: #99ffff">
        </td>
        <td>
            <asp:Button ID="btnAudits" runat="server" Text="Audits" /></td>
        <td  style="background-color: #99ffff">
        </td>
        <td>
            <asp:Button ID="btnAuditors" runat="server" Text="Auditors" /></td>
        <td  style="background-color: #99ffff">
        </td>
        <td>
            <asp:Button ID="btnReports" runat="server" Text="Reports" /></td>
    </tr>
</table>
