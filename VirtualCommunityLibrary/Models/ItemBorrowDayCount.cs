using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualCommunityLibrary.Models
{
    public class ItemBorrowDayCount
    {
        [Key] 
        public int ItemBorrowDayCountID { get; set; }

        [Display(Name ="Library")]
        [Required(ErrorMessage ="Library Name is Required")]
        public int LibraryLocationID { get; set; }
        public virtual ItemLibraryLocation itemLibraryLocation { get; set; }

        [Display(Name ="Borrow Days")]
        public int NumberOfDays { get; set; }

        [NotMapped]
        public List<ItemBorrowDayCount> itemBorrowDayCounts { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> LibraryLocationList { get; set; }
    }
}