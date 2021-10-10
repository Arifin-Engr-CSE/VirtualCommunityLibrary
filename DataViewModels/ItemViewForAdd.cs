using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataViewModels
{
    public class ItemViewForAdd
    {
        public int ItemID { get; set; }
        [Display(Name = "Book")]
        public string ItemName { get; set; }
        [Display(Name = "Book owner")]
        public int ItemOwnerID { get; set; }

        [Display(Name = "Book writer")]
        public string ItemMaker { get; set; }
        [Display(Name = "Book publisher")]
        public string ItemProducer { get; set; }
        [Display(Name = "Item type")]
        public int ItemTypeID { get; set; }
        public int ItemBorrowStatusID { get; set; }
        [Display(Name = "Borrow status")]
        public int LibraryLocationID { get; set; }
        [Display(Name = "Initial book condition")]
        public string ItemConditionWhenRegistered { get; set; }
        [Display(Name = "Any other note")]
        public string AdditionalNote { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public List<ItemPartyOfALibrary> ItemParty { get; set; }  //ItemOwnerID

    }
}
