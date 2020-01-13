<%@ Page Language="C#" MasterPageFile="~/Enquiry/EnquiryMasterPage.master" AutoEventWireup="true" CodeFile="frmEnqiryDetail.aspx.cs" Inherits="Enquiry_Browse_frmEnqiryDetail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
                    <div style="text-align: center">
            <table border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="#C0C0FF"
            EmptyDataText="No Data Found" ForeColor="Navy" OnPageIndexChanging="GridView1_PageIndexChanging"
            OnRowCommand="GridView1_RowCommand" PageSize="5" Width="607px">
            <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lbl" runat="server" Text='<%#Eval("ENQUIRY_NO") %>' Visible="false">
                              </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Details">
                    <ItemTemplate>
                        <asp:Button ID="btn" runat="server" CommandArgument='<%#Eval("ENQUIRY_NO") %>' CommandName="Details"
                            Text="Details" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
                        <strong>Click On Detail Button For More Info</strong>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

