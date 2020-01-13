<%@ Page Language="C#" MasterPageFile="~/Auditors/AuditorMasterPage.master" AutoEventWireup="true" CodeFile="frmSearchForAuditInfo.aspx.cs" Inherits="Auditors_Browse_frmSearchForAuditInfo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td align="center">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 432px" >
        <tr>
            <td align="center">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="#C0C0FF"
                    EmptyDataText="No Data Found" ForeColor="Navy" OnPageIndexChanging="GridView1_PageIndexChanging"
                    OnRowCommand="GridView1_RowCommand" PageSize="5" Width="561px" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound">
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblAUDITORID" runat="server" Text='<%#Eval("AUDITORID") %>' Visible="false">
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Auditor Type">
                            <ItemTemplate>
                                <asp:Label ID="lbl1" runat="server" Text='<%#Eval("AUDITOR_TYPE") %>'>
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Auditor Name">
                            <ItemTemplate>
                                <asp:Label ID="lbl2" runat="server" Text='<%#Eval("AUDITORNAME") %>' >
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="SICCODE">
                            <ItemTemplate>
                                <asp:Label ID="lbl3SICCODE" runat="server" Width="100px">
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Details">
                            <ItemTemplate>
                                <asp:Button ID="btn" runat="server" CommandArgument='<%#Eval("AUDITORID") %>' CommandName="Details"
                                    Text="Details" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <strong>Click On Detail Button For More Info</strong></td>
        </tr>
        <tr>
            <td align="center" style="height: 19px">
            </td>
        </tr>
    </table>
    </td>
    </tr></table>
</asp:Content>

