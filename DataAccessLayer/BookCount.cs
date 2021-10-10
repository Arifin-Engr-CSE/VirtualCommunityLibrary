using Dapper;
using DataViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public class ItemCount
    {
        private string _connectionString;
        public ItemCount(string connectionString)
        {
            _connectionString = connectionString;
        }

        

        public IEnumerable<AllBookCount> GetAllBookStatusCount(int libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<AllBookCount>(_connectionString, "[dbo].[AllBookTypeCount]", param);
        }
    }
}
