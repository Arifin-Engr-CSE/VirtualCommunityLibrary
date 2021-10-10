using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualCommunityLibrary.Models
{
    public class ItemBorrowHistory
    {
        [Key]
        public int ItemBorrowID { get; set; }

        [Display(Name ="Item")]
        public int? ItemID { get; set; }
        public virtual Item Item { get; set; }

        public int? ItemPartyID { get; set; }
        public virtual ItemParty ItemParty { get; set; }

        public int? LibraryLocationID { get; set; }
        public virtual ItemLibraryLocation ItemLibraryLocation { get; set; }

        [Display(Name = "Borrow Date")]
        [Column(TypeName = "")]
        public DateTime? BorrowDate { get; set; }

        [Display(Name ="How Many Days")]
        public int BorrowedForHowManyDays { get; set; }

        [Display(Name = "Return Date")]
        [Column(TypeName = "")]
        public DateTime? ReturnDate { get; set; }

        [Display(Name = "Created On")]
        [Column(TypeName = "")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Created By")]
        [StringLength(maximumLength: 100)]
        public string CreatedBy { get; set; }

        [Display(Name = "Modified On")]
        [Column(TypeName = "")]
        public DateTime? ModifiedOn { get; set; }

        [Display(Name = "Modified By")]
        [StringLength(maximumLength: 100)]
        public string ModifiedBy { get; set; }

        public int? ItemBorrowDayCountID { get; set; }
        public virtual ItemBorrowDayCount ItemBorrowDayCount { get; set; }

        [NotMapped]
        public string statusName { get; set; }
        [NotMapped]
        public List<ItemBorrowHistory> itemBorrowHistories { get; set; }
        [NotMapped]
        public List<ItemPhoto> itemPhotos { get; set; }
        [NotMapped]
        public List<ItemPhoto> itemPhotos1 { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> BorrowDayList { get; set; }
    }
}