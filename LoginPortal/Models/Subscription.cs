using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPortal.Models
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public int MemberID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Drug Name")]
        public string DrugName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Location { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Refill Occurance")]
        public string RefillOccurance { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "No. of Refills")]
        public int NoOfRefills { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Insurance Id")]
        public string InsuranceId { get; set; }
    }
}
