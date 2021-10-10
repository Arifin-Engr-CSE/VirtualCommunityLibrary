using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualCommunityLibrary.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Display(Name ="Book Name")]
        [Required(ErrorMessage ="Book Name is Required")]
        [StringLength(maximumLength:50)]
        public string ItemName { get; set; }

        //[ForeignKey("ItemParty")]
        //[Display(Name ="Party Location")]
        //public int? ItemLocationID { get; set; }
        //public virtual ItemParty ItemParty { get; set; }

        //[ForeignKey("ItemPartyType")]
        //[Display(Name = "Item Owner")]
        //public int? ItemOwnerID { get; set; }
        //public virtual ItemPartyType ItemPartyType { get; set; }

        [ForeignKey("ItemPartyType")]
        [Display(Name = "Party Location")]
        public int? ItemLocationID { get; set; }
        public virtual ItemPartyType ItemPartyType { get; set; }

        [ForeignKey("ItemParty")]
        [Display(Name = "Item Owner")]
        public int? ItemOwnerID { get; set; }
        public virtual ItemParty ItemParty { get; set; }

        [Display(Name = "Writter")]
        [StringLength(maximumLength: 50)]
        public string ItemMaker { get; set; }

        [Display(Name = "Publisher")]
        [StringLength(maximumLength: 50)]
        public string ItemProducer { get; set; }

        [ForeignKey("ItemType")]
        [Display(Name = "Item Type")]
        public int? ItemTypeID { get; set; }
        public virtual ItemType ItemType { get; set; }

        [Display(Name = "Has Photo ")]
        public Boolean ItemHasPhoto { get; set; }

        [Display(Name = "Borrow Status")]
        public int? ItemBorrowStatusID { get; set; }
        public virtual ItemBorrowStatus ItemBorrowStatus { get; set; }

        [Display(Name = "Library Location")]
        public int? LibraryLocationID { get; set; }
        public virtual ItemLibraryLocation ItemLibraryLocation { get; set; }

        [Display(Name = "Item Condition")]
        [StringLength(maximumLength: 1000)]
        public string ItemConditionWhenRegistered { get; set; }

        [Display(Name = "Additional Note ")]
        [StringLength(maximumLength: 1000)]
        public string AdditionalNote { get; set; }

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

        [NotMapped]
        public List<Item> items { get; set; }
        [NotMapped]
        public List<Item> itmStatus { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> ItemPartyList { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> PartyTypeList { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> ItemTypeList { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> ItemBorrowStatusList { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> LibraryLocationList { get; set; }

    }
}