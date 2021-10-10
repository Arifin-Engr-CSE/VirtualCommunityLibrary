using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataViewModels
{
    //model to display data in the UI
    public class ItemBorrowView
    {
        public int ItemID { get; set; }
        
        [Display(Name = "Book name")]
        public string ItemName { get; set; }
        
        [Display(Name = "Borrower")]
        public int ItemPartyID { get; set; }
        public string BorrowStatus { get; set; }
        public int LibraryLocationID { get; set; }

        [Display(Name = "Borrow date")]
        public DateTime BorrowDate { get; set; }

        [Display(Name = "Borrow for how many days?")]
        public int BorrowedForHowManyDays { get; set; }

        [Display(Name = "Calculated return date")]
        public DateTime CalculatedReturnDate { get; set; }
        public List<ItemPartyOfALibrary> PartyName { get; set; }
        public List<ItemBorrowDayCountView> BorrowDay { get; set; }

    }
}
