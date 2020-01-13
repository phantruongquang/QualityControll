<%@ Page Language="C#" MasterPageFile="~/Reports/ReportsMasterPage.master" AutoEventWireup="true" CodeFile="frmCompanyAddresInformationReport.aspx.cs" Inherits="Reports_frmCompanyAddresInformationReport" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="left" border="1" cellpadding="0" cellspacing="0" style="width: 659px;
        color: darkblue; background-color: #ccccff">
        <tr>
            <td align="center" colspan="4" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Enquiry Information</td>
        </tr>
        <tr>
            <td align="left">
                Enquiry No.:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtEnqNo" runat="server" ReadOnly="True" Width="134px"></asp:TextBox></td>
            <td align="left">
                Organization Name:</td>
            <td align="left">
                <asp:TextBox ID="txtCompanyName" runat="server" ReadOnly="True" Width="193px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt; color: darkblue">
                Mailing Address</td>
            <td align="left" style="font-weight: bold; font-size: 12pt; width: 242px; color: darkblue">
            </td>
            <td align="left" style="font-weight: bold; font-size: 12pt; color: darkblue">
                Physical Location</td>
            <td align="left" style="font-weight: bold; font-size: 12pt; color: darkblue">
            </td>
        </tr>
        <tr>
            <td align="left">
                1</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtMailAddr1" runat="server" ReadOnly="True" TextMode="MultiLine"
                    Width="200px"></asp:TextBox></td>
            <td align="left">
                1</td>
            <td align="left">
                <asp:TextBox ID="txtAddr1" runat="server" ReadOnly="True" TextMode="MultiLine" Width="199px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                2</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtMailAddr2" runat="server" ReadOnly="True" TextMode="MultiLine"
                    Width="200px"></asp:TextBox></td>
            <td align="left">
                2</td>
            <td align="left">
                <asp:TextBox ID="txtAddr2" runat="server" ReadOnly="True" TextMode="MultiLine" Width="199px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="height: 26px">
                Contact Person:</td>
            <td align="left" style="width: 242px; height: 26px">
                <asp:TextBox ID="txtContactPerson" runat="server" ReadOnly="True" Width="199px"></asp:TextBox></td>
            <td align="left" style="height: 26px">
                Title:</td>
            <td align="left" style="height: 26px">
                <asp:TextBox ID="txtTitle" runat="server" ReadOnly="True" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Phone:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtPhone" runat="server" ReadOnly="True" Width="199px"></asp:TextBox></td>
            <td align="left">
                Mobile:</td>
            <td align="left">
                <asp:TextBox ID="txtMobile" runat="server" ReadOnly="True" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Fax:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtFax" runat="server" ReadOnly="True" Width="199px"></asp:TextBox></td>
            <td align="left">
                Email:</td>
            <td align="left">
                <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                City:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtCity" runat="server" ReadOnly="True" Width="199px"></asp:TextBox></td>
            <td align="left">
                State:</td>
            <td align="left">
                <asp:TextBox ID="txtState" runat="server" ReadOnly="True" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Country:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtCountry" runat="server" ReadOnly="True" Width="199px"></asp:TextBox></td>
            <td align="left" style="width: 196px">
                Audit Location:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtAuditLocation" runat="server" ReadOnly="True" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Conformance Days:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtConformanceDay" runat="server" ReadOnly="True" Width="199px"></asp:TextBox>&nbsp;</td>
            <td align="left" style="width: 196px">
                Surviliance Days:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtSurvilianceDay" runat="server" ReadOnly="True" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

