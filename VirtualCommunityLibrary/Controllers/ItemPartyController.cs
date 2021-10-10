using DataAccessLayer;
using DataViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
using VirtualCommunityLibrary.Helper;


namespace VirtualCommunityLibrary.Controllers
{
    [Authorize]
    public class ItemPartyController : Controller
    {

        string connectionString = ReadConnectionString.Read();

        public ActionResult GetAll()
        {
            int libraryLocationId = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemPartyData = new ItemPartyData(connectionString);
            var itemParty = itemPartyData.GetAllItemParty(libraryLocationId);

            return View(itemParty);
        }

        [HttpGet]
        public ActionResult Add()
        {
            int libraryLocationId = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            ItemPartyViewForAddEdit itemParty = new ItemPartyViewForAddEdit();
            itemParty.LibraryLocationID = libraryLocationId;
            var itemPartyTypeData = new ItemPartyTypeData(connectionString);
            itemParty.PartyType = itemPartyTypeData.GetAllItemPartyTypeForALibrary(libraryLocationId).ToList();

            return View(itemParty);
        }

        [HttpPost]
        public ActionResult Add(ItemParty itemParty)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemParty.CreatedBy = loggedInUser;
            itemParty.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemPartyData = new ItemPartyData(connectionString);
                itemPartyData.AddOrEdit(itemParty);
            }


            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            ItemPartyViewForAddEdit itemParty = null;

            if (id != 0)
            {
                var itemPartyData = new ItemPartyData(connectionString);
                var itemPartyTypeData = new ItemPartyTypeData(connectionString);
                itemParty = itemPartyData.GetSinglePartyForEdit(id);
                itemParty.PartyType = itemPartyTypeData.GetAllItemPartyTypeForALibrary(itemParty.LibraryLocationID).ToList();
            }

            return View(itemParty);
        }

        [HttpPost]
        public ActionResult Edit(ItemParty itemParty)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemParty.CreatedBy = loggedInUser;
            itemParty.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemPartyData = new ItemPartyData(connectionString);
                itemPartyData.AddOrEdit(itemParty);
            }

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Details(int? id)
        {

            ItemParty itemParty = null;

            if (id != 0)
            {
                var itemPartyData = new ItemPartyData(connectionString);
                itemParty = itemPartyData.GetSinglePartyForView(id);
            }

            return View(itemParty);
        }


        //public ActionResult Delete(int? id)
        //{

        //    if (id != 0)
        //    {
        //        ItemParty = db.itemParties.Where(x => x.ItemPartyID == id).FirstOrDefault();

        //        db.itemParties.Remove(ItemParty);
        //        db.SaveChanges();

        //    }

        //    return RedirectToAction("GetAll");
        //}
    }
}