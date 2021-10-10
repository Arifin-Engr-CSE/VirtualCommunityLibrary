namespace DataViewModels
{
    public class ItemPhotoAddEditView
    {
        public int PhotoID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string PhotoURL { get; set; }
        public byte[] PhotoBinary { get; set; }
        public int PhotoPriority { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
