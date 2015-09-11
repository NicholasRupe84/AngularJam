using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMPmvcSPA.Models
{
    public class ViewModelBase
    {
        public string pageName { get; set; }
        public Person user { get; set; }
    }
}