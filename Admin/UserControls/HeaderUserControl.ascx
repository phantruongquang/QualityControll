<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderUserControl.ascx.cs" Inherits="Admin_UserControls_HeaderUserControl" %>
<table border="0" cellpadding="0" cellspacing="0" style="width: 35%">
    <tr>
        <td style="width: 70px">
            <asp:Button ID="btnEnquiry" runat="server" Text="Enquiry" OnClick="btnEnquiry_Click" /></td>
        <td style="background-color: #99ffff">
        </td>
        <td style="width: 81px">
            <asp:Button ID="btnQuotation" runat="server" Text="Quotation" OnClick="btnQuotation_Click" /></td>
        <td  style="background-color: #99ffff">
        </td>
        <td style="width: 50px">
            <asp:Button ID="btnAudits" runat="server" Text="Audits" OnClick="btnAudits_Click" /></td>
        <td  style="background-color: #99ffff">
        </td>
        <td style="width: 57px">
            <asp:Button ID="btnAuditors" runat="server" Text="Auditors" OnClick="btnAuditors_Click" /></td>
        <td  style="background-color: #99ffff">
        </td>
        <td>
            <asp:Button ID="btnReports" runat="server" Text="Reports" OnClick="btnReports_Click" /></td>
        <td>
            <asp:Button ID="btnAdmin" runat="server" Text="Admin" OnClick="btnAdmin_Click" /></td>
    </tr>
</table>
