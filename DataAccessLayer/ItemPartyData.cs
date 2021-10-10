using Dapper;
using DataViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class ItemPartyData
    {
        private string _connectionString;
        public ItemPartyData(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<ItemPartyView> GetAllItemParty(int libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemPartyView>(_connectionString, "[dbo].[ItemParty_GetAll]", param);
        }

        public ItemParty GetSinglePartyForView(int? itemPartyID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemPartyID", itemPartyID);

            var data = DataAccess.ReturnList<ItemParty>(_connectionString, "dbo.ItemParty_GetById", param).FirstOrDefault<ItemParty>();

            return data;
        }

        public ItemPartyViewForAddEdit GetSinglePartyForEdit(int? itemPartyID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemPartyID", itemPartyID);

            var data = DataAccess.ReturnList<ItemPartyViewForAddEdit>(_connectionString, "dbo.ItemParty_GetById", param).FirstOrDefault<ItemPartyViewForAddEdit>();

            return data;
        }
        public IEnumerable<ItemPartyOfALibrary> GetItemBorrowerOfALibrary(string libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemPartyOfALibrary>(_connectionString, "[dbo].[SP_ItemParty_GetLibraryBorrower]", param);
        }
        public IEnumerable<ItemPartyOfALibrary> GetItemInChargeOfALibrary(string libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemPartyOfALibrary>(_connectionString, "[dbo].[SP_ItemParty_GetLibraryManager]", param);
        }

        public IEnumerable<ItemPartyOfALibrary> GetAllItemPartyIdAndName(string libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemPartyOfALibrary>(_connectionString, "[dbo].[ItemParty_GetAll]", param);
        }

        public void AddOrEdit(ItemParty itemParty)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ItemPartyID", itemParty.ItemPartyID);
            param.Add("@PartyName", itemParty.PartyName);
            param.Add("@PartyTypeID", itemParty.PartyTypeID);
            param.Add("@LibraryLocationID", itemParty.LibraryLocationID);
            param.Add("@PartyAddress", itemParty.PartyAddress);
            param.Add("@PartyMobile", itemParty.PartyMobile);
            param.Add("@PartyNoteIfAny", itemParty.PartyNoteIfAny);
            param.Add("@CreatedBy", itemParty.CreatedBy);
            param.Add("@ModifiedBy", itemParty.ModifiedBy);

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[ItemParty_Save]", param);
        }
    }
}
