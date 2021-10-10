using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemBorrowHistory
    {
        public int ItemBorrowID { get; set; }
        public int ItemID { get; set; }
        public int ItemPartyID { get; set; }
        public int LibraryLocationID { get; set; }
        public DateTime BorrowDate { get; set; }
        public int BorrowedForHowManyDays { get; set; }
        public DateTime CalculatedReturnDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}



