<%@ Page Language="C#" MasterPageFile="~/Reports/ReportsMasterPage.master" AutoEventWireup="true" CodeFile="frmCompanyInformationReport.aspx.cs" Inherits="Reports_frmCompanyInformationReport" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Company Reports</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff; background-color: darkblue">
                Auditor Information</td>
        </tr>
        <tr>
            <td align="left">
                Company Name:</td>
            <td align="left" style="width: 156px">
                <asp:TextBox ID="txtCompName" runat="server" Width="182px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left">
                SIC Code:</td>
            <td align="left" style="width: 156px">
                <asp:TextBox ID="txtSICCode" runat="server" Width="149px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="height: 22px">
                Rreport Type:</td>
            <td align="left" style="width: 156px; height: 22px">
                <asp:DropDownList ID="ddlReportype" runat="server" Width="156px">
                    <asp:ListItem>Enquiry</asp:ListItem>
                    <asp:ListItem>Quotation</asp:ListItem>
                    <asp:ListItem>Address Detail</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" /></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="#C0C0FF"
                        EmptyDataText="No Data Found" ForeColor="Navy" Height="100px" OnPageIndexChanging="GridView1_PageIndexChanging"
                        PageSize="5" Width="667px" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                        <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                        <Columns>
                         <asp:TemplateField>
                        <ItemTemplate>
                        <asp:Label ID="lblEnqNo" Text='<%#Eval("ENQUIRY_NO") %>' runat="server" Visible="false" />
                        </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Company Name">
                        <ItemTemplate>
                        <asp:Label ID="lbl1" Text='<%#Eval("COMPANYNAME") %>' runat="server"/>
                        </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Location">
                        <ItemTemplate>
                        <asp:Label ID="lbl2" Text='<%#Eval("AUDITLOCATION") %>' runat="server"  />
                        </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Reffered By"> 
                        <ItemTemplate>
                        <asp:Label ID="lbl3" Text='<%#Eval("CONTACTPERSON") %>' runat="server"  />
                        </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="File No">
                        <ItemTemplate>
                        <asp:Label ID="lbl4" Text='<%#("FILE_NO") %>' runat="server"  />
                        </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="SIC Code">
                        <ItemTemplate>
                        <asp:Label ID="lbl5" Text='<%#Eval("SICCODE") %>' runat="server" />
                        </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Surv Freq.">
                        <ItemTemplate>
                        <asp:Label ID="lbl6" Text='<%#Eval("AUDITFREQ_TYPE") %>' runat="server"  />
                        </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                        <ItemTemplate>
                        <asp:Button ID="btnEnqNo" CommandArgument='<%#Eval("ENQUIRY_NO") %>' CommandName="Details" Text="Details" runat="server" />
                        </ItemTemplate>
                        </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
                <asp:Panel ID="Panel2" runat="server" Height="50px" Width="125px">
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" BackColor="#C0C0FF"
                        EmptyDataText="No Data Found" ForeColor="Navy" Height="100px" OnPageIndexChanging="GridView2_PageIndexChanging"
                        PageSize="5" Width="667px" AutoGenerateColumns="False">
                        <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                        <Columns>
                          
                            <asp:TemplateField HeaderText="Quotation No.">
                                <ItemTemplate>
                                    <asp:Label ID="lbl1" Text='<%#Eval("QUOTATIONNO") %>' runat="server"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Quotation Date">
                                <ItemTemplate>
                                    <asp:Label ID="lbl2" Text='<%#Eval("QUOTATIONDT") %>' runat="server"  />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Enquiry No.">
                                <ItemTemplate>
                                    <asp:Label ID="lbl3" Text='<%#Eval("ENQUIRY_NO") %>' runat="server"  />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Company Name">
                                <ItemTemplate>
                                    <asp:Label ID="lbl4" Text='<%#Eval("COMPANYNAME") %>' runat="server"  />
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel3" runat="server" Height="50px" Width="125px">
                <asp:GridView ID="GridView3" runat="server" AllowPaging="True" BackColor="#C0C0FF"
                        EmptyDataText="No Data Found" ForeColor="Navy" Height="100px" OnPageIndexChanging="GridView3_PageIndexChanging"
                        PageSize="5" Width="667px" AutoGenerateColumns="False" OnRowCommand="GridView3_RowCommand">
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                    <Columns>
                        <asp:TemplateField HeaderText="Company Name">
                            <ItemTemplate>
                                <asp:Label ID="lbl1" Text='<%#Eval("COMPANYNAME") %>' runat="server"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Audit Location">
                            <ItemTemplate>
                                <asp:Label ID="lbl2" Text='<%#Eval("AUDITLOCATION") %>' runat="server"  />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="File No">
                            <ItemTemplate>
                                <asp:Label ID="lbl3" Text='<%#Eval("FILE_NO") %>' runat="server"  />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Enquiry Date">
                            <ItemTemplate>
                                <asp:Label ID="lbl4" Text='<%#Eval("ENQUIRYDT") %>' runat="server"  />
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Address">
                            <ItemTemplate>
                                <asp:Button ID="btnAddress" CommandArgument='<%#Eval("ENQUIRY_NO") %>' CommandName="Address" Text="Addresses" runat="server"  />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
    </table>
</asp:Content>

