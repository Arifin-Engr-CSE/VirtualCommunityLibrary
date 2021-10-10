using DataAccessLayer;
using DataViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
using VirtualCommunityLibrary.Helper;

namespace VirtualCommunityLibrary.Controllers
{
    [Authorize]
    public class LibraryLocationController : Controller
    {

        string connectionString = ReadConnectionString.Read();

        // GET: ItemBorrowStatus
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var librayLocationId = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var libraryLocationData = new ItemLibraryLocationData(connectionString);
            var libraryLocations = libraryLocationData.GetAllLibraryLocation(librayLocationId);

            return View(libraryLocations);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var librayLocationId = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());

            var itemPartyData = new ItemPartyData(connectionString);
            var itemParty = itemPartyData.GetItemInChargeOfALibrary(librayLocationId.ToString());
            var itemLibraryLocationWithInCharge = new ItemLibraryLocationViewForAddEdit
            {
                LibraryLocationManagerList = itemParty.ToList()
            };


            return View(itemLibraryLocationWithInCharge);

        }

        [HttpPost]
        public ActionResult Add(ItemLibraryLocation itemLibraryLocation)
        {
            var librayLocationId = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemLibraryLocation.LibraryLocationID = librayLocationId; //New LibraryLocation
            itemLibraryLocation.CreatedBy = loggedInUser;
            itemLibraryLocation.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var libraryLocationData = new ItemLibraryLocationData(connectionString);
                libraryLocationData.AddOrEdit(itemLibraryLocation);
            }


            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var libraryLocationData = new ItemLibraryLocationData(connectionString);
            var itemPartyData = new ItemPartyData(connectionString);
            ItemLibraryLocationViewForAddEdit libraryLocation = null;

            if (id != 0)
            {
                libraryLocation=libraryLocationData.GetSingleLibraryLocationForEdit(id).FirstOrDefault();
                var itemParty = itemPartyData.GetItemInChargeOfALibrary(id.ToString());
                libraryLocation.LibraryLocationManagerList = itemParty.ToList();

            }

            return View(libraryLocation);
        }

        [HttpPost]
        public ActionResult Edit(ItemLibraryLocation itemLibraryLocation)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemLibraryLocation.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var libraryLocationData = new ItemLibraryLocationData(connectionString);
                libraryLocationData.AddOrEdit(itemLibraryLocation);
            }

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Details(int? id)
        {
            var libraryLocationData = new ItemLibraryLocationData(connectionString);

            ItemLibraryLocation libraryLocation = null; 

            if (id != 0)
            {
                libraryLocation = libraryLocationData.GetSingleLibraryLocationForView(id).FirstOrDefault();
            }

            return View(libraryLocation);
        }


        //public ActionResult Delete(int? id)
        //{

        //    if (id != 0)
        //    {
        //        ItemLibraryLocation = db.itemLibraryLocations.Where(x => x.LibraryLocationID == id).FirstOrDefault();

        //        db.itemLibraryLocations.Remove(ItemLibraryLocation);
        //        db.SaveChanges();

        //    }

        //    return RedirectToAction("GetAll");
        //}
    }
}