using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataViewModels
{
    public class ItemPartyTypeView
    {
        [Display(Name = "Party Type ID")]
        public int ItemPartyTypeID { get; set; }
        [Display(Name = "Party Type")]
        public string PartyTypeName { get; set; }
        [Display(Name = "Description")]
        public string PartyTypeDescription { get; set; }
        public int LibraryLocationID { get; set; }

    }
}
