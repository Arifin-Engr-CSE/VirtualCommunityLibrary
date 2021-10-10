using System.ComponentModel.DataAnnotations;

namespace DataViewModels
{
    public class ItemBorrowStatusView
    {
        public int BorrowStatusID { get; set; }
        [Display(Name = "Borrow Status")]
        public string BorrowStatus { get; set; }
        [Display(Name = "Description")]
        public string BorrowDescription { get; set; }
        public int LibraryLocationID { get; set; }
        [Display(Name = "Library Name")]
        public string LibraryLocationName { get; set; }
    }
}

