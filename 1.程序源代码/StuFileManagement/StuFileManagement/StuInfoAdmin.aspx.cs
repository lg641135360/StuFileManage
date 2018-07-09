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
    public partial class StuInfoAdmin : System.Web.UI.Page
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

        private bool ExistByNo(string name)
        {
            string sqlSelect = "select * from StuInfo where name=@name";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@name", name)
            };
            SqlDataReader result = SqlHelper.ExecuteReader(sqlSelect, paras);
            if (result.HasRows)
            {
                return true;
            }
            return false;
        }

        private bool InsertDataWithEntity(StuInfo stu)
        {
            SqlParameter[] paras = new SqlParameter[]{
             new SqlParameter ("@stuNo",stu.sno),
             new SqlParameter ("@stuName",stu.name),
             new SqlParameter ("@stuSex",stu.sex),
             new SqlParameter ("@stuNation",stu.nation),
             new SqlParameter ("@stuBirthDate",stu.birthDate),
             new SqlParameter ("@stuBirthPlace",stu.birthPlace),
             new SqlParameter ("@stuAdmissionTime",stu.admissionTime),
             new SqlParameter ("@stuDeptClassNo",stu.sDeptClassno),
             new SqlParameter ("@stuRecordNo",stu.recordno)
            };
            int rtn = SqlHelper.ExecuteNonQueryUsingProcedure("insertStu", paras);

            return rtn > 0 ? true : false;
        }

        
        private bool UpdateDateWithEntity(StuInfo stu)
        {
            SqlParameter[] paras = new SqlParameter[]{
             new SqlParameter ("@stuNo",stu.sno),
             new SqlParameter ("@stuName",stu.name),
             new SqlParameter ("@stuSex",stu.sex),
             new SqlParameter ("@stuNation",stu.nation),
             new SqlParameter ("@stuBirthDate",stu.birthDate),
             new SqlParameter ("@stuBirthPlace",stu.birthPlace),
             new SqlParameter ("@stuAdmissionTime",stu.admissionTime)
            };
            int rtn = SqlHelper.ExecuteNonQueryUsingProcedure("updateStuBySno", paras);

            return rtn > 0 ? true : false;
        }

        private bool deleteWithSno(string sno)
        {
            SqlParameter[] paras = new SqlParameter[]{
             new SqlParameter ("@stuNo",sno),
            };
            int rtn = SqlHelper.ExecuteNonQueryUsingProcedure("deleteStuBySno", paras);

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
            StuInfo stu = new StuInfo();
            stu.sno = TextBox1.Text.Trim();
            stu.name = TextBox2.Text.Trim();
            stu.sex = TextBox3.Text.Trim();
            stu.nation = TextBox4.Text.Trim();
            stu.sDeptClassno = (int)DateTime.Now.Ticks;
            stu.recordno = (int)DateTime.Now.Ticks;   //这里使用了现在时间，保证了数字的不重复性（用来做其他表的主键）
            if ("".Equals(TextBox5.Text.Trim()))
            {
                stu.birthDate = DateTime.Parse("1997/1/1");
            } else
                stu.birthDate = DateTime.Parse(TextBox5.Text.Trim());
            stu.birthPlace = TextBox6.Text.Trim();
            if ("".Equals(TextBox7.Text.Trim()))
            {
                stu.admissionTime = DateTime.Parse("1997/1/1");
            }
            else
                stu.admissionTime = DateTime.Parse(TextBox7.Text.Trim());
            if (!ExistByNo(stu.name))
            {
                if (InsertDataWithEntity(stu))
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
            StuInfo stu = new StuInfo();
            stu.sno = TextBox1.Text.Trim();
            stu.name = TextBox2.Text.Trim();
            stu.sex = TextBox3.Text.Trim();
            stu.nation = TextBox4.Text.Trim();
            if ("".Equals(TextBox5.Text.Trim()))
            {
                stu.birthDate = DateTime.Parse("1997/1/1");
            }
            else
                stu.birthDate = DateTime.Parse(TextBox5.Text.Trim());
            stu.birthPlace = TextBox6.Text.Trim();
            if ("".Equals(TextBox7.Text.Trim()))
            {
                stu.admissionTime = DateTime.Parse("1997/1/1");
            }
            else
                stu.admissionTime = DateTime.Parse(TextBox7.Text.Trim());
            if (UpdateDateWithEntity(stu))
            {
                Response.Write("<script>alert('修改成功！');</script>");
                DisplayData();
            }
            else
            {
                Response.Write("<script>alert('修改失败！');</script>");
            }
        }

        //根据学号删除
        protected void Button4_Click(object sender, EventArgs e)
        {
            string sno = TextBox1.Text.Trim();
            if (deleteWithSno(sno))
            {
                Response.Write("<script>alert('删除成功！');</script>");
                DisplayData();
            }
            else
                Response.Write("<script>alert('删除失败！');</script>");
        }

        //返回一个随机的int型的数字
        private int RandomInt()
        {
            Random rd = new Random();
            string str = "";
            while (str.Length < 10)
            {
                int temp = rd.Next(0, 10);
                if (!str.Contains(temp + ""))
                {
                    str += temp;
                }
            }
            return int.Parse(str);
        }

    }
}