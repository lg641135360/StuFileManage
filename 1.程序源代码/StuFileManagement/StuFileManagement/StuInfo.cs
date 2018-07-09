using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StuFileManagement
{
    public class StuInfo
    {
        public string sno { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string nation { get; set; }
        public DateTime birthDate { get; set; }
        public string birthPlace { get; set; }
        public DateTime admissionTime { get; set; }
        public int sDeptClassno { get; set; }
        public int recordno { get; set; } 
    }
}