<%@ Page Language="C#" MasterPageFile="~/Enquiry/EnquiryMasterPage.master" AutoEventWireup="true" CodeFile="frmSearchEnquiryCompnay.aspx.cs" Inherits="Enquiry_Modify_frmSearchEnquiryCompnay" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table id="TABLE1" border="0" cellpadding="0" cellspacing="0" onclick="return TABLE1_onclick()">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Enquiry Search</td>
        </tr>
        <tr>
            <td align="left" style="width: 92px">
                Enquiry No.:</td>
            <td align="left" style="width: 156px">
                <asp:TextBox ID="txtEnqNo" runat="server"></asp:TextBox></td>
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
                                <asp:Button ID="btn" runat="server" CommandArgument='<%#Eval("Enquiry_NO") %>' CommandName="Modify"
                                    Text="Modify" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

