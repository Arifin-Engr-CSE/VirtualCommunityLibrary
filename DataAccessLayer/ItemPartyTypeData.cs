using Dapper;
using DataViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class ItemPartyTypeData
    {
        private string _connectionString;
        public ItemPartyTypeData(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<ItemPartyTypeView> GetAllItemPartyTypeForALibrary(int? libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemPartyTypeView>(_connectionString, "[dbo].[ItemPartyType_GetAll]", param);
        }

        public void AddOrEdit(ItemPartyType itemPartyType)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemPartyTypeID", itemPartyType.ItemPartyTypeID);
            param.Add("@PartyTypeName", itemPartyType.PartyTypeName);
            param.Add("@PartyTypeDescription", itemPartyType.PartyTypeDescription);
            param.Add("@LibraryLocationID", itemPartyType.LibraryLocationID);
            param.Add("@CreatedBy", itemPartyType.CreatedBy);
            param.Add("@ModifiedBy", itemPartyType.ModifiedBy);

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[ItemPartyType_Save]", param);
        }

        public ItemPartyTypeView GetSingleItemPartyTypeForViewOrEdit(int? itemPartyTypeID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemPartyTypeID", itemPartyTypeID);

            var data = DataAccess.ReturnList<ItemPartyTypeView>(_connectionString, "dbo.ItemPartyType_GetById", param).FirstOrDefault<ItemPartyTypeView>();

            return data;
        }

    }
}
