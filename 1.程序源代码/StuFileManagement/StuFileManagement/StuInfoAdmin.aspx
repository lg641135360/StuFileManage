<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuInfoAdmin.aspx.cs" Inherits="StuFileManagement.StuInfoAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生基本信息管理Admin页面</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        姓名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        性别：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        国籍：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        生日：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        籍贯：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        入学时间：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
            <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="录入" onclick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="修改" onclick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="删除" onclick="Button4_Click" />
        <br />
        
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
    <a href="menu.html">返回menu界面</a>
</body>
</html>
