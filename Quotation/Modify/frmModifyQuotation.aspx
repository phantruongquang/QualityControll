<%@ Page Language="C#" MasterPageFile="~/Quotation/QuotationMasterPage.master" AutoEventWireup="true" CodeFile="frmModifyQuotation.aspx.cs" Inherits="Quotation_Modify_frmModifyQuotation" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="left" border="1" cellpadding="0" cellspacing="0">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Quotation Information</td>
        </tr>
        <tr>
            <td align="left" style="width: 153px">
                Quotation No.:</td>
            <td align="left">
                <asp:Label ID="lblQuotNo" runat="server" Width="140px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" style="width: 153px">
                Enquiry No.:</td>
            <td align="left">
                <asp:Label ID="lblEnqno" runat="server" Width="140px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" style="width: 153px">
                Quotation Date:</td>
            <td align="left">
                <cc1:GMDatePicker ID="GMDatePicker1" runat="server">
                </cc1:GMDatePicker>
                &nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td align="left" style="width: 153px">
                Is Approved:</td>
            <td align="left">
                <asp:Label ID="lblIsApproved" runat="server" Width="140px"></asp:Label>&nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                Approved Date:</td>
            <td align="left">
                <cc1:GMDatePicker ID="GMDatePicker2" runat="server">
                </cc1:GMDatePicker>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                </td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                height: 24px; background-color: darkblue">
                Quotation Fess Detail</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                    <div style="text-align: center">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 353px">
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:GridView ID="GridView1" runat="server" Width="565px" AutoGenerateColumns="False" BackColor="#C0C0FF" ForeColor="Navy" Height="124px">
                                    <Columns>
                                     <asp:TemplateField>
                                    <ItemTemplate>
                                    <asp:Label ID="lbl1" Text='<%#Eval("Audit_Type_Id") %>' runat="server" Visible="false" />
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField   HeaderText="AUDIT TYPE">
                                    <ItemTemplate>
                                    <asp:Label ID="lbl" Text='<%#Eval("AUDIT_TYPE") %>' runat="server" ></asp:Label>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField  HeaderText="AUDIT FEE RS" >
                                    <ItemTemplate>
                                    <asp:TextBox ID="txt1" Text='<%#Eval("AUDITFEESRS") %>' runat="server" ForeColor="BlueViolet"></asp:TextBox>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField HeaderText="AUDIT FEE $">
                                    <ItemTemplate>
                                    <asp:TextBox ID="txt2" Text='<%#Eval("AUDITFEESDLR") %>' runat="server" ForeColor="BlueViolet"></asp:TextBox>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                                    </td>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
                &nbsp;
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

