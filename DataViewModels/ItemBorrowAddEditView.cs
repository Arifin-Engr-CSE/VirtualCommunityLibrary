using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataViewModels
{
    //model to add/save data in DB
    public class ItemBorrowAddEditView
    {
        public int ItemBorrowID { get; set; }
        public int ItemID { get; set; }

        [Display(Name = "Book name")]
        public string ItemName { get; set; }
        public int ItemPartyID { get; set; }
        public string BorrowStatus { get; set; }
        public int LibraryLocationID { get; set; }

        [Display(Name = "Borrow date")]
        public DateTime BorrowDate { get; set; }

        [Display(Name = "Borrowed for how many days")]
        public int BorrowedForHowManyDays { get; set; }
        public DateTime CalculatedReturnDate { get; set; }

        [Display(Name = "Return Date")]
        public DateTime ActualReturnDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
