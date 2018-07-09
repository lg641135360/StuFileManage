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
    public partial class StuInfoShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string sqlSelect = "select * from StuInfo ";
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, null);
            GridView1.DataBind();
        }

        private void DisplayData(string sno)
        {
            string sqlSelect = "select * from StuInfo where sno = @sno";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@sno",sno)
            };
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, paras);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals(""))
                DisplayData();
            else
                DisplayData(TextBox1.Text.Trim());
        }
    }
}