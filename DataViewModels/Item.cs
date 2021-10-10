using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemLocationID { get; set; }
        public int ItemOwnerID { get; set; }
        public string ItemMaker { get; set; }
        public string ItemProducer { get; set; }
        public int ItemTypeID { get; set; }
        public bool ItemHasPhoto { get; set; }
        public int ItemBorrowStatusID { get; set; }
        public int LibraryLocationID { get; set; }
        public string ItemConditionWhenRegistered { get; set; }
        public string AdditionalNote { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
