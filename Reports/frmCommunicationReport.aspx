<%@ Page Language="C#" MasterPageFile="~/Reports/ReportsMasterPage.master" AutoEventWireup="true" CodeFile="frmCommunicationReport.aspx.cs" Inherits="Reports_frmCommunicationReport" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Communication Information</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue">
                Auditor Communication Information</td>
        </tr>
        <tr>
            <td align="left">
                Company Name:</td>
            <td align="left" style="width: 156px">
                <asp:TextBox ID="txtCompName" runat="server" Width="222px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="height: 22px;">
                Communication Type:</td>
            <td align="left" style="width: 156px; height: 22px;">
                <asp:DropDownList ID="ddlCommType" runat="server" Width="155px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Button ID="btnSearch" runat="server"  Text="Search" OnClick="btnSearch_Click" />
                <asp:Button ID="btnCancel" runat="server"  Text="Cancel" OnClick="btnCancel_Click" /></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
               <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                <asp:GridView ID="GridView1" runat="server" BackColor="#C0C0FF" EmptyDataText="No Data Found"
                    ForeColor="Navy" Width="667px" Height="100px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                      </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

