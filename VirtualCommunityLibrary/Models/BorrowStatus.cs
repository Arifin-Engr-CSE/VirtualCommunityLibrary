using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VirtualCommunityLibrary.Models
{
    public class BorrowStatus
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Status is Required")]
        [StringLength(maximumLength:50)]
        public string Status { get; set; }
    }
}