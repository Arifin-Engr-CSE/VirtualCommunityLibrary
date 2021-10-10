using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataViewModels
{
    public class ItemPartyViewForAddEdit
    {
        public int ItemPartyID { get; set; }
        
        
        [Display(Name = "Party Name")]
        [Required]
        public string PartyName { get; set; }
        [Display(Name = "Party Type")]

        public int LibraryLocationID { get; set; }
        [Display(Name = "Party Type")]
        public int PartyTypeID { get; set; }
        public string PartyTypeName { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string PartyAddress { get; set; }
        [Display(Name = "Mobile")]
        [Required]
        public string PartyMobile { get; set; }
        [Display(Name = "Note")]
        public string PartyNoteIfAny { get; set; }
        public List<ItemPartyTypeView> PartyType { get; set; }

    }
}
