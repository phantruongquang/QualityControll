<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmCreateUser.aspx.cs" Inherits="Admin_Create_frmCreateUser" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" >
        <tr>
            <td align="center" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue">
                User Information</td>
        </tr>
        <tr>
            <td align="center">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    BackColor="#C0C0FF" EmptyDataText="No Data Found" ForeColor="Navy" PageSize="5"
                    Width="561px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting">
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblUserID" runat="server" Text='<%#Eval("USERID") %>' Visible="false">
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="User Type">
                            <ItemTemplate>
                                <asp:Label ID="lbl1" runat="server" Text='<%#Eval("RoleName") %>'>
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="User Name">
                            <ItemTemplate>
                                <asp:Label ID="lbl2" runat="server" Text='<%#Eval("USERNAME") %>'>
                              </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="Modify">
                            <ItemTemplate>
                                <asp:Button ID="btnModify" runat="server" CommandArgument='<%#Eval("USERID") %>' CommandName="Modify"
                                    Text="Modify" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" CommandName="Delete"
                                    Text="Delete?" TargetControlID="btnDelete" />
                            </ItemTemplate>
                           
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="center">
             <asp:Panel ID="Panel2" runat="server" Height="50px" Width="125px">
                    <div style="text-align: left">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 550px">
                            <tr>
                                <td colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue; height: 22px;">
                                    Update User Information</td>
                            </tr>
                            <tr>
                                <td style="width: 100px">
                                    User Name:</td>
                                <td style="width: 100px">
                                    <asp:TextBox ID="txtUser" runat="server" ReadOnly="True"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width: 100px; height: 19px;">
                                    Password:</td>
                                <td style="width: 100px; height: 19px;">
                                    <asp:TextBox ID="txtPwd" runat="server" Width="150px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" /><asp:Button ID="btnCancelUpdate" runat="server" OnClick="btnCancelUpdate_Click" Text="Cancel" /></td>
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
            <td align="center">
                <asp:Panel ID="Panel1" runat="server" Height="50px" Width="1px">
                    <div style="text-align: left">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 555px">
                            <tr>
                                <td align="left" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                                    background-color: darkblue">
                                    New User Information</td>
                            </tr>
                            <tr>
                                <td style="width: 100px">
                                    User Type:</td>
                                <td>
                                    <asp:DropDownList ID="ddlUser" runat="server" Width="119px">
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td style="width: 100px">
                                    User Name:</td>
                                <td>
                                    <asp:TextBox ID="txtUName" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width: 100px">
                                    Password:</td>
                                <td>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="150px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" /></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="343px"></asp:Label></td>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

