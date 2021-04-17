using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPortal.Models
{
    public class Drug
    { 
        public string SearchBy { get; set; }

        public string SearchString { get; set; }

        public string Location { get; set; }
    }
}
