<%@ Page Language="C#" MasterPageFile="~/Reports/ReportsMasterPage.master" AutoEventWireup="true" CodeFile="frmAuditorReport.aspx.cs" Inherits="Reports_frmAuditorReprt" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 560px">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #99ffff;
                background-color: darkblue">
                Auditor Information</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="left">
                Auditor Type:</td>
            <td align="left" style="width: 156px">
                <asp:DropDownList ID="ddlAuditorType" runat="server" Width="147px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left" style="height: 22px">
                Auditor Name.:</td>
            <td align="left" style="width: 156px; height: 22px">
                <asp:TextBox ID="txtAuditorName" runat="server" Width="187px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="height: 22px">
                Report Type:</td>
            <td align="left" style="width: 156px; height: 22px">
                <asp:DropDownList ID="ddlStatus" runat="server" Width="145px">
                    <asp:ListItem>Personal Detail</asp:ListItem>
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
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        BackColor="#C0C0FF" EmptyDataText="No Data Found" ForeColor="Navy" PageSize="5"
                        Width="655px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
                        <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                           <asp:Label ID="lblAUDITORID" runat="server" Text='<%#Eval("AUDITORID") %>' Visible="false">
                              </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Auditor Type">
                                <ItemTemplate>
                                    <asp:Label ID="lbl1" runat="server" Text='<%#Eval("AUDITOR_TYPE") %>'>
                              </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Auditor Name">
                                <ItemTemplate>
                                    <asp:Label ID="lbl2" runat="server" Text='<%#Eval("AUDITORNAME") %>'>
                              </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SICCODE">
                                <ItemTemplate>
                                    <asp:Label ID="lbl3SICCODE" runat="server" Width="100px">
                              </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             
                             <asp:TemplateField HeaderText="IRCA No.">
                                <ItemTemplate>
                                    <asp:Label ID="lbl3" runat="server" Text='<%#Eval("ICRAREGDTLS") %>'>
                              </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                             <asp:TemplateField HeaderText="CITY">
                                <ItemTemplate>
                                    <asp:Label ID="lbl4" runat="server" Text='<%#Eval("CITY") %>'>
                              </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             
                             <asp:TemplateField HeaderText="EMAIL">
                                <ItemTemplate>
                                    <asp:Label ID="lbl5" runat="server" Text='<%#Eval("EMAIL") %>'>
                              </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                        </Columns>
                    </asp:GridView>
                    </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel2" runat="server" Height="50px" Width="125px">
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True"
                        BackColor="#C0C0FF" EmptyDataText="No Data Found" ForeColor="Navy" PageSize="5"
                        Width="655px">
                        <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="Navy" />
                  </asp:GridView>
                    &nbsp;</asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

