using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StuFileManagement
{
    public class EduRecord
    {
        public int eduexperienceno { get; set; }
        public string sno { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string stuName { get; set; } 
    }
}