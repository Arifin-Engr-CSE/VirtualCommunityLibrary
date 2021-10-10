using Dapper;
using DataViewModels;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class ItemBorrowDayCountData
    {
        private string _connectionString;
        public ItemBorrowDayCountData(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<ItemBorrowDayCountView> GetItemBorrowDaysForALibrary(string libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<ItemBorrowDayCountView>(_connectionString, "[dbo].[ItemBorrowDayCount_GetAll]", param);
        }

        public void AddOrEdit(ItemBorrowDayCount itemBorrowDayCount)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", itemBorrowDayCount.LibraryLocationID);
            param.Add("@NumberOfDays", itemBorrowDayCount.NumberOfDays);
            param.Add("@CreatedBy", itemBorrowDayCount.CreatedBy);
            param.Add("@ModifiedBy", itemBorrowDayCount.ModifiedBy);
            

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[ItemBorrowDayCount_Save]", param);
        }

    }
}
