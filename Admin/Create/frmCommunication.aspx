<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmCommunication.aspx.cs" Inherits="Admin_Create_frmCommunication" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td align="center" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue">
                Communication Type Information</td>
        </tr>
        <tr>
            <td align="center">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    BackColor="#C0C0FF" EmptyDataText="No Data Found" ForeColor="Navy" OnPageIndexChanging="GridView1_PageIndexChanging"
                    OnRowCommand="GridView1_RowCommand" PageSize="5" Width="561px">
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblCommId" runat="server" Text='<%#Eval("commtypeid") %>' Visible="false">
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Communication Type">
                            <ItemTemplate>
                                <asp:Label ID="lbl1" runat="server" Text='<%#Eval("commtype") %>'>
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Communication Description">
                            <ItemTemplate>
                                <asp:Label ID="lbl2" runat="server" Text='<%#Eval("commdesc") %>'>
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Modify">
                            <ItemTemplate>
                                <asp:Button ID="btnModify" runat="server" CommandArgument='<%#Eval("commtypeid") %>'
                                    CommandName="Modify" Text="Modify" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <%-- <asp:TemplateField HeaderText="Delete">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" CommandName="Delete" TargetControlID="btnDelete"
                                        Text="Delete?" />
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Panel ID="Panel2" runat="server" Height="50px" Width="125px">
                    <div style="text-align: left">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 564px">
                            <tr>
                                <td colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff; height: 22px;
                                    background-color: darkblue">
                                    Update Communication Type</td>
                            </tr>
                            <tr>
                                <td>
                                    Communication Type:</td>
                                <td style="width: 100px">
                                    <asp:TextBox ID="txtCommType" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    Description:</td>
                                <td style="width: 100px; height: 19px">
                                    <asp:TextBox ID="txtDesc" runat="server" Width="150px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" /><asp:Button
                                        ID="btnCancelUpdate" runat="server" OnClick="btnCancelUpdate_Click" Text="Cancel" /></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Label ID="lblUpdate" runat="server" Font-Bold="True" Font-Size="14pt" Width="343px"></asp:Label></td>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="btnNewEntry" runat="server" OnClick="btnNewEntry_Click" Text="New Entry" /></td>
        </tr>
        <tr>
            <td align="center" style="height: 154px">
                <asp:Panel ID="Panel1" runat="server" Height="50px" Width="1px">
                    <div style="text-align: left">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 555px">
                            <tr>
                                <td align="left" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                                    background-color: darkblue">
                                    New Communication Type</td>
                            </tr>
                            <tr>
                                <td>
                                    Communication Type:</td>
                                <td>
                                    <asp:TextBox ID="txtCommunicationType" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    Description:</td>
                                <td>
                                    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />&nbsp;
                                    <asp:Button ID="btnNew" runat="server" OnClick="btnNew_Click" Text="New" />
                                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" /></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="318px"></asp:Label></td>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

