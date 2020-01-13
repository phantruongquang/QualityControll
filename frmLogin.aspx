<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px" BorderColor="White" BorderStyle="Solid">
    <table border="0" cellpadding="0" cellspacing="0"  align="center" style="width: 379px; background-color: darkblue">
        <tr>
            <td style="font-weight: bold; font-size: 14pt; color: darkblue; height: 22px; background-color: #ccffff;" align="center" colspan="2">
                Login</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <span style="color: #ffffff">Please Enter *Value</span></td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: #66ffff; height: 43px;" align="left">
                User Name<span style="color: #ffffff">*</span>:</td>
            <td>
                <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUname"
                    ErrorMessage="*" Font-Bold="True" ForeColor="White"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: #66ffff;" align="left">
                Password<span style="color: #ffffff">*</span>:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                    ErrorMessage="*" Font-Bold="True" ForeColor="White"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                &nbsp;<asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="AliceBlue"
                    Width="163px"></asp:Label></td>
        </tr>
    </table>
    </asp:Panel>
</asp:Content>

