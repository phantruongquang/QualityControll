<%@ Page Language="C#" MasterPageFile="~/Enquiry/EnquiryMasterPage.master" AutoEventWireup="true" CodeFile="frmCreateEnquiry.aspx.cs" Inherits="Enquiry_Create_frmCreateEnquiry" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="1" cellpadding="0" cellspacing="0" align="left">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Enquiry Information</td>
        </tr>
        <tr>
            <td align="left">
                Enquiry No.:</td>
            <td align="left">
                <asp:TextBox ID="txtEnqNo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Registration Scope:</td>
            <td align="left">
                <asp:TextBox ID="txtRegisScope" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Auditor Freq.Type:</td>
            <td align="left">
                <asp:DropDownList ID="ddlAuditFreqType" runat="server" Width="125px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left">
                Hear About AQA:</td>
            <td align="left">
                <asp:TextBox ID="txtHearAbout" runat="server" Width="186px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                ConsenGd Earlier:</td>
            <td align="left">
                <asp:TextBox ID="txtConsenGd" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Compiled By:</td>
            <td align="left">
                <asp:TextBox ID="txtCompiledBy" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Designation:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Enquiry Date:</td>
            <td align="left" style="width: 196px">
                <cc1:GMDatePicker ID="GMDatePicker1" runat="server">
                </cc1:GMDatePicker>
            </td>
        </tr>
        <tr>
            <td align="left">
                Enquiry Type:</td>
            <td align="left">
                <asp:TextBox ID="txtEnqType" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Certificate Type:</td>
            <td align="left">
                <asp:DropDownList ID="ddlCertificate" runat="server" Width="131px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left">
                Accrediation Body Type:</td>
            <td align="left">
                <asp:DropDownList ID="ddlAccrBody" runat="server" Width="130px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left">
                Conformance Mandays:</td>
            <td align="left">
                <asp:TextBox ID="txtConformanceDay" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Surviliance Mandays:</td>
            <td align="left">
                <asp:TextBox ID="txtSurvilianceDay" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                <asp:LinkButton ID="lnkCompany" runat="server" Font-Bold="True" ForeColor="Navy" OnClick="lnkCompany_Click">Company Information</asp:LinkButton></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

