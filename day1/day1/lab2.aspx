<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lab2.aspx.cs" Inherits="day1.lab2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body style="height: 324px; width: 1389px">
    <form id="form1" runat="server">
    <div style="margin-right: 20px; height: 82px; width: 1388px;">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Currency Converter<br />
        <br />
        <br />
        <br />
        <div style="width: 504px; height: 228px; display: inline; float: left; margin-left: 42px; background-color: #FF9933;">
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp; EGP Value&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_value" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp; Convert To&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddl_currency" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_currency_SelectedIndexChanged">
                <asp:ListItem>Currency</asp:ListItem>
                <asp:ListItem>Euro</asp:ListItem>
                <asp:ListItem>Dollar</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
        </div>
    
    </div>
        <div style="width: 564px; float: right; display: inline; height: 234px; margin-left: 40px; margin-right: 67px; background-color: #FF9933;">
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
