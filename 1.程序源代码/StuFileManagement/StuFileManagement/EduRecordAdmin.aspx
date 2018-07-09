<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EduRecordAdmin.aspx.cs" Inherits="StuFileManagement.EduRecordAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        教育经历号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        开始时间：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        结束时间：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        学生名字：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
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
