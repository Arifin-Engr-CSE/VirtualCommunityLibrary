using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataViewModels
{
    public class ItemHistoryView
    {
        [Display(Name = "SL#")]
        public int RowID { get; set; }
        
        [Display(Name = "Event date")]
        public DateTime EventDate { get; set; }
        
        [Display(Name = "Book")]
        public string BookName { get; set; }
        [Display(Name = "Event")]
        public string EventType { get; set; }

        [Display(Name = "Detail")]
        public string EventDetail { get; set; }

        public string FormattedEventDate
        {
            get { return EventDate.ToString("yyyy-MM-dd"); }
        }
    }
}
