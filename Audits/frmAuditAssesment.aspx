<%@ Page Language="C#" MasterPageFile="~/Audits/AuditmenuMasterPage.master" AutoEventWireup="true" CodeFile="frmAuditAssesment.aspx.cs" Inherits="Audits_frmAuditAssesment" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 629px">
        <tr>
            <td colspan="3" style="font-weight: bold; font-size: 14pt; width: 612px; color: #99ffff;
                height: 22px; background-color: darkblue">
                Audit Information</td>
            <td colspan="1" style="font-weight: bold; font-size: 14pt; width: 612px; color: #99ffff;
                height: 22px; background-color: darkblue">
            </td>
        </tr>
        <tr>
            <td>
                File No.:</td>
            <td align="left" style="height: 19px">
                <asp:Label ID="lblFileNo" runat="server" Width="176px"></asp:Label></td>
            <td style="width: 2359px; height: 19px">
                File Date:</td>
            <td style="height: 19px">
                <asp:Label ID="lblFileDate" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left">
                File Storage:</td>
            <td align="left">
                <asp:Label ID="lblFileStorage" runat="server" Width="176px"></asp:Label></td>
            <td style="width: 2359px">
                Enquiry Type:</td>
            <td>
                <asp:Label ID="lblEnqType" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left">
                Enquiry No.:</td>
            <td align="left">
                <asp:Label ID="lblEnqNo" runat="server" Width="176px"></asp:Label></td>
            <td style="width: 2359px">
                Enquiry Date:</td>
            <td>
                <asp:Label ID="lblEnqDate" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left">
                Quotation No.:</td>
            <td align="left">
                <asp:Label ID="lblQuotNo" runat="server" Width="176px"></asp:Label></td>
            <td style="width: 2359px">
                Quotation Date:</td>
            <td>
                <asp:Label ID="lblQuotDate" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td>
                Compnay Name:</td>
            <td>
                <asp:Label ID="lblCompName" runat="server" Width="176px"></asp:Label></td>
            <td style="width: 2359px">
                SIC Code:</td>
            <td>
                <asp:Label ID="lblSICCode" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td>
                Audit Frequency:</td>
            <td>
                <asp:Label ID="lblAuditFreq" runat="server" Width="176px"></asp:Label></td>
            <td style="width: 2359px">
                Accrediation Body:</td>
            <td>
                <asp:Label ID="lblAccrBody" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 4735px">
                Scope:</td>
            <td align="left" colspan="4">
                <asp:Label ID="lblScope" runat="server" Width="489px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 4735px">
                Certificate Type:</td>
            <td align="left" colspan="1">
                <asp:Label ID="lblCertType" runat="server" Width="176px"></asp:Label></td>
            <td align="left" colspan="1" style="width: 2359px">
                Certificate No.:</td>
            <td align="left" colspan="4">
                <asp:Label ID="lblCertNo" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 4735px">
                Certificate Date:</td>
            <td align="left" colspan="1">
                <asp:Label ID="lblCertDate" runat="server" Width="176px"></asp:Label></td>
            <td align="left" colspan="1" style="width: 2359px">
                <strong><span style="font-size: 16pt">Certificate Validity:</span></strong></td>
            <td align="left" colspan="4" style="font-weight: bold; font-size: 16pt">
                <asp:Label ID="lblCertValidityDate" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 4735px">
                Conformance ManDays:</td>
            <td align="left" colspan="1">
                <asp:Label ID="lblConformDay" runat="server" Width="176px"></asp:Label></td>
            <td align="left" colspan="1" style="width: 2359px">
                Survillance ManDays:</td>
            <td align="left" colspan="4">
                <asp:Label ID="lblSurvillanceDay" runat="server" Width="176px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 4735px">
                Requested Date:</td>
            <td align="left" colspan="1">
            </td>
            <td align="left" colspan="1" style="width: 2359px">
                Sheduled Date:</td>
            <td align="left" colspan="4">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 4735px">
                Coducted Date:</td>
            <td align="left" colspan="1">
            </td>
            <td align="left" colspan="1" style="width: 2359px">
                Days:</td>
            <td align="left" colspan="4">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 4735px; height: 19px">
                Lead Auditor:</td>
            <td align="left" colspan="1" style="width: 1098px; height: 19px">
            </td>
            <td align="left" colspan="4" style="height: 19px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="143px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="center" colspan="7">
                <asp:Button ID="btnAddAuditor" runat="server"  Text="Add Auditor" />
                <asp:Button ID="btnAddProvAuditor" runat="server"  Text="Add Prov Auditor" />
                <asp:Button ID="btnAddtechAuditor" runat="server"  Text="Add Tech Auditor" /></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px">
                Report Date:</td>
            <td align="left" colspan="1" style="height: 18px">
            </td>
            <td align="left" colspan="1" style="width: 2359px; height: 18px">
                Recieved From LA:</td>
            <td align="left" colspan="7" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px">
                Reviewed By:</td>
            <td align="left" colspan="1" style="height: 18px">
                <asp:TextBox ID="TextBox1" runat="server" Width="172px"></asp:TextBox></td>
            <td align="left" colspan="1" style="width: 2359px; height: 18px">
                Reviewed Date:</td>
            <td align="left" colspan="7" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px">
                Send To AQA</td>
            <td align="left" colspan="1" style="height: 18px">
            </td>
            <td align="left" colspan="1" style="width: 2359px; height: 18px">
                Recieved From AQA:</td>
            <td align="left" colspan="7" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px">
                Comment From AQA:</td>
            <td align="left" colspan="7" style="height: 18px">
                <asp:TextBox ID="TextBox2" runat="server" Width="469px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="10">
                <span style="font-size: 16pt"><strong>Payment Details</strong></span></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px">
                Inv. No.:</td>
            <td align="left" colspan="1" style="height: 18px">
            </td>
            <td align="left" colspan="1" style="width: 2359px; height: 18px">
                Inv.Date.</td>
            <td align="left" colspan="7" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px">
                Fees Rs.:</td>
            <td align="left" colspan="1" style="height: 18px">
            </td>
            <td align="left" colspan="1" style="width: 2359px; height: 18px">
                Fees Dollar:</td>
            <td align="left" colspan="7" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px">
                Fees Paid Rs.:</td>
            <td align="left" colspan="1" style="height: 18px">
            </td>
            <td align="left" colspan="1" style="width: 2359px; height: 18px">
                Fees Paid Dollar:</td>
            <td align="left" colspan="7" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px">
                Fees Paid Date:</td>
            <td align="left" colspan="1" style="height: 18px">
            </td>
            <td align="left" colspan="1" style="width: 2359px; height: 18px">
            </td>
            <td align="left" colspan="7" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="10">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" /></td>
        </tr>
        <tr>
            <td align="center" colspan="10">
                <asp:Button ID="btnFeedback" runat="server" O Text="Feed Back" />&nbsp;
                <asp:Button ID="btnComm" runat="server"  Text="Communication" />
                <asp:Button ID="btnFollwup" runat="server"  Text="Follw Ups" /></td>
        </tr>
    </table>
</asp:Content>

