using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualCommunityLibrary.Models
{
    public class ItemLibraryLocation
    {
        [Key]
        [Required]
        public int LibraryLocationID { get; set; }

        [Display(Name = "Library Name")]
        [Required(ErrorMessage = "Library Location is Required")]
        [StringLength(maximumLength: 50)]
        public string LibraryLocation { get; set; }

        [Display(Name ="Address")]
        public string LibraryLocationAddress { get; set; }


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

        //[Required(ErrorMessage ="Location Name is Required")]
        //public int LocationID { get; set; }
        //public virtual Location Location { get; set; }

        [Display(Name ="Library Manager")]
        public int ItemPartyID { get; set; }
        public virtual ItemParty ItemParty { get; set; }

        [NotMapped]
        public List<ItemLibraryLocation> itemLibraryLocations { get; set; }
        //[NotMapped]
        //public IEnumerable<SelectListItem> LocationNameList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ItemPartyList { get; set; }
    }
}