<%@ Page Language="C#" MasterPageFile="~/Enquiry/EnquiryMasterPage.master" AutoEventWireup="true" CodeFile="frmEnquiryCompanyInformation.aspx.cs" Inherits="Enquiry_Create_frmCompanyInformation" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="left" border="1" cellpadding="0" cellspacing="0" style="width: 717px">
        <tr>
            <td align="center" colspan="4" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Enquiry Information</td>
        </tr>
        <tr>
            <td align="left">
                Enquiry No.:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtEnqNo" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
                Organization Name:</td>
            <td align="left">
                <asp:TextBox ID="txtCompanyName" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt; color: darkblue">
                Mailing Address</td>
            <td align="left" style="font-weight: bold; font-size: 12pt; color: darkblue; width: 268px;">
            </td>
            <td align="left" style="font-weight: bold; font-size: 12pt; color: darkblue">
                Physical Location</td>
            <td align="left" style="font-weight: bold; font-size: 12pt; color: darkblue">
            </td>
        </tr>
        <tr>
            <td align="left">
                1</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtMailAddr1" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
                1</td>
            <td align="left">
                <asp:TextBox ID="txtAddr1" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                2</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtMailAddr2" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
                2</td>
            <td align="left">
                <asp:TextBox ID="txtAddr2" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Contact Person:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtContactPerson" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
                Title:</td>
            <td align="left">
                <asp:TextBox ID="txtTitle" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Phone:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtPhone" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
                Mobile:</td>
            <td align="left">
                <asp:TextBox ID="txtMobile" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Fax:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtFax" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
                Email:</td>
            <td align="left">
                <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                City:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtCity" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
                State:</td>
            <td align="left">
                <asp:TextBox ID="txtState" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Country:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtCountry" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left" style="width: 196px">
                Audit Location:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtAuditLocation" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Conformance Days:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtConformanceDay" runat="server" Width="150px"></asp:TextBox>&nbsp;</td>
            <td align="left" style="width: 196px">
                Surviliance Days:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtSurvilianceDay" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" colspan="4" style="font-weight: bold; font-size: 12pt; color: darkblue">
                Shift Information</td>
        </tr>
        <tr>
            <td align="left">
            </td>
            <td align="left" style="font-weight: bold; font-size: 12pt; width: 268px;">
                General Shift</td>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Shift1</td>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                </td>
        </tr>
        <tr>
            <td align="left">
                Time:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtTime1" runat="server" Width="94px"></asp:TextBox></td>
            <td align="left">
                <asp:TextBox ID="txtTime2" runat="server" Width="95px"></asp:TextBox></td>
            <td align="left">
                </td>
        </tr>
        <tr>
            <td align="left" style="height: 10px">
                No. Of Employees:</td>
            <td align="left" style="width: 268px; height: 10px">
                <asp:TextBox ID="txtEmpNo1" runat="server" Width="94px"></asp:TextBox></td>
            <td align="left" style="height: 10px">
                <asp:TextBox ID="txtEmpNo2" runat="server" Width="95px"></asp:TextBox></td>
            <td align="left" style="height: 10px">
                </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                SIC Code:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtSiCCode" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                IAF Code:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtIAFCode" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Industry Type:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtIndustryType" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Scope Of Registration:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtRegisScope" runat="server" Width="150px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Application For Registration:</td>
            <td align="left" style="font-weight: bold; font-size: 12pt; width: 268px;">
                Surviliance Frequency</td>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Accrediation Body</td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:DropDownList ID="ddlCertificate" runat="server" Width="155px">
                </asp:DropDownList></td>
            <td align="left" style="width: 268px">
                <asp:DropDownList ID="ddlAuditFreqType" runat="server" Width="113px">
                </asp:DropDownList>Months</td>
            <td align="left">
                <asp:DropDownList ID="ddlAccrBody" runat="server" Width="159px">
                </asp:DropDownList></td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="4" style="font-weight: bold; font-size: 12pt; color: darkblue">
                Enquiry Information</td>
        </tr>
        <tr>
            <td align="left">
                Hear About AQA From:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtHearAbt" runat="server" Width="155px"></asp:TextBox></td>
            <td align="left">
                Consultant Engaged Earlier:<br />
                (With Whom)</td>
            <td align="left">
                <asp:TextBox ID="txtConsEng" runat="server" Width="155px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Completed By:</td>
            <td align="left" style="width: 268px">
                <asp:TextBox ID="txtCompletedBy" runat="server" Width="155px"></asp:TextBox></td>
            <td align="left">
                Designation:</td>
            <td align="left">
                <asp:TextBox ID="txtDesignation" runat="server" Width="155px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Enquiry Date:</td>
            <td align="left" style="width: 268px">
                <cc1:gmdatepicker id="GMDatePicker1" runat="server"></cc1:gmdatepicker>
            </td>
            <td align="left">
                Enquiry Type:</td>
            <td align="left">
                <asp:TextBox ID="txtEnqtype" runat="server" Width="155px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Button ID="btnSubmit" runat="server"  Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

