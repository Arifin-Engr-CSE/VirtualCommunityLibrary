using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualCommunityLibrary.Models
{
    public class ItemParty
    {
        [Key]
        [Required]
        public int ItemPartyID { get; set; }


        [Display(Name ="Item Party")]
        [Required(ErrorMessage ="Party Name is Required")]
        [StringLength(maximumLength:50)]
        public string ItemPartyName { get; set; }

        [Display(Name ="Address")]
        [StringLength(maximumLength: 200)]
        public string PartyAddress { get; set; }

        [Display(Name ="Mobile No")]
        [StringLength(maximumLength: 50)]
        public string PartyMobile { get; set; }

        [Display(Name ="Note if any")]
        [StringLength(maximumLength: 1000)]
        public string PartyNoteIfAny { get; set; }

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

        [Display(Name ="Party Type")]
        [Required(ErrorMessage ="Party Type is Required")]
        public int ItemPartyTypeID { get; set; }
        public virtual ItemPartyType ItemPartyType { get; set; }

        [NotMapped]
        public List<ItemParty> itemParties { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ItemPartyTypeList { get; set; }
    }
}