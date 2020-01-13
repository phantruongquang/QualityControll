<%@ Page Language="C#" MasterPageFile="~/Auditors/AuditorMasterPage.master" AutoEventWireup="true" CodeFile="frmModifyAuditorDetails.aspx.cs" Inherits="Auditors_Modify_frmModifyAuditorDetails" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="left" border="1" cellpadding="0" cellspacing="0" style="width: 548px;
        color: darkblue; background-color: #ccccff">
        <tr>
            <td align="left" colspan="4" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Auditor Information</td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                Auditor Type:</td>
            <td align="left">
                <asp:DropDownList ID="ddlAuditorType" runat="server" Width="155px">
                </asp:DropDownList></td>
            <td align="left">
                Auditor Name:</td>
            <td align="left">
                <asp:TextBox ID="txtAuditorName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                Qualification:</td>
            <td align="left">
                <asp:TextBox ID="txtQualification" runat="server" Width="148px"></asp:TextBox></td>
            <td align="left">
                Experiance:</td>
            <td align="left">
                <asp:TextBox ID="txtExp" runat="server" Width="148px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    IRCA No: </span>
            </td>
            <td align="left">
                <asp:TextBox ID="txtIRCANo" runat="server"></asp:TextBox></td>
            <td align="left">
                LACourseDate:</td>
            <td align="left">
                <cc1:gmdatepicker id="GMDatePicker1" runat="server"></cc1:gmdatepicker>
            </td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                Lacert No:</td>
            <td align="left">
                <asp:TextBox ID="txtLacertNo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <strong><span style="font-size: 14pt">Address Detail</span></strong></td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Address1:</span></td>
            <td align="left">
                <asp:TextBox ID="txtAddr1" runat="server"></asp:TextBox></td>
            <td align="left">
                Address2:</td>
            <td align="left">
                <asp:TextBox ID="txtAddr2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                City:</td>
            <td align="left">
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            <td align="left">
                State:</td>
            <td align="left">
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                Country:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
            <td align="left" style="width: 196px">
                Phone:</td>
            <td align="left" style="width: 196px">
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                Mobile:</td>
            <td align="left">
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
            <td align="left">
                Fax:</td>
            <td align="left">
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="width: 123px">
                Email:</td>
            <td align="left">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            <td align="left">
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="4">
                <asp:Button ID="btnModify" runat="server" OnClick="btnModify_Click" Text="Modify"
                    Width="65px" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

