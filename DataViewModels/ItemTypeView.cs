using System;
using System.Collections.Generic;
using System.Text;

namespace DataViewModels
{
    public class ItemTypeView
    {
        public int ID { get; set; }
        public string ItemTypeName { get; set; }
        public string TypeDescription { get; set; }
        public int LibraryLocationID { get; set; }
    }
}
