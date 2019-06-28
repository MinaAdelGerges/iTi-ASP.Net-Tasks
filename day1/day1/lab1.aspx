<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lab1.aspx.cs" Inherits="day1.lab1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            height: 25px;
            width: 270px;
        }
        .auto-style5 {
            width: 270px;
            height: 60px;
        }
        .auto-style6 {
            height: 60px;
        }
        .auto-style7 {
            width: 270px;
            height: 40px;
        }
        .auto-style8 {
            height: 40px;
        }
        .auto-style9 {
            height: 25px;
            width: 196px;
        }
        .auto-style10 {
            height: 40px;
            width: 196px;
        }
        .auto-style11 {
            height: 60px;
            width: 196px;
        }
        .auto-style12 {
            height: 25px;
            width: 141px;
        }
        .auto-style13 {
            height: 40px;
            width: 141px;
        }
        .auto-style14 {
            height: 60px;
            width: 141px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Name</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">Birth Date</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="ddl_year" runat="server" Height="16px" OnSelectedIndexChanged="ddl_year_SelectedIndexChanged" Width="85px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddl_month" runat="server" style="margin-left: 0px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style8">
                    <asp:DropDownList ID="ddl_day" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style11">
                    <asp:Button ID="btn_send1" runat="server" OnClick="btn_send1_Click" Text="QueryString" Width="117px" />
                </td>
                <td class="auto-style14">
                    <asp:Button ID="btn_send2" runat="server" PostBackUrl="~/labb1.aspx" Text="PostBackURL" Width="119px" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btn_send3" runat="server" Text="Session" Width="123px" OnClick="btn_send3_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
