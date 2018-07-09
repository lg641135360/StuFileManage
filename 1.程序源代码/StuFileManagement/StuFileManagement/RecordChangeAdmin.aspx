<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecordChangeAdmin.aspx.cs" Inherits="StuFileManagement.RecordChangeAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        档案变动编号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <br />
        档案变动日期：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        初始院系：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        现在院系：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        初始班级：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        现在班级：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
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
