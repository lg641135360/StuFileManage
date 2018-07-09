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
    public partial class DeptClassAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string sqlSelect = "select * from SdeptClass ";
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, null);
            GridView1.DataBind();
        }

        private void DisplayData(int sDeptClassno)
        {
            string sqlSelect = "select * from SdeptClass where sDeptClassno = @sDeptClassno";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@sDeptClassno",sDeptClassno)
            };
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, paras);
            GridView1.DataBind();
        }

        private bool update(SdeptClass s)
        {
            SqlParameter[] paras = new SqlParameter[]{
             new SqlParameter ("@StuDeptClassNo",s.sDeptClassno),
             new SqlParameter ("@StuDepartment",s.department),
             new SqlParameter ("@Class",s.clazz)
            };
            int rtn = SqlHelper.ExecuteNonQueryUsingProcedure("updateStuDeptClass", paras);

            return rtn > 0 ? true : false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals(""))
                DisplayData();
            else
                DisplayData(int.Parse(TextBox1.Text.Trim()));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SdeptClass s = new SdeptClass();
            s.sDeptClassno = int.Parse(TextBox1.Text.Trim());
            s.department = TextBox2.Text.Trim();
            s.clazz = TextBox3.Text.Trim();
            if (update(s))
            {
                Response.Write("<script>alert('修改成功！');</script>");
                DisplayData();
            }
            else
            {
                Response.Write("<script>alert('修改失败！');</script>");
            }
        }

    }
}