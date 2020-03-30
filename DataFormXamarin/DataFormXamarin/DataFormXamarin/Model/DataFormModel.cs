using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormModel 
    {
        public string Name { get; set; }
        public int? Hours { get; set; }
        public string Comments { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
