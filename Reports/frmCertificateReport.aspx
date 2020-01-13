<%@ Page Language="C#" MasterPageFile="~/Reports/ReportsMasterPage.master" AutoEventWireup="true" CodeFile="frmCertificateReport.aspx.cs" Inherits="Reports_frmCertificateReport" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Certificate Information</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue">
                Auditor Certificate Information</td>
        </tr>
        <tr>
            <td align="left">
                Company Name:</td>
            <td align="left" style="width: 156px">
                <asp:TextBox ID="txtCompName" runat="server" Width="187px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="height: 22px">
                Certificate No.:</td>
            <td align="left" style="width: 156px; height: 22px">
                <asp:TextBox ID="txtCertNo" runat="server" Width="187px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="height: 22px">
                File No.:</td>
            <td align="left" style="width: 156px; height: 22px">
                <asp:TextBox ID="txtFileNo" runat="server" Width="187px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="height: 22px">
                Company Status:</td>
            <td align="left" style="width: 156px; height: 22px">
                <asp:DropDownList ID="ddlStatus" runat="server" Width="140px">
                    <asp:ListItem>Withdrawn</asp:ListItem>
                    <asp:ListItem>Probation</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" /></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="#C0C0FF"
                        EmptyDataText="No Data Found" ForeColor="Navy" Height="100px" OnPageIndexChanging="GridView1_PageIndexChanging"
                        PageSize="5" Width="667px">
                        <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

