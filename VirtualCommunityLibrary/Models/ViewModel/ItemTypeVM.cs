using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualCommunityLibrary.Models.Model;

namespace VirtualCommunityLibrary.Models.ViewModel
{
    public class ItemTypeVM
    {
        public int ID { get; set; }

        [Display(Name ="Description")]
        [StringLength(maximumLength: 1000)]
        public string TypeDescription { get; set; }

        [Display(Name ="Created On")]
        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }

        [Display(Name ="Created By")]
        [StringLength(maximumLength: 100)]
        public string CreatedBy { get; set; }

        [Display(Name ="Modified On")]
        [DataType(DataType.Date)]
        public DateTime? ModifiedOn { get; set; }

        [Display(Name ="Modified By")]
        [StringLength(maximumLength: 100)]
        public string ModifiedBy { get; set; }

        [Display(Name ="Type Name")]
        [Required(ErrorMessage = "Type Name is Required")]
        public int ItemTypeNameID { get; set; }

        [NotMapped]
        public List<ItemType> ItemTypes { get; set; }

    }
}