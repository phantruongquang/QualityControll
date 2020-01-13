<%@ Page Language="C#" MasterPageFile="~/Quotation/QuotationMasterPage.master" AutoEventWireup="true" CodeFile="frmCreateQuotation.aspx.cs" Inherits="Quotation_Create_frmCreateQuotation" Title="Untitled Page" %>

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
                <asp:TextBox ID="txtQuotNo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="width: 153px">
                Enquiry No.:</td>
            <td align="left">
                <asp:DropDownList ID="ddlEnqNo" runat="server" Width="127px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left" style="width: 153px">
                Quotation Date:</td>
            <td align="left">
                <cc1:GMDatePicker ID="GMDatePicker1" runat="server">
                </cc1:GMDatePicker>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" style="width: 153px">
                Is Approved:</td>
            <td align="left">
                <asp:RadioButton ID="radYes" runat="server" GroupName="g" Text="Yes" />
                <asp:RadioButton ID="radNo" runat="server" GroupName="g" Text="No" /></td>
        </tr>
        <tr>
            <td align="left">
                Approved Date:</td>
            <td align="left">
                <cc1:GMDatePicker ID="GMDatePicker2" runat="server">
                </cc1:GMDatePicker>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                <asp:Button ID="btnQuotation" runat="server" OnClick="btnQuotation_Click" Text="Quotation Fee" Width="95px" /></td>
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
                                <td align="left" style="width: 100px; height: 22px">
                                    Audit &nbsp;Type Id:</td>
                                <td align="left" style="width: 100px; height: 22px">
                <asp:DropDownList ID="ddlAudit" runat="server" Width="154px">
                </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 100px">
                Audit Fees Rs.:</td>
                                <td align="left" style="width: 100px">
                <asp:TextBox ID="txtAuditFeeRs" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 100px">
                Audit Fees $:</td>
                                <td align="left" style="width: 100px">
                <asp:TextBox ID="txtFeeDolor" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Submit" />
                                    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" /></td>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" Width="326px"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

