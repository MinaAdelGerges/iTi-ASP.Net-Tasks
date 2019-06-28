<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="day2.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cp_main" runat="server">
    <table style="width: 100%">
    <tr>
        <td>userName</td>
        <td>
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_name" Display="Dynamic" ErrorMessage="Must enter your userName">Must enter your userName</asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>password</td>
        <td>
            <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_password" ErrorMessage="Password is Required!">Enter Your Password!</asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:CheckBox ID="chb_remeberme" runat="server" Text="Rember me" />
        </td>
        <td>
            <asp:Label ID="lbl_count" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lbl_failed" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="Red"></asp:Label>
        </td>
        <td>
            <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="login" />
        </td>
    </tr>
</table>
</asp:Content>
