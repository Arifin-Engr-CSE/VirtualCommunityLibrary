using System;
using System.ComponentModel.DataAnnotations;

namespace DataViewModels
{
    public class ItemViewForDetailPage
    {
        public int ItemID { get; set; }
        [Display(Name = "Book")]
        public string ItemName { get; set; }
        public int ItemOwnerID { get; set; }
        [Display(Name = "Book Owner")]
        public string PartyName { get; set; } //PartyName from ItemParty
        [Display(Name = "Writer")]
        public string ItemMaker { get; set; }
        [Display(Name = "Publisher")]
        public string ItemProducer { get; set; }
        [Display(Name = "Item Type")]
        public int ItemTypeID { get; set; }
        public string  ItemTypeName { get; set; }
        public bool ItemHasPhoto { get; set; }
        public int ItemBorrowStatusID { get; set; }
        [Display(Name = "Borrow Status")]
        public string BorrowStatus { get; set; }
        public int LibraryLocationID { get; set; }
        [Display(Name = "Library Name")]
        public string LibraryLocationName { get; set; }
        [Display(Name = "Initial Book Condition")]
        public string ItemConditionWhenRegistered { get; set; }
        [Display(Name = "Any Note")]
        public string AdditionalNote { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

    }
}
