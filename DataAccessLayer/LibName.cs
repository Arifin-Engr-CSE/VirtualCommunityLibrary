using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
   public class LibName
    {
        private string _connectionString;
        public LibName(string connectionString)
        {
            _connectionString = connectionString;
        }



        public IEnumerable<LibraryLocationNameInfo> GetLibName(int libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);
            return DataAccess.ReturnList<LibraryLocationNameInfo>(_connectionString, "[dbo].[sp_LibraryLocationName]", param);
        }
    }
}
