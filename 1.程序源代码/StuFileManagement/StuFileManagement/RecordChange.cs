using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StuFileManagement
{
    public class RecordChange
    {
        public int recordno { get; set; }
        public string sno { get; set; }
        public DateTime changeDate { get; set; }    
        public string originalDept { get; set; }
        public string currentDept { get; set; }
        public string originalClass { get; set; }   
        public string currentClass { get; set; }
    }
}