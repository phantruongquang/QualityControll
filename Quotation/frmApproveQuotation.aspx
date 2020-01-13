<%@ Page Language="C#" MasterPageFile="~/Quotation/QuotationMasterPage.master" AutoEventWireup="true" CodeFile="frmApproveQuotation.aspx.cs" Inherits="Quotation_frmApproveQuotation" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table align="left" border="1" cellpadding="0" cellspacing="0">
            <tr>
                <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                    background-color: darkblue">
                    Quotation Approve</td>
            </tr>
            <tr>
                <td align="left" style="width: 153px">
                    Qutation No.:</td>
                <td align="left">
                    <asp:TextBox ID="txtEnqno" runat="server" Width="157px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                    height: 24px; background-color: darkblue">
                    </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                        <div style="text-align: center">
                            <table border="0" cellpadding="0" cellspacing="0" style="width: 353px">
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:GridView ID="GridView1" runat="server" BackColor="#C0C0FF" EmptyDataText="No Data Found"
                                            ForeColor="Navy" Width="611px" OnRowCommand="GridView1_RowCommand">
                                            <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:Button ID="btn" runat="server" CommandArgument='<%#Eval("QUOTATIONNO") %>' CommandName="Approve"
                                                            Text="Approve" Visible="false"/>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                      </td>
                                </tr>
                            </table>
                        </div>
                    </asp:Panel>
                    &nbsp;
                    <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>

