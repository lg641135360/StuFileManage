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
    public partial class EduRecordInquiry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string sqlSelect = "select * from EduRecord ";
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, null);
            GridView1.DataBind();
        }

        private void DisplayData(int eduexperienceno)
        {
            string sqlSelect = "select * from EduRecord where eduexperienceno = @eduexperienceno";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@eduexperienceno",eduexperienceno)
            };
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, paras);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals(""))
                DisplayData();
            else
                DisplayData(int.Parse(TextBox1.Text.Trim()));
        }
    }
}