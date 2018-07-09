using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;

namespace StuFileManagement
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string LoginPage = context.Server.MapPath("~/Login.htm");
            string html = System.IO.File.ReadAllText(LoginPage);
            string content = context.Request["_viewstate"];
            bool isPostBack = !string.IsNullOrEmpty(content);
            string loginname = context.Request["loginname"];
            string password = context.Request["password"];
            var sqlSelect = "select limit from UserLogin where loginName=@userName and password=@pwd";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@userName",loginname),
                new SqlParameter("@pwd",password),
            };
            int rtn = Convert.ToInt16(Demo.SqlHelper.ExecuteScalar(sqlSelect, paras));
            if (isPostBack)
            {
                if (rtn > 0)
                {
                    context.Response.Write("<script>alert('登陆成功，管理员大大！');location.href='menu.html';</script>");
                }
                else if (rtn == 0)
                {
                    context.Response.Write("<script>alert('登陆成功，学生同志！');location.href='menu2.html';</script>");
                }
                else
                {
                    context.Response.Write("登陆失败");
                    context.Response.Write(html);
                }
            }
            else //首次登陆
            {

                context.Response.Write(html);
            }
        }



        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}