using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemParty
    {
        public int ItemPartyID { get; set; }
        public string PartyName { get; set; }
        public int PartyTypeID { get; set; }
        public int LibraryLocationID { get; set; }
        public string PartyTypeName { get; set; }
        public string PartyAddress { get; set; }
        public string PartyMobile { get; set; }
        public string PartyNoteIfAny { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

    }
}
