<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeptClassAdmin.aspx.cs" Inherits="StuFileManagement.DeptClassAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        院系班级号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        院系：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        班级：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
            <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="更新资料" onclick="Button2_Click" />
        <br />
        
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
    <a href="menu.html">返回menu界面</a>
</body>
</html>
