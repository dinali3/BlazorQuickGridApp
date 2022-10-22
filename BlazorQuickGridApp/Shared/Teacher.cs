using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorQuickGridApp.Shared
{
    public class Teacher
    {
        public int id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public int TelNo {get; set; } 
        public School? School { get; set; }

    }
}
