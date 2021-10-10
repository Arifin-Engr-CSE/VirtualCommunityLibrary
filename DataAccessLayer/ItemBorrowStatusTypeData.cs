using Dapper;
using DataViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class ItemBorrowStatusTypeData
    {
        private string _connectionString;
        public ItemBorrowStatusTypeData(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<ItemBorrowStatusView> GetAllIBorrowStatusTypeForALibrary(int? libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemBorrowStatusView>(_connectionString, "[dbo].[ItemBorrowStatus_GetAll]", param);
        }


        public void AddOrEdit(ItemBorrowStatus itemBorrowStatus)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@BorrowStatusID", itemBorrowStatus.BorrowStatusID);
            param.Add("@BorrowStatus", itemBorrowStatus.BorrowStatus);
            param.Add("@BorrowDescription", itemBorrowStatus.BorrowDescription);
            param.Add("@LibraryLocationID", itemBorrowStatus.LibraryLocationID);
            param.Add("@CreatedBy", itemBorrowStatus.CreatedBy);
            param.Add("@ModifiedBy", itemBorrowStatus.ModifiedBy);

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[ItemBorrowStatus_Save]", param);
        }

        public int GetItemBorrowStatusID(int? libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ExecuteReturnScalar<int>(_connectionString, "[dbo].[SP_ItemBorrowStatus_GetIdForBorrow]", param);
        }
    }
}
