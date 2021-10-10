using Dapper;
using DataViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class ItemOrBookData
    {
        private string _connectionString;
        public ItemOrBookData(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<ItemViewForAdminListing> GetAllItemOrBookForAdminListing(int libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemViewForAdminListing>(_connectionString, "[dbo].[Item_GetAll]", param);
        }

       
        public void AddOrEdit(Item item)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemID", item.ItemID);
            param.Add("@ItemName", item.ItemName);
            param.Add("@ItemOwnerID", item.ItemOwnerID);
            param.Add("@ItemMaker", item.ItemMaker);
            param.Add("@ItemProducer", item.ItemProducer);
            param.Add("@ItemTypeID", item.ItemTypeID);
            param.Add("@ItemBorrowStatusID", item.ItemBorrowStatusID);
            param.Add("@LibraryLocationID", item.LibraryLocationID);
            param.Add("@ItemConditionWhenRegistered", item.ItemConditionWhenRegistered);
            param.Add("@AdditionalNote", item.AdditionalNote);
            param.Add("@CreatedBy", item.CreatedBy);
            param.Add("@ModifiedBy", item.ModifiedBy);

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[Item_Save]", param);
        }

        public ItemViewForDetailPage GetSingleItemOrBookForViewOrEdit(int? itemOrBookID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemID", itemOrBookID);

            var data = DataAccess.ReturnList<ItemViewForDetailPage>(_connectionString, "dbo.Item_GetById", param).FirstOrDefault<ItemViewForDetailPage>();

            return data;
        }

        public IEnumerable<ItemViewForBorrowReturnPage> GetAllItemOrBookBorrowReturnPage(int libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemViewForBorrowReturnPage>(_connectionString, "[dbo].[SP_Item_GetAll_With_Photo]", param);
        }

        public void AddItemOrBookBorrowData(ItemBorrowAddEditView itemBorrowData)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemBorrowID", itemBorrowData.ItemBorrowID);
            param.Add("@ItemID", itemBorrowData.ItemID);
            param.Add("@ItemPartyID", itemBorrowData.ItemPartyID);
            param.Add("@LibraryLocationID", itemBorrowData.LibraryLocationID);
            param.Add("@BorrowDate", itemBorrowData.BorrowDate);
            param.Add("@BorrowedForHowManyDays", itemBorrowData.BorrowedForHowManyDays);
            param.Add("@CalculatedReturnDate", itemBorrowData.CalculatedReturnDate);
            if(itemBorrowData.BorrowStatus != "Borrow") param.Add("@ActualReturnDate", itemBorrowData.ActualReturnDate);
            param.Add("@CreatedBy", itemBorrowData.CreatedBy);
            param.Add("@ModifiedBy", itemBorrowData.ModifiedBy);

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[ItemBorrowHistory_Save]", param);

        }
        public ItemBorrowAddEditView GetLastItemOrBookBorrowHistory(int? itemOrBookID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemID", itemOrBookID);

            var data = DataAccess.ReturnList<ItemBorrowAddEditView>(_connectionString, "dbo.ItemBorrowHistory_GetById", param).FirstOrDefault<ItemBorrowAddEditView>();

            return data;
        }

        public IEnumerable<ItemHistoryView> GetHistoryListOfAItemOrBook(int? itemOrBookID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemID", itemOrBookID);
            return DataAccess.ReturnList<ItemHistoryView>(_connectionString, "[dbo].[ItemHistory_GetAll]", param);
        }

        public ItemPhotoAddEditView GetItemOrBookPrimaryPhoto(int? itemOrBookID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemID", itemOrBookID);

            var data = DataAccess.ReturnList<ItemPhotoAddEditView>(_connectionString, "dbo.ItemPhoto_GetById", param).FirstOrDefault<ItemPhotoAddEditView>();

            return data;
        }

        public void AddItemOrBookPrimaryPhoto(ItemPhotoAddEditView itemPhoto)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PhotoID", itemPhoto.PhotoID);
            param.Add("@PhotoURL", itemPhoto.PhotoURL);
            param.Add("@PhotoBinary", itemPhoto.PhotoBinary);
            param.Add("@PhotoPriority", itemPhoto.PhotoPriority);
            param.Add("@ItemID", itemPhoto.ItemID);
            param.Add("@CreatedBy", itemPhoto.CreatedBy);
            param.Add("@ModifiedBy", itemPhoto.ModifiedBy);

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[ItemPhoto_Save]", param);

        }
    }
}
