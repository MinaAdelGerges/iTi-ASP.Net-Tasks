<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="labb1.aspx.cs" Inherits="day1.labb1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 398px;
        }
        .auto-style3 {
            width: 398px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Hello</td>
                <td class="auto-style4">
                    <asp:Label ID="lb1" runat="server"></asp:Label>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">Year age is</td>
                <td>
                    <asp:Label ID="lb2" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
