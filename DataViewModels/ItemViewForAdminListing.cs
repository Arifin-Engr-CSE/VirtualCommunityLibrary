using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemViewForAdminListing
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string PartyName { get; set; } //PartyName from ItemParty
        public string BorrowStatus { get; set; }

    }
}
