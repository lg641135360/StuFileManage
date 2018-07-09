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
    public partial class MultiTableInquiry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string sqlSelect = "select * from sel_stu_all ";
            GridView1.DataSource = SqlHelper.ExecuteDataTable(sqlSelect, null);
            GridView1.DataBind();
        }
    }
}