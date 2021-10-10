using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VirtualCommunityLibrary.Models
{
    public class PartyType
    {
        [Key]
        [Required]
        public int PartyTypeID { get; set; }

        [Display(Name ="Party Type")]
        [Required(ErrorMessage ="Party Type Name is Required")]
        [StringLength(maximumLength:50)]
        public string PartyTypeName { get; set; }
    }
}