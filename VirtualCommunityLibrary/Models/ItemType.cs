using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualCommunityLibrary.Models
{
    public class ItemType
    {
        public int ID { get; set; }

        [Display(Name = "Item Type")]
        [Required(ErrorMessage = "Item Type is Required")]
        [StringLength(maximumLength: 50)]
        public string ItemTypeName{ get; set; }

        [Display(Name = "Description")]
        [StringLength(maximumLength:1000)]
        public string TypeDescription { get; set; }

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

        //[Display(Name = "Type Name")]
        //[Required(ErrorMessage = "Type Name is Required")]
        //public int ItemTypeNameID { get; set; }
        //public virtual ItemTypeName itemTypeNames { get; set; }
        //[NotMapped]
        //public IEnumerable<SelectListItem> ItemTypeNameList { get; set; }

        [NotMapped]
        public virtual List<ItemType> ItemTypes { get; set; }


    }
}