using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StuFileManagement
{
    public class User
    {
        public string loginName { get; set; }
        public string password { get; set; }
        public int limit { get; set; }
    }
}