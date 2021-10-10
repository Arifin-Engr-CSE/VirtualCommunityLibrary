using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualCommunityLibrary.Models
{
    public class ItemBorrowStatus
    {
        [Key]
        [Required]
        public int ItemBorrowStatusID { get; set; }

        [Required(ErrorMessage = "Borrow Status is Required")]
        [Display(Name = "Status Type")]
        [StringLength(maximumLength: 50)]
        public string BorrowStatus { get; set; }

        [Required(ErrorMessage ="Borrow Description is Required")]
        [Display(Name ="Description")]
        [StringLength(maximumLength:1000)]
        public string BorrowDescription { get; set; }

        [Display(Name = "Created On")]
        [Column(TypeName = "")]
        public DateTime? CreatedOn { get; set; }


        [Display(Name = "Created By")]
        [StringLength(maximumLength: 100)]
        public string CreatedBy { get; set; }

        [Display(Name = "Modified On")]
        [Column(TypeName = "")]
        public DateTime? ModifiedOn { get; set; }

        [Display(Name = "Modified By")]
        [StringLength(maximumLength: 100)]
        public string ModifiedBy { get; set; }

        //[Display(Name ="Status")]
        //[Required(ErrorMessage ="Status is Required")]
        //public int BorrowStatusID { get; set; }
        //public virtual BorrowStatus BorrowStatus { get; set; }
        //[NotMapped]
        //public IEnumerable<SelectListItem> StatusList { get; set; }

        [Display(Name = "Item Type")]
        [Required(ErrorMessage ="Item Type is Required")]
        public int ItemTypeID { get; set; }
        public virtual ItemType ItemType { get; set; }

        [Display(Name ="Library")]
        [Required(ErrorMessage = "Location is Required")]
        public int LibraryLocationID { get; set; }
        public virtual ItemLibraryLocation ItemLibraryLocation { get; set; }


        [NotMapped]
        public List<ItemBorrowStatus> itemBorrowStatuses { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ItemTypeList { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> LibraryLocList { get; set; }
    }
}