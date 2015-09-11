using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMPmvcSPA.Models
{
    public class SelectQuoteViewModel : ViewModelBase
    {
        public bool updatedCar { get; set; }
        public bool updatedHome { get; set; }
        public bool updatedMotorcycle { get; set; }
    }
}