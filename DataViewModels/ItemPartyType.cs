using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemPartyType
    {
        public int ItemPartyTypeID { get; set; }
        public string PartyTypeName { get; set; }
        public string PartyTypeDescription { get; set; }
        public int LibraryLocationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

    }
}
