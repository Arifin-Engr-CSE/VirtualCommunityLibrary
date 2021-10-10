using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VirtualCommunityLibrary.Models
{
    public class ItemPhoto
    {
        [Key]
        public int PhotoID { get; set; }

        [Display(Name = "Image")]
        [StringLength(maximumLength: 2000)]
        public string PhotoURL { get; set; }

        [Display(Name = "Image")]
        public byte[] PhotoBinary { get; set; }

        [Display(Name = "Photo Priority")]
        public int PhotoPriority { get; set; }

        [Display(Name = "Created On")]
        [Column(TypeName = "")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Created By")]
        [StringLength(maximumLength: 100)]
        public string CreatedBy { get; set; }

        [Display(Name = "Modified On")]
        [Column(TypeName = "")]
        public DateTime? ModifiedOn { get; set; }

        [Display(Name = "Modified By")]
        [StringLength(maximumLength: 100)]
        public string ModifiedBy { get; set; }

        public int ItemID { get; set; }
        public virtual Item Item { get; set; }

        [NotMapped]
        public List<ItemPhoto> itemPhotos { get; set; }
        [NotMapped]
        public List<ItemPhoto> itemPhotos1 { get; set; }
        [NotMapped]
        public string ItemName { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        
        public ItemPhoto()
        {
            PhotoURL = "~/AppFiles/Images/default.png";
        }
    }
}