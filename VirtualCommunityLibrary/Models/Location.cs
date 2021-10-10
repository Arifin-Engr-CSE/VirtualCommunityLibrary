using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VirtualCommunityLibrary.Models
{
    public class Location
    {
        [Key]
        [Required]
        public int LocationID { get; set; }

        
        [Display(Name = "Location Name")]
        [Required(ErrorMessage = "Location Name is Required")]
        [StringLength(maximumLength:50)]
        public string LocationName { get; set; }
    }
}