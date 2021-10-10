using Dapper;
using DataViewModels;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class ItemLibraryLocationData
    {
        private string _connectionString;
        public ItemLibraryLocationData(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<ItemLibraryLocationViewForListing> GetAllLibraryLocation(int? libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);

            return DataAccess.ReturnList<ItemLibraryLocationViewForListing>(_connectionString, "[dbo].[ItemLibraryLocation_GetAll]", param);
        }



        public void AddOrEdit(ItemLibraryLocation libraryLocation)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocation.LibraryLocationID);
            param.Add("@LibraryLocationName", libraryLocation.LibraryLocationName);
            param.Add("@LibraryLocationAddress", libraryLocation.LibraryLocationAddress);
            param.Add("@LibraryLocationManagerID", libraryLocation.LibraryLocationManagerID);
            param.Add("@CreatedBy", libraryLocation.CreatedBy);
            param.Add("@ModifiedBy", libraryLocation.ModifiedBy);

            DataAccess.ExecuteWithoutReturn(_connectionString, "[dbo].[ItemLibraryLocation_Save]", param);
        }

        public IEnumerable<ItemLibraryLocation> GetSingleLibraryLocationForView(int? libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);

            return DataAccess.ReturnList<ItemLibraryLocation>(_connectionString, "dbo.ItemLibraryLocation_GetById", param);
        }

        public IEnumerable<ItemLibraryLocationViewForAddEdit> GetSingleLibraryLocationForEdit(int? libraryLocationID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryLocationID", libraryLocationID);

            return DataAccess.ReturnList<ItemLibraryLocationViewForAddEdit>(_connectionString, "dbo.ItemLibraryLocation_GetById", param);
        }

        public string CreateLibraryAndLibraryInChargeForInitiailRegistrationAndReturnLibraryID(string libraryName, string managerName, string managerMobile, string createdBy)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@LibraryName", libraryName);
            param.Add("@ManagerName", managerName);
            param.Add("@ManagerMobile", managerMobile);
            param.Add("@CreatedBy", createdBy);
            param.Add("@ModifiedBy", createdBy);
            return DataAccess.ExecuteReturnScalar<string>(_connectionString, "[dbo].[SP_ItemLibrarySetting_CreateForInitialRegistration]", param);
        }
       
    }
}
