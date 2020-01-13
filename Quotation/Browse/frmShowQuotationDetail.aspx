<%@ Page Language="C#" MasterPageFile="~/Quotation/QuotationMasterPage.master" AutoEventWireup="true" CodeFile="frmShowQuotationDetail.aspx.cs" Inherits="Quotation_Browse_frmShowQuotationDetail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue; width: 612px; height: 22px;">
                Quotation Search</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
             


               <asp:GridView ID="GridView1" runat="server" AllowPaging="True"
                  BackColor="#C0C0FF" EmptyDataText="No Data Found" ForeColor="Navy" OnPageIndexChanging="GridView1_PageIndexChanging"
                  OnRowCommand="GridView1_RowCommand" PageSize="5" Width="607px">
                  <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                  <Columns>
                      <asp:TemplateField>
                          <ItemTemplate>
                              <asp:Label ID="lbl" runat="server" Text='<%#Eval("QUOTATIONNO") %>' Visible="false">
                              </asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Details">
                          <ItemTemplate>
                              <asp:Button ID="btn" runat="server" CommandArgument='<%#Eval("QUOTATIONNO") %>' CommandName="Detail"
                                  Text="Detail" />
                          </ItemTemplate>
                      </asp:TemplateField>
                  </Columns>
              </asp:GridView>
               
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                    <div style="text-align: center">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 656px; background-color: #ccccff;">
                            <tr>
                                <td align="left" colspan="2" style="font-weight: bold; font-size: 14pt; width: 612px;
                                    color: #99ffff; height: 22px; background-color: darkblue">
                                    Quotation Information</td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 100px">
                                    Quotation No:</td>
                                <td align="left">
                                    <asp:Label ID="Label1" runat="server" Text="Label" Width="158px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 100px">
                                    Enquiry No:</td>
                                <td align="left">
                                    <asp:Label ID="Label2" runat="server" Text="Label" Width="158px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 100px; height: 19px">
                                    Quotation Date:</td>
                                <td align="left" style="height: 19px">
                                    <asp:Label ID="Label4" runat="server" Text="Label" Width="158px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 100px; height: 19px">
                                    Is Approved:</td>
                                <td align="left" style="height: 19px">
                                    <asp:Label ID="Label3" runat="server" Text="Label" Width="158px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 100px; height: 19px">
                                    Approved Date:</td>
                                <td align="left" style="height: 19px">
                                    <asp:Label ID="Label5" runat="server" Text="Label" Width="158px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="left" colspan="2" style="height: 19px">
                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="645px">
                                    <Columns>
                                    <asp:TemplateField HeaderText="Activity">
                                    <ItemTemplate>
                                    <asp:Label ID="lbl1" Text='<%#Eval("AUDIT_TYPE") %>' runat="server">
                                    </asp:Label>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="Chrges Rs.">
                                    <ItemTemplate>
                                    <asp:Label ID="lbl2" Text='<%#Eval("AUDITFEESRS") %>' runat="server">
                                    </asp:Label>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="Chrges $">
                                    <ItemTemplate>
                                    <asp:Label ID="lbl3" Text='<%#Eval("AUDITFEESDLR") %>' runat="server">
                                    </asp:Label>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

