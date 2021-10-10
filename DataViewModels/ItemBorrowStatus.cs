using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemBorrowStatus
    {
        public int BorrowStatusID { get; set; }
        public string BorrowStatus { get; set; }
        public string BorrowDescription { get; set; }
        public int LibraryLocationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}

