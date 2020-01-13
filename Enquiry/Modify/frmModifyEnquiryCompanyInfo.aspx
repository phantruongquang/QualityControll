<%@ Page Language="C#" MasterPageFile="~/Enquiry/EnquiryMasterPage.master" AutoEventWireup="true" CodeFile="frmModifyEnquiryCompanyInfo.aspx.cs" Inherits="Enquiry_Modify_frmModifyEnquiryCompanyInfo" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
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
                <asp:TextBox ID="txtEnqNo" runat="server" Width="134px" ReadOnly="True"></asp:TextBox></td>
            <td align="left">
                Organization Name:</td>
            <td align="left">
                <asp:TextBox ID="txtCompanyName" runat="server" Width="193px" ReadOnly="True"></asp:TextBox></td>
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
                <asp:TextBox ID="txtMailAddr1" runat="server" TextMode="MultiLine"
                    Width="200px"></asp:TextBox></td>
            <td align="left">
                1</td>
            <td align="left">
                <asp:TextBox ID="txtAddr1" runat="server" TextMode="MultiLine" Width="199px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                2</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtMailAddr2" runat="server" TextMode="MultiLine"
                    Width="200px"></asp:TextBox></td>
            <td align="left">
                2</td>
            <td align="left">
                <asp:TextBox ID="txtAddr2" runat="server" TextMode="MultiLine" Width="199px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="height: 26px">
                Contact Person:</td>
            <td align="left" style="width: 242px; height: 26px">
                <asp:TextBox ID="txtContactPerson" runat="server" Width="199px"></asp:TextBox></td>
            <td align="left" style="height: 26px">
                Title:</td>
            <td align="left" style="height: 26px">
                <asp:TextBox ID="txtTitle" runat="server" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Phone:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtPhone" runat="server" Width="199px"></asp:TextBox></td>
            <td align="left">
                Mobile:</td>
            <td align="left">
                <asp:TextBox ID="txtMobile" runat="server" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Fax:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtFax" runat="server" Width="199px"></asp:TextBox></td>
            <td align="left">
                Email:</td>
            <td align="left">
                <asp:TextBox ID="txtEmail" runat="server" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                City:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtCity" runat="server" Width="199px"></asp:TextBox></td>
            <td align="left">
                State:</td>
            <td align="left">
                <asp:TextBox ID="txtState" runat="server" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Country:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtCountry" runat="server" Width="199px"></asp:TextBox></td>
            <td align="left" style="width: 196px">
                Audit Location:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtAuditLocation" runat="server" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Conformance Days:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtConformanceDay" runat="server" Width="199px"></asp:TextBox>&nbsp;</td>
            <td align="left" style="width: 196px">
                Surviliance Days:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtSurvilianceDay" runat="server" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" colspan="4" style="font-weight: bold; font-size: 12pt; color: darkblue">
                Shift Information</td>
        </tr>
        <tr>
            <td align="left" colspan="4">
                <asp:GridView ID="GridView1" runat="server" Width="318px" AutoGenerateColumns="False">
                <Columns>
                <asp:TemplateField HeaderText="Shift Time">
                <ItemTemplate>
                <asp:TextBox ID="txt1" Text='<%#Eval("SHIFTTIME") %>' runat="server">
                </asp:TextBox>
                </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField HeaderText="No Of Employee">
                <ItemTemplate>
                <asp:TextBox ID="txt2" Text='<%#Eval("TOTALEMP") %>' runat="server">
                </asp:TextBox>
                </ItemTemplate>
                </asp:TemplateField>
                </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt; height: 15px;">
                SIC Code:</td>
            <td align="left" style="width: 242px; height: 15px;">
                <asp:TextBox ID="txtSiCCode" runat="server" Width="200px"></asp:TextBox></td>
            <td align="left" style="height: 15px">
            </td>
            <td align="left" style="height: 15px">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                IAF Code:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtIAFCode" runat="server" Width="200px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Industry Type:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtIndustryType" runat="server" Width="200px"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="left" style="font-weight: bold; font-size: 12pt">
                Scope Of Registration:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtRegisScope" runat="server" Width="200px"></asp:TextBox></td>
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
                <asp:DropDownList ID="ddlCertType" runat="server" Width="207px">
                </asp:DropDownList></td>
            <td align="left" style="width: 242px">
                <asp:DropDownList ID="ddlFreqType" runat="server" Width="141px">
                </asp:DropDownList>Months</td>
            <td align="left">
                <asp:DropDownList ID="ddlAccerType" runat="server" Width="129px">
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
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtHearAbt" runat="server" TextMode="MultiLine"
                    Width="203px"></asp:TextBox></td>
            <td align="left">
                Consultant Engaged Earlier:<br />
                (With Whom)</td>
            <td align="left">
                <asp:TextBox ID="txtConsEng" runat="server" TextMode="MultiLine"
                    Width="193px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Completed By:</td>
            <td align="left" style="width: 242px">
                <asp:TextBox ID="txtCompletedBy" runat="server" Width="202px"></asp:TextBox></td>
            <td align="left">
                Designation:</td>
            <td align="left">
                <asp:TextBox ID="txtDesignation" runat="server" Width="193px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                Enquiry Date:</td>
            <td align="left" style="width: 242px">
                <cc1:GMDatePicker ID="GMDatePicker1" runat="server">
                </cc1:GMDatePicker>
                &nbsp;</td>
            <td align="left">
                Enquiry Type:</td>
            <td align="left">
                <asp:TextBox ID="txtEnqtype" runat="server" Width="193px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" colspan="4">
                <asp:Button ID="btnModify" runat="server" OnClick="btnModify_Click" Text="Modify" />&nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

