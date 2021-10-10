using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataViewModels
{
    public class ItemPartyView
    {
        public int ItemPartyID { get; set; }
        [Display(Name = "Party Name")]
        public string PartyName { get; set; }
        [Display(Name = "Party Type")]
        public string PartyTypeName { get; set; }
        [Display(Name = "Address")]
        public string PartyAddress { get; set; }
        [Display(Name = "Mobile")]
        public string PartyMobile { get; set; }
        [Display(Name = "Note")]
        public string PartyNoteIfAny { get; set; }

    }
}
