<%@ Page Language="C#" MasterPageFile="~/Auditors/AuditorMasterPage.master" AutoEventWireup="true" CodeFile="frmSearchAuditorsForModification.aspx.cs" Inherits="Auditors_Modify_frmSearchAuditorsForModification" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue">
                Auditor Search</td>
        </tr>
        <tr>
            <td align="left" style="width: 92px">
                Auditor Type.:</td>
            <td align="left" style="width: 156px">
                <asp:DropDownList ID="ddlAuditorType" runat="server" Width="172px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" /></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:GridView ID="GridView1" runat="server" BackColor="#C0C0FF" EmptyDataText="No Data Found"
                    ForeColor="Navy"  Width="611px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False">
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                    <Columns>
                    <asp:TemplateField HeaderText="Modify">
                            <ItemTemplate>
                                <asp:Button ID="btn" runat="server" CommandArgument='<%#Eval("AUDITORID") %>' CommandName="Modify"
                                    Text="Modify" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                    <asp:TemplateField HeaderText="Auditor Type">
                    <ItemTemplate>
                    <asp:Label ID="lblType" Text='<%#Eval("AUDITOR_TYPE") %>' runat="server">
                    </asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="Auditor Type">
                    <ItemTemplate>
                    <asp:Label ID="lblName" Text='<%#Eval("AUDITORNAME") %>' runat="server">
                    </asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                        
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

