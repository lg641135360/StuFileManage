using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Demo; 

namespace StuFileManagement
{
    public partial class UserManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string sqlSelect = "select * from UserLogin ";
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, null);
            GridView1.DataBind();
        }

        private void DisplayData(string loginName)
        {
            string sqlSelect = "select * from UserLogin where loginName = @loginName";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@loginName",loginName)
            };
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, paras);
            GridView1.DataBind();
        }

        private bool ExistByName(string name)
        {
            string sqlSelect = "select * from UserLogin where loginName=@loginName";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@loginName", name)
            };
            SqlDataReader result = SqlHelper.ExecuteReader(sqlSelect, paras);
            if (result.HasRows)
            {
                return true;
            }
            return false;
        }

        private bool InsertDataWithEntity(User u)
        {
            SqlParameter[] paras = new SqlParameter[]{
             new SqlParameter ("@UserLoginName",u.loginName),
             new SqlParameter ("@UserPassword",u.password),
             new SqlParameter ("@Limit",u.limit)
            };
            int rtn = SqlHelper.ExecuteNonQueryUsingProcedure("insertUser", paras);

            return rtn > 0 ? true : false;
        }

        private bool UpdateDateWithEntity(User u)
        {
            SqlParameter[] paras = new SqlParameter[]{
             new SqlParameter ("@UserLoginName",u.loginName),
             new SqlParameter ("@UserPassword",u.password),
             new SqlParameter ("@Limit",u.limit)
            };
            int rtn = SqlHelper.ExecuteNonQueryUsingProcedure("updateUserByLoginName", paras);

            return rtn > 0 ? true : false;
        }

        private bool deleteWithLoginName(string loginName)
        {
            var sqlInsert = "delete from UserLogin where loginName = @loginName";
            SqlParameter[] paras = new SqlParameter[]{
             new SqlParameter ("@loginName",loginName),
            };
            int rtn = SqlHelper.ExecuteNonQuery(sqlInsert, paras);

            return rtn > 0 ? true : false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals(""))
                DisplayData();
            else
                DisplayData(TextBox1.Text.Trim());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.loginName = TextBox1.Text.Trim();
            u.password = TextBox2.Text.Trim();
            if ("".Equals(TextBox3.Text.Trim()))
            {
                u.limit = 0;
            }
            else
                u.limit = int.Parse(TextBox3.Text.Trim());
            if (!ExistByName(u.loginName))
            {
                if (InsertDataWithEntity(u))
                {
                    Response.Write("<script>alert('录入成功！');</script>");
                    DisplayData();
                }
                else
                {
                    Response.Write("<script>alert('录入失败！');</script>");
                }
            }
            else
                Response.Write("<script>alert('已存在！');</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.loginName = TextBox1.Text.Trim();
            u.password = TextBox2.Text.Trim();
            if ("".Equals(TextBox3.Text.Trim()))
            {
                u.limit = 0;
            }
            else
                u.limit = int.Parse(TextBox3.Text.Trim());

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string loginName = TextBox1.Text.Trim();
            if (ExistByName(loginName))
            {
                if (deleteWithLoginName(loginName))
                {
                    Response.Write("<script>alert('删除成功！');</script>");
                    DisplayData();
                }
                else
                    Response.Write("<script>alert('删除失败！');</script>");
            }
        }

    }
}