<%@ Page Language="C#" MasterPageFile="~/Audits/AuditmenuMasterPage.master" AutoEventWireup="true" CodeFile="frmDocReviewInformation.aspx.cs" Inherits="Audits_frmDocReviewInformation" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table border="1" cellpadding="0" cellspacing="0" style="width: 724px" id="TABLE1" onclick="return TABLE1_onclick()">
        <tr>
            <td colspan="3" style="font-weight: bold; font-size: 14pt; width: 612px; color: #99ffff;
                height: 22px; background-color: darkblue">
                Doc. Review Information</td>
            <td colspan="1" style="font-weight: bold; font-size: 14pt; width: 188px; color: #99ffff;
                height: 22px; background-color: darkblue">
            </td>
        </tr>
        <tr>
            <td style="width: 71629px">
                File No.:</td>
            <td align="left" style="width: 1369px">
                <asp:Label ID="lblFileNo" runat="server" Width="176px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
            <td style="width: 25841px; height: 19px;">
                File Date:</td>
            <td style="width: 188px">
                <asp:Label ID="lblFileDate" runat="server" Width="132px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" style="width: 71629px">
                File Storage:</td>
            <td align="left" style="width: 1369px">
                <asp:Label ID="lblFileStorage" runat="server" Width="176px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
            <td style="width: 25841px" >
                Enquiry Type:</td>
            <td style="width: 188px">
                <asp:Label ID="lblEnqType" runat="server" Width="132px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" style="width: 71629px" >
                Enquiry No.:</td>
            <td align="left" style="width: 1369px" >
                <asp:Label ID="lblEnqNo" runat="server" Width="176px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
            <td style="width: 25841px; height: 38px">
                Enquiry Date:</td>
            <td style="width: 188px" >
                <asp:Label ID="lblEnqDate" runat="server" Width="132px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" style="width: 71629px">
                Quotation No.:</td>
            <td align="left" style="width: 1369px">
                <asp:Label ID="lblQuotNo" runat="server" Width="176px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
            <td style="width: 25841px" >
                Quotation Date:</td>
            <td style="width: 188px">
                <asp:Label ID="lblQuotDate" runat="server" Width="132px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 71629px">
                Compnay Name:</td>
            <td style="width: 1369px">
                <asp:Label ID="lblCompName" runat="server" Width="176px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
            <td style="width: 25841px" >
                SIC Code:</td>
            <td style="width: 188px">
                <asp:Label ID="lblSICCode" runat="server" Width="132px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 71629px">
                Audit Frequency:</td>
            <td style="width: 1369px">
                <asp:Label ID="lblAuditFreq" runat="server" Width="176px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
            <td style="width: 25841px" >
                Accrediation Body:</td>
            <td style="width: 188px">
                <asp:Label ID="lblAccrBody" runat="server" Width="132px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 71629px" >
                Scope:</td>
            <td align="left" colspan="1" style="width: 1369px">
                <asp:Label ID="lblScope" runat="server" Width="202px" Font-Bold="True" Height="76px" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 71629px" >
                Certificate Type:</td>
            <td align="left" colspan="1" style="width: 1369px" >
                <asp:Label ID="lblCertType" runat="server" Width="177px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
            <td align="left" colspan="1" style="width: 25841px" >
                Certificate No.:</td>
            <td align="left" colspan="4" style="width: 133px">
                <asp:Label ID="lblCertNo" runat="server" Width="140px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 71629px" >
                Certificate Date:</td>
            <td align="left" colspan="1" style="width: 1369px">
                <asp:Label ID="lblCertDate" runat="server" Font-Bold="True" Font-Size="Small" Width="177px"></asp:Label>&nbsp;</td>
            <td align="left" colspan="1" style="width: 25841px">
                Certificate Validity:</td>
            <td align="left" colspan="4" style="width: 133px">
                <asp:Label ID="lblCertValidDate" runat="server" Font-Bold="True" Font-Size="Small" Width="142px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 71629px" >
                Conformance ManDays:</td>
            <td align="left" colspan="1" style="width: 1369px" >
                <asp:Label ID="lblConformDay" runat="server" Width="175px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
            <td align="left" colspan="1" >
                Survillance ManDays:</td>
            <td align="left" colspan="4" style="width: 133px">
                <asp:Label ID="lblSurvillanceDay" runat="server" Width="142px" Font-Bold="True" Font-Size="Small"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 71629px" >
                Received Date:</td>
            <td align="left" colspan="1" style="width: 1369px" >
                <cc1:GMDatePicker ID="GMDatePicker3" runat="server" InitialValueMode="Null" Font-Size="Small">
                </cc1:GMDatePicker>
            </td>
            <td align="left" colspan="1" style="width: 25841px" >
                Conducted Date:</td>
            <td align="left" colspan="4" style="width: 133px">
                <cc1:GMDatePicker ID="GMDatePicker6" runat="server" InitialValueMode="Null" Font-Size="Small">
                </cc1:GMDatePicker>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="width: 71629px; height: 22px;" >
                Reviewed By:</td>
            <td align="left" colspan="4" style="height: 22px">
                <asp:TextBox ID="txtReviewBy" runat="server" Width="168px" Font-Bold="True" Font-Size="Small"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" colspan="1" >
                Comment From AQA:</td>
            <td align="left" colspan="1" style="width: 1369px" >
                <asp:TextBox ID="txtComment" runat="server" Width="168px" Font-Bold="True" Font-Size="Small"></asp:TextBox></td>
            <td align="left" colspan="1">
                Sent Date:</td>
            <td align="left" colspan="1" style="width: 188px">
                <cc1:GMDatePicker ID="GMDatePicker8" runat="server" InitialValueMode="Null" Font-Size="Small">
                </cc1:GMDatePicker>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" >
                CA Response Date:</td>
            <td align="left" colspan="1" style="width: 1369px" >
                <cc1:GMDatePicker ID="GMDatePicker7" runat="server" InitialValueMode="Null" Font-Size="Small">
                </cc1:GMDatePicker>
            </td>
            <td align="left" colspan="4" style="width: 433px" >
                </td>
        </tr>
        <tr>
            <td align="center" colspan="7">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="center" colspan="10">
                <span style="font-size: 16pt"><strong>Payment Details</strong></span></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px; width: 71629px;">
                Inv. No.:</td>
            <td align="left" colspan="1" style="width: 1369px">
                <asp:TextBox ID="txtInvNo" runat="server" Font-Bold="True" Width="168px" Font-Size="Small"></asp:TextBox></td>
            <td align="left" colspan="1" style="width: 25841px">
                Inv.Date.</td>
            <td align="left" colspan="7">
                <cc1:GMDatePicker ID="GMDatePicker4" runat="server" InitialValueMode="Null" Font-Size="Small">
                </cc1:GMDatePicker>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px; width: 71629px;">
                Fees Rs.:</td>
            <td align="left" colspan="1" style="width: 1369px">
                <asp:TextBox ID="txtfeeRs" runat="server" Font-Bold="True" Width="168px" Font-Size="Small"></asp:TextBox></td>
            <td align="left" colspan="1" style="width: 25841px; height: 18px">
                Fees Dollar:</td>
            <td align="left" colspan="7" style="height: 18px">
                <asp:TextBox ID="txtfeeDollar" runat="server" Font-Bold="True" Width="138px" Font-Size="Small"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px; width: 71629px;">
                Fees Paid Rs.:</td>
            <td align="left" colspan="1" style="width: 1369px; height: 18px">
                <asp:TextBox ID="txtfeePaidRs" runat="server" Font-Bold="True" Width="168px" Font-Size="Small"></asp:TextBox></td>
            <td align="left" colspan="1" style="width: 25841px; height: 18px">
                Fees Paid Dollar:</td>
            <td align="left" colspan="7" style="height: 18px">
                <asp:TextBox ID="txtFeePaidDollar" runat="server" Font-Bold="True" Width="138px" Font-Size="Small"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 18px; width: 71629px;">
                Fees Paid Date:</td>
            <td align="left" colspan="1" style="width: 1369px; height: 18px">
                <cc1:GMDatePicker ID="GMDatePicker5" runat="server" InitialValueMode="Null" Font-Size="Small">
                </cc1:GMDatePicker>
            </td>
            <td align="left" colspan="1" style="width: 25841px; height: 18px">
            </td>
            <td align="left" colspan="7" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="10">
                <asp:Button ID="btnFollwups" runat="server" Text="Follow Ups" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="10">
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Width="457px"></asp:Label>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

