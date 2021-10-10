using Dapper;
using DataViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class ItemTypeData
    {
        private string _connectionString;
        public ItemTypeData(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<ItemTypeView> GetAllItemTypeForALibrary(int? libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemTypeView>(_connectionString, "[dbo].[ItemType_GetAll]", param);
        }

        public ItemType GetSingleItemTypeForViewOrEdit(int? itemTypeID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemTypeID", itemTypeID);

            var data = DataAccess.ReturnList<ItemType>(_connectionString, "dbo.ItemType_GetById", param).FirstOrDefault<ItemType>();

            return data;
        }

        public void AddOrEdit(ItemType itemType)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ID", itemType.ID);
            param.Add("@ItemTypeName", itemType.ItemTypeName);
            param.Add("@TypeDescription", itemType.TypeDescription);
            param.Add("@LibraryLocationID", itemType.LibraryLocationID);
            param.Add("@CreatedBy", itemType.CreatedBy);
            param.Add("@ModifiedBy", itemType.ModifiedBy);

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[ItemType_Save]", param);
        }

        public int GetItemTypeIDForABook(int? libraryLocationID) 
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ExecuteReturnScalar<int>(_connectionString, "[dbo].[SP_ItemType_GetIdForBook]", param);
        }

    }
}
