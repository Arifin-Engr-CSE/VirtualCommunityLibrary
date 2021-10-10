using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemType
    {
        public int ID { get; set; }
        public string ItemTypeName { get; set; }
        public string TypeDescription { get; set; }
        public int LibraryLocationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

    }
}
