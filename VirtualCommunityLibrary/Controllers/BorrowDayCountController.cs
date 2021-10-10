using DataAccessLayer;
using DataViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Web.Mvc;
using VirtualCommunityLibrary.Helper;


namespace VirtualCommunityLibrary.Controllers
{
    [Authorize]
    public class BorrowDayCountController : Controller
    {
        string connectionString = ReadConnectionString.Read();

        public ActionResult GetAll()
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemBorrowDayCountData = new ItemBorrowDayCountData(connectionString);
            var itemBorrowDayCount = itemBorrowDayCountData.GetItemBorrowDaysForALibrary(libraryLocationID.ToString());

            return View(itemBorrowDayCount);
        }

        [HttpGet]
        public ActionResult Add()
        {

            ItemBorrowDayCountView itemBorrowDayCount = new ItemBorrowDayCountView();
            return View(itemBorrowDayCount);
        }

        [HttpPost]
        public ActionResult Add(ItemBorrowDayCount itemBorrowDayCount)
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemBorrowDayCount.LibraryLocationID = libraryLocationID;
            itemBorrowDayCount.CreatedBy = loggedInUser;
            itemBorrowDayCount.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemBorrowDayCountData = new ItemBorrowDayCountData(connectionString);
                itemBorrowDayCountData.AddOrEdit(itemBorrowDayCount);
            }


            return RedirectToAction("GetAll");
        }
    }
}