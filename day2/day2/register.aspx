<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="day2.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cp_main" runat="server">
    <table style="width: 100%; height: 10px; margin-bottom: 500px; padding-bottom: 50px;">
    <tr>
        <td>Name</td>
        <td>
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_name" ErrorMessage="please enter your name" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>age</td>
        <td>
            <asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txt_age" Display="Dynamic" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="60" MinimumValue="20">age must between 20 and 60</asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_age" Display="Dynamic" ErrorMessage="please enter your age" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>password</td>
        <td>
            <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_pass" Display="Dynamic" ErrorMessage="Enter Your Password!">Password is Required!</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>confirm-password</td>
        <td>
            <asp:TextBox ID="txt_confirm" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_pass" ControlToValidate="txt_confirm" ErrorMessage="CompareValidator" ForeColor="Red">pass not confirm</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_confirm" Display="Dynamic" Enabled="False" ErrorMessage="Confirm Your Password!">confirm password!</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>E-mail</td>
        <td>
            <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_email" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">invalid email</asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_email" Display="Dynamic" ErrorMessage="Your Email is Required">Enter your Email!</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>gender</td>
        <td>
            <asp:RadioButtonList ID="rbl_gender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>male</asp:ListItem>
                <asp:ListItem>female</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="rbl_gender" Display="Dynamic" ErrorMessage="Gender is Reqiured!">Choose Your Gender!</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btn_register" runat="server" OnClick="btn_register_Click" Text="register" style="height: 29px" />
        </td>
        <td>
            <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="login" ValidationGroup="lo" />
        </td>
    </tr>
</table>
</asp:Content>

