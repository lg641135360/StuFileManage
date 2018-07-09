<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuInfoInquiry.aspx.cs" Inherits="StuFileManagement.StuInfoShow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
    <div>
        学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
            <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" />
        <br />
        
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
    <a href="menu2.html">返回menu界面</a>
</body>
</html>
