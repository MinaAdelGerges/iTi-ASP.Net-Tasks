<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="day2.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cp_main" runat="server">
    <table style="width: 106%; margin-right: 28px;">
    <tr>
        <td style="font-size: 20px; text-decoration: underline; font-family: Arial, Helvetica, sans-serif; font-weight: bold; padding-left: 50%">Profile:-&nbsp; </td>
    </tr>
    <tr>
        <td style="font-size: 20px; text-decoration: underline; font-family: Arial, Helvetica, sans-serif; font-weight: bold; padding-left: 50%">
            <asp:LinkButton ID="btn_logout" runat="server" OnClick="btn_logout_Click">logout</asp:LinkButton>
        &nbsp;<br />
            <asp:LinkButton ID="btn_edit" runat="server" OnClick="btn_edit_Click">Edit Profile</asp:LinkButton>
            <br />
            <asp:LinkButton ID="btn_change" runat="server" OnClick="btn_change_Click">Change Password</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td style="margin-left: 40px;">
            <asp:GridView ID="gv_profile" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
