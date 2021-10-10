using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemLibraryLocationViewForAddEdit
    {
        public int LibraryLocationID { get; set; }
        public string LibraryLocationName { get; set; }
        public string LibraryLocationAddress { get; set; }
        public int LibraryLocationManagerID { get; set; }
        public List<ItemPartyOfALibrary> LibraryLocationManagerList { get; set; }

    }
}


