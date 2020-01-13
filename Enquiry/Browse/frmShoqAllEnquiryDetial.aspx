<%@ Page Language="C#" MasterPageFile="~/Enquiry/EnquiryMasterPage.master" AutoEventWireup="true" CodeFile="frmShoqAllEnquiryDetial.aspx.cs" Inherits="Enquiry_Browse_frmShoqAllEnquiryDetial" Title="Untitled Page" %>
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
            <td align="left" colspan="4" style="font-weight: bold; font-size: 12pt; color: darkblue">
                Shift Information</td>
        </tr>
        <tr>
            <td align="left" colspan="4">
             <asp:GridView ID="GridView1" runat="server" Width="377px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                SIC Code:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtSiCCode" runat="server" ReadOnly="True" Width="200px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                IAF Code:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtIAFCode" runat="server" ReadOnly="True" Width="200px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Industry Type:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtIndustryType" runat="server" ReadOnly="True" Width="200px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Scope Of Registration:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtRegisScope" runat="server" ReadOnly="True" Width="200px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Application For Registration:</td>
            <td align="left" style="font-weight: bold; font-size: 12pt; width: 242px">
                Surviliance Frequency</td>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Accrediation Body</td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:TextBox ID="txtCertType" runat="server" ReadOnly="True" Width="155px"></asp:TextBox></td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtFreqType" runat="server" ReadOnly="True" Width="155px"></asp:TextBox>Months</td>
            <td align="left">
                <asp:TextBox ID="txtAccerType" runat="server" ReadOnly="True" Width="155px"></asp:TextBox></td>
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
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtHearAbt" runat="server" ReadOnly="True" TextMode="MultiLine"
                    Width="203px"></asp:TextBox></td>
            <td align="left">
                Consultant Engaged Earlier:<br />
                (With Whom)</td>
            <td align="left">
                <asp:TextBox ID="txtConsEng" runat="server" ReadOnly="True" TextMode="MultiLine"
                    Width="193px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Completed By:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtCompletedBy" runat="server" ReadOnly="True" Width="202px"></asp:TextBox></td>
            <td align="left">
                Designation:</td>
            <td align="left">
                <asp:TextBox ID="txtDesignation" runat="server" ReadOnly="True" Width="193px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Enquiry Date:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtEnqDate" runat="server" ReadOnly="True" Width="202px"></asp:TextBox>&nbsp;</td>
            <td align="left">
                Enquiry Type:</td>
            <td align="left">
                <asp:TextBox ID="txtEnqtype" runat="server" ReadOnly="True" Width="193px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

