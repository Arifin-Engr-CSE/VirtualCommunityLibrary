using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualCommunityLibrary.Models
{
    public class ItemPartyType
    {
        [Key]
        [Required]
        public int ItemPartyTypeID { get; set; }

        [Display(Name = "Party Type")]
        [Required(ErrorMessage = "Item Type is Required")]
        [StringLength(maximumLength: 50)]
        public string PartyTypeName { get; set; }

        [Display(Name ="Description")]
        [Required(ErrorMessage ="Description is Required")]
        [StringLength(maximumLength:1000)]
        public string PartyTypeDescription { get; set; }

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

        //[Required]
        //public int PartyTypeID { get; set; }
        //public virtual PartyType PartyType { get; set; }

        [NotMapped]
        public List<ItemPartyType> itemPartyTypes { get; set; }

        //[NotMapped]
        //public IEnumerable<SelectListItem> PartyTypeList { get; set; }


    }
}