<%@ Page Language="C#" MasterPageFile="~/Reports/ReportsMasterPage.master" AutoEventWireup="true" CodeFile="frmEnquiryReportByDate.aspx.cs" Inherits="Reports_frmEnquiryReportByDate" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 560px">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Enquiry Information</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue">
                Auditor&nbsp; Information</td>
        </tr>
        <tr>
            <td align="left">
                Start Date:</td>
            <td align="left" style="width: 156px">
                <cc1:gmdatepicker id="GMDatePicker1" runat="server"></cc1:gmdatepicker>
            </td>
        </tr>
        <tr>
            <td align="left" style="height: 22px">
                End Date:</td>
            <td align="left" style="width: 156px; height: 22px">
                <cc1:gmdatepicker id="GMDatePicker2" runat="server"></cc1:gmdatepicker>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" /></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" BackColor="#C0C0FF"
                        EmptyDataText="No Data Found" ForeColor="Navy" OnPageIndexChanging="GridView2_PageIndexChanging"
                        PageSize="5" Width="655px">
                        <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                    </asp:GridView>
                    &nbsp;</asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

