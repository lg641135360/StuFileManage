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
    public partial class RecordChangeAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string sqlSelect = "select * from RecordChange ";
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, null);
            GridView1.DataBind();
        }

        private void DisplayData(int recordno)
        {
            string sqlSelect = "select * from RecordChange where recordno = @recordno";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@recordno",recordno)
            };
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, paras);
            GridView1.DataBind();
        }

        private bool update(RecordChange rc)
        {
            SqlParameter[] paras = new SqlParameter[]{
             new SqlParameter ("@RecordNo",rc.recordno),
             new SqlParameter ("@ChangeDate",rc.changeDate),
             new SqlParameter ("@OriginalDept",rc.originalDept),
             new SqlParameter ("@CurrentDept",rc.currentDept),
             new SqlParameter ("@OriginalClass",rc.originalClass),
             new SqlParameter ("@CurrentClass",rc.currentClass)
            };
            int rtn = SqlHelper.ExecuteNonQueryUsingProcedure("updateRecordChange", paras);

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
            RecordChange rc = new RecordChange();
            rc.recordno = int.Parse(TextBox1.Text.Trim());
            if ("".Equals(TextBox2.Text.Trim()))
            {
                rc.changeDate = DateTime.Parse("1997/1/1");
            }
            else
                rc.changeDate = DateTime.Parse(TextBox2.Text.Trim());
            rc.originalDept = TextBox3.Text.Trim();
            rc.currentDept = TextBox4.Text.Trim();
            rc.originalClass = TextBox5.Text.Trim();
            rc.currentClass = TextBox6.Text.Trim();
            if (update(rc))
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