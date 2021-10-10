using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemViewForBorrowReturnPage
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemMaker { get; set; }
        public string ItemProducer { get; set; }
        public string BorrowStatus { get; set; }
        public bool ItemHasPhoto { get; set; }
        public string PhotoURL { get; set; }
        public byte[] PhotoBinary { get; set; }
    }
}
