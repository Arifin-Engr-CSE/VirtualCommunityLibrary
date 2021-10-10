using DataAccessLayer;
using DataViewModels;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using VirtualCommunityLibrary.Helper;

namespace VirtualCommunityLibrary.Controllers
{
    [Authorize]
    public class ItemBorrowStatusController : Controller
    {
        string connectionString = ReadConnectionString.Read();

        public ActionResult GetAll()
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemBorrowStatusTypeData = new ItemBorrowStatusTypeData(connectionString);
            var itemBorrowStatusType = itemBorrowStatusTypeData.GetAllIBorrowStatusTypeForALibrary(libraryLocationID);

            return View(itemBorrowStatusType);
        }


        [HttpGet]
        public ActionResult Add()
        {

            ItemBorrowStatusView itemBorrowStatus = new ItemBorrowStatusView();

            return View(itemBorrowStatus);
        }

        [HttpPost]
        public ActionResult Add(ItemBorrowStatus itemBorrowStatus)
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemBorrowStatus.LibraryLocationID = libraryLocationID;
            itemBorrowStatus.CreatedBy = loggedInUser;
            itemBorrowStatus.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemBorrowStatusTypeData = new ItemBorrowStatusTypeData(connectionString);
                itemBorrowStatusTypeData.AddOrEdit(itemBorrowStatus);
            }


            return RedirectToAction("GetAll");
        }
   
    }
}