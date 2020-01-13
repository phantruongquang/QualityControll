<%@ Page Language="C#" MasterPageFile="~/Quotation/QuotationMasterPage.master" AutoEventWireup="true" CodeFile="frmQuotationDetail.aspx.cs" Inherits="Quotation_Modify_frmQuotationDetail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue">
                    Quotation Search</td>
            </tr>
            <tr>
                <td align="left" style="width: 92px">
                    Quotation No.:</td>
                <td align="left" style="width: 156px">
                    <asp:TextBox ID="txtQuotationNo" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="left" style="width: 92px">
                </td>
                <td align="left" style="width: 156px">
                </td>
            </tr>
            <tr>
                <td align="right" colspan="2">
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" /></td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" BackColor="#C0C0FF" EmptyDataText="No Data Found"
                        ForeColor="Navy" Width="611px" OnRowCommand="GridView1_RowCommand">
                        <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                        <Columns>
                        <asp:TemplateField HeaderText="Modify">
                        <ItemTemplate>
                        <asp:Button ID="btn" CommandName="Modify" CommandArgument='<%#Eval("QUOTATIONNO") %>' Text="Modify" runat="server" />
                        </ItemTemplate>
                        </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

