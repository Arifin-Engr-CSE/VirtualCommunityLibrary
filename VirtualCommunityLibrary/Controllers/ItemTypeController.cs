using DataAccessLayer;
using DataViewModels;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using VirtualCommunityLibrary.Helper;


namespace VirtualCommunityLibrary.Controllers
{
    [Authorize]
    public class ItemTypeController : Controller
    {

        string connectionString = ReadConnectionString.Read();
        // GET: ItemType
        public ActionResult GetAll()
        {
            int libraryLocationId = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemTypeData = new ItemTypeData(connectionString);
            var itemType = itemTypeData.GetAllItemTypeForALibrary(libraryLocationId);
               
            return View(itemType);           
        }

        [HttpGet]
        public ActionResult Add()
        {
            var librayLocationId = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var newItemType = new ItemType
            {
                LibraryLocationID = librayLocationId
            };


            return View(newItemType);
        }

        [HttpPost]
        public ActionResult Add(ItemType itemType)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemType.CreatedBy = loggedInUser;
            itemType.ModifiedBy = loggedInUser;
 
            if (ModelState.IsValid)
            {
                var itemTypeData = new ItemTypeData(connectionString);
                itemTypeData.AddOrEdit(itemType);
            }


            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var itemTypeData = new ItemTypeData(connectionString);
            var itemType = itemTypeData.GetSingleItemTypeForViewOrEdit(id);

            return View(itemType);
        }

        [HttpPost]
        public ActionResult Edit(ItemType itemType)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemType.ModifiedBy = loggedInUser;

            if (itemType.ID != 0)
            {
                if (ModelState.IsValid)
                {
                    var itemTypeData = new ItemTypeData(connectionString);
                    itemTypeData.AddOrEdit(itemType);
                }
            }

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Details(int? id)
        {
            var itemTypeData = new ItemTypeData(connectionString);
            var itemType = itemTypeData.GetSingleItemTypeForViewOrEdit(id);
 

            return View(itemType);
        }


        //public ActionResult Delete(int? id)
        //{

        //    if (id != 0)
        //    {
        //        ItemType = db.itemTypes.Where(x => x.ID == id).FirstOrDefault();

        //        db.itemTypes.Remove(ItemType);
        //        db.SaveChanges();

        //    }

        //    return RedirectToAction("GetAll");
        //}
    }
}
