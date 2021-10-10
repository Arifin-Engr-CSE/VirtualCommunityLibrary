using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemBorrowHistoryView
    {
        public int ItemBorrowID { get; set; }
        public string ItemName { get; set; }
        public string ItemParty { get; set; }
        public string LibraryLocation { get; set; }
        public DateTime BorrowDate { get; set; }
        public int BorrowedForHowManyDays { get; set; }
        public DateTime CalculatedReturnDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
    }
}



