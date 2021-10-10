using DataAccessLayer;
using DataViewModels;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using VirtualCommunityLibrary.Helper;


namespace VirtualCommunityLibrary.Controllers
{
    [Authorize]
    public class ItemPartyTypeController : Controller
    {
        string connectionString = ReadConnectionString.Read();

        // GET: ItemBorrowStatus
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemPartyData = new ItemPartyTypeData(connectionString);
            var itemPartyType = itemPartyData.GetAllItemPartyTypeForALibrary(libraryLocationID);

            return View(itemPartyType);
        }

        [HttpGet]
        public ActionResult Add()
        {

            ItemPartyTypeView itemPartyType = new ItemPartyTypeView();

            return View(itemPartyType);
        }

        [HttpPost]
        public ActionResult Add(ItemPartyType itemPartyType)
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemPartyType.LibraryLocationID = libraryLocationID;
            itemPartyType.CreatedBy = loggedInUser;
            itemPartyType.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemPartyTypeData = new ItemPartyTypeData(connectionString);
                itemPartyTypeData.AddOrEdit(itemPartyType);
            }


            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var itemPartyTypeData = new ItemPartyTypeData(connectionString);

            ItemPartyTypeView itemPartyType = null;

            if (id != 0)
            {
                itemPartyType = itemPartyTypeData.GetSingleItemPartyTypeForViewOrEdit(id);
            }

            return View(itemPartyType);
        }

        [HttpPost]
        public ActionResult Edit(ItemPartyType itemPartyType)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemPartyType.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemPartyTypeData = new ItemPartyTypeData(connectionString);
                itemPartyTypeData.AddOrEdit(itemPartyType);
            }

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Details(int? id)
        {
            var itemPartyTypeData = new ItemPartyTypeData(connectionString);

            ItemPartyTypeView itemPartyType = null;

            if (id != 0)
            {
                itemPartyType = itemPartyTypeData.GetSingleItemPartyTypeForViewOrEdit(id);
            }

            return View(itemPartyType);
        }


        //public ActionResult Delete(int? id)
        //{

        //    if (id != 0)
        //    {
        //        ItemPartyType = db.itemPartyTypes.Where(x => x.ItemPartyTypeID == id).FirstOrDefault();

        //        db.itemPartyTypes.Remove(ItemPartyType);
        //        db.SaveChanges();

        //    }

        //    return RedirectToAction("GetAll");
        //}
    }
}