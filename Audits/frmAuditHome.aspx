<%@ Page Language="C#" MasterPageFile="~/Audits/AuditMasterPage.master" AutoEventWireup="true" CodeFile="frmAuditHome.aspx.cs" Inherits="Audits_Browse_frmRegistration" Title="Untitled Page" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 603px">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; width: 612px;
                color: #99ffff; height: 22px; background-color: darkblue">
                Registration Search</td>
        </tr>
        <tr>
            <td align="left" style="width: 92px">
                                    Enquiry No.:</td>
            <td align="left" style="width: 156px">
                <asp:TextBox ID="txtEnqNo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <strong>AND</strong></td>
        </tr>
        <tr>
            <td align="left" style="width: 92px">
                Quotation No:</td>
            <td align="left" style="width: 156px">
                <asp:TextBox ID="txtQuotationNo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" /></td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="height: 177px">
                <asp:GridView ID="GridView1" runat="server" BackColor="#C0C0FF" EmptyDataText="No Data Found"
                    ForeColor="Navy" OnRowCommand="GridView1_RowCommand" Width="611px" AutoGenerateColumns="False">
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                    <Columns>
                    <asp:TemplateField HeaderText="FILE NO">
                    <ItemTemplate>
                    <asp:Label ID="lbl1" Text='<%#Eval("FILE_NO") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="QUOTATION NO">
                    <ItemTemplate>
                    <asp:Label ID="lbl2" Text='<%#Eval("QUOTATIONNO") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="COMPANY NAME">
                    <ItemTemplate>
                    <asp:Label ID="lbl3" Text='<%#Eval("COMPANYNAME") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="CERTIFICATE NO">
                    <ItemTemplate>
                    <asp:Label ID="lbl4" Text='<%#Eval("CERTIFICATE_NO") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField HeaderText="File Info">
                            <ItemTemplate>
                                <asp:Button ID="btn" runat="server" CommandArgument='<%#Eval("FILE_NO") %>' CommandName="FileInfo"
                                    Text="File Info" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
               </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                </td>
        </tr>
        <tr>
            <td align="center" colspan="2" >
                <asp:Panel ID="Panel1" runat="server" Height="50px" Width="180px">
                    <div style="text-align: left">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 676px">
                            <tr>
                                <td colspan="3" style="font-weight: bold; font-size: 14pt; width: 612px; color: #99ffff;
                                    height: 22px; background-color: darkblue">
                                    File Information</td>
                                <td colspan="1" style="font-weight: bold; font-size: 14pt; width: 612px; color: #99ffff;
                                    height: 22px; background-color: darkblue">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 1482px">
                                    File No.:</td>
                                <td align="left">
                                    <asp:TextBox ID="txtFileNo" runat="server" Enabled="False"></asp:TextBox></td>
                                <td style="width: 1098px"  >
                                    File Date:</td>
                                <td >
                                    <cc1:GMDatePicker ID="GMDatePicker1" runat="server" Enabled="False">
                                    </cc1:GMDatePicker>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 1482px">
                                    Quotation No.:</td>
                                <td align="left">
                                    <asp:TextBox ID="txtQuotNo" runat="server" Enabled="False"></asp:TextBox></td>
                                <td style="width: 1098px">
                                    App. Charges Paid:</td>
                                <td>
                                    <asp:CheckBox ID="chkCharges" runat="server" Enabled="False" /></td>
                            </tr>
                            <tr>
                                <td style="width: 1482px">
                                    File Storage:</td>
                                <td>
                                    <asp:TextBox ID="txtStorage" runat="server" Enabled="False"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="center" colspan="4" style="height: 24px">
                                    <span style="font-size: 16pt"><strong>Certificate Information</strong></span></td>
                            </tr>
                            <tr>
                                <td align="left" colspan="1" style="width: 1482px">
                                    Certificate No.:</td>
                                <td align="left" colspan="1">
                                    <asp:TextBox ID="txtCertificateNo" runat="server" Enabled="False"></asp:TextBox></td>
                                <td align="left" colspan="1" style="width: 1098px">
                                    Certificate Date:</td>
                                <td align="left" colspan="4">
                                    <cc1:GMDatePicker ID="GMDatePicker2" runat="server" Enabled="False">
                                    </cc1:GMDatePicker>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" colspan="1" style="width: 1482px">
                                    Certificate Validity:</td>
                                <td align="left" colspan="1">
                                    <cc1:GMDatePicker ID="GMDatePicker3" runat="server" Enabled="False">
                                    </cc1:GMDatePicker>
                                </td>
                                <td align="left" colspan="1" style="width: 1098px">
                                    Is Withdrawn:</td>
                                <td align="left" colspan="4">
                                    <asp:CheckBox ID="chkWiddrawn" runat="server" Enabled="False" Width="1px" /></td>
                            </tr>
                            <tr>
                                <td align="left" colspan="1" style="width: 1482px">
                                    Is Probation:</td>
                                <td align="left" colspan="1">
                                    <asp:CheckBox ID="chkProbation" runat="server" Enabled="False" Width="1px" /></td>
                                <td align="left" colspan="1" style="width: 1098px">
                                </td>
                                <td align="left" colspan="4">
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="7">
                                    <asp:Button ID="btnAuditInfo" runat="server" OnClick="btnAuditInfo_Click" Text="Audit Info" /></td>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

