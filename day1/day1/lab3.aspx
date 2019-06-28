<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lab3.aspx.cs" Inherits="day1.lab3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form2 {
            width: 420px;
            height: 1px;
        }
    </style>
</head>
<body style="height: 668px">
    <form id="form1" runat="server">
    <div style="height: 636px; width: 438px; display: inline-block; float: left; background-color: #FFFFCC;">
    
        Choose a background image:<br />
        <asp:DropDownList ID="ddl_back" runat="server" Height="16px" Width="214px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Background Color</asp:ListItem>
            <asp:ListItem>flowers</asp:ListItem>
            <asp:ListItem>lines</asp:ListItem>
            <asp:ListItem>mix</asp:ListItem>
            <asp:ListItem>square</asp:ListItem>
            <asp:ListItem>stars</asp:ListItem>
            <asp:ListItem>special</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        Choose a font color:<br />
        <asp:DropDownList ID="ddl_clr" runat="server" Height="21px" Width="216px">
            <asp:ListItem>Font Color</asp:ListItem>
            <asp:ListItem>Purple</asp:ListItem>
            <asp:ListItem>red</asp:ListItem>
            <asp:ListItem>blue</asp:ListItem>
            <asp:ListItem>yellow</asp:ListItem>
            <asp:ListItem>green</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <hr style="margin-bottom: 3px" />
        Choose a greeting Type:<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click" Width="163px">
            <asp:ListItem Value="birth">Birthday</asp:ListItem>
            <asp:ListItem Value="well">Get Well Soon</asp:ListItem>
            <asp:ListItem Value="valentine">Valentine</asp:ListItem>
            <asp:ListItem Value="congrats">Congrats</asp:ListItem>
        </asp:BulletedList>
        <asp:CheckBox ID="cb_picture" runat="server" Text="Add the picture" />
        <br />
        <br />
        Enter the greeting Message below:<br />
        <asp:ListBox ID="lb_greeting" runat="server" Width="255px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="26px" Text="Preview" Width="253px" />
    
    </div>
  
    <div style="display: inline-block; float: left;height:631px; width: 687px; margin-left: 10px;" id="div2">
        <h1 id="head1">
            
        </h1>
        <br />
        <br />
        <h2 id="head2">

        </h2>
       </div>
    
        </form>
</body>
</html>
