using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemBorrowDayCount
    {
        public int LibraryLocationID { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
