using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using VirtualCommunityLibrary.Models;

namespace VirtualCommunityLibrary.Helper
{
    public static class GetLoggedInUserInfo
    {
        public static string GetUserName(string loggedInUser) {
            string userName = "";
            try
            {
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                var user = manager.FindById(loggedInUser);
                ApplicationUser EmpUser = user;
                userName = (string.IsNullOrEmpty(EmpUser.Id) ? "NA" : EmpUser.Id);
            }
            catch (System.Exception)
            {
                userName = "NA";
            }

            return userName;
        }

        public static int GetLibraryID(string loggedInUser)
        {
            int libraryID = 0;
            try
            {
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                var user = manager.FindById(loggedInUser);
                ApplicationUser EmpUser = user;
                libraryID = (EmpUser.LibraryID > 0 ? EmpUser.LibraryID  :   1);
            }
            catch (System.Exception)
            {
                libraryID = 1;
            }

            return libraryID;
        }
      

    }
}