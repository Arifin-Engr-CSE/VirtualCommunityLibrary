using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemLibraryLocation
    {
        public int LibraryLocationID { get; set; }
        public string LibraryLocationName { get; set; }
        public string LibraryLocationAddress { get; set; }
        public int LibraryLocationManagerID { get; set; }
        public string LibraryManagerName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

    }
}


