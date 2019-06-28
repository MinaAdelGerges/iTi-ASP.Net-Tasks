<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="day2.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cp_main" runat="server">
    <table style="width: 106%; margin-right: 28px;">
    <tr>
        <td colspan="2" style="font-size: 20px; text-decoration: underline; font-family: Arial, Helvetica, sans-serif; font-weight: bold; padding-left: 50%">Profile:-</td>
    </tr>
    <tr>
        <td style="width: 280px; height: 21px;">Name:</td>
        <td style="height: 21px">
            <asp:Label ID="lbl_name" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 280px">Age:</td>
        <td>
            <asp:Label ID="lbl_age" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="height: 21px; width: 280px">Email</td>
        <td style="height: 21px">
            <asp:Label ID="lbl_email" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 280px">Gender:</td>
        <td>
            <asp:Label ID="lbl_gender" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 280px; height: 21px;"></td>
        <td style="height: 21px">
            Onlines:<asp:Label ID="lbl_online" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 280px">&nbsp;</td>
        <td>
            <asp:LinkButton ID="btn_logout" runat="server" OnClick="btn_logout_Click">logout</asp:LinkButton>
        </td>
    </tr>
</table>
</asp:Content>
