using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanksgivingWithTypes
{
    public class Thanksgiving
    {
        public string[] Food;
        public string Turkey { get; set; }  
        public int? TurkeyWeight { get; set; }
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    }
}
