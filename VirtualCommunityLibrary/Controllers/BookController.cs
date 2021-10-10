using Dapper;
using DataAccessLayer;
using DataViewModels;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using VirtualCommunityLibrary.Helper;

namespace VirtualCommunityLibrary.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        readonly string connectionString = ReadConnectionString.Read();
        private IDbConnection dbConnection;
        public BookController(IDbConnection dbConnection)
        {

        }

        //Get : Book Count
        public ActionResult BookCount()
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var sql = "EXEC AllBookTypeCount";
            var res = dbConnection.Query<Item>(sql, new { libraryLocationID = " @LibraryLocationID" }, commandType: CommandType.StoredProcedure);
            return View(res);
        }
        // GET: Book
        public ActionResult GetAll()
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemOrBookData = new ItemOrBookData(connectionString);
            var itemOrBooks = itemOrBookData.GetAllItemOrBookForAdminListing(libraryLocationID);

            return View(itemOrBooks);
        }

        
       

        [HttpGet]
        public ActionResult Details(int? id)
        {
            var itemOrBookData = new ItemOrBookData(connectionString);

            ItemViewForDetailPage itemOrBook = null;

            if (id != 0)
            {
                itemOrBook = itemOrBookData.GetSingleItemOrBookForViewOrEdit(id);
            }

            return View(itemOrBook);
        }

        [HttpGet]
        public ActionResult ViewBooks()
        {
            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemOrBookData = new ItemOrBookData(connectionString);
            var itemOrBooks = itemOrBookData.GetAllItemOrBookBorrowReturnPage(libraryLocationID);

            return View(itemOrBooks);
        }

        [HttpGet]
        public ActionResult BookBorrow(int? bookId)
        {
            var itemOrBookData = new ItemOrBookData(connectionString);
            var itemBorrowDay = new ItemBorrowDayCountData(connectionString);
            var itemBorrower = new ItemPartyData(connectionString);
            ItemBorrowView itemBorrowView = new ItemBorrowView();

            if (bookId != 0)
            {
                var itemOrBooks = itemOrBookData.GetSingleItemOrBookForViewOrEdit(bookId);

                itemBorrowView.ItemID = itemOrBooks.ItemID;
                itemBorrowView.ItemName = itemOrBooks.ItemName;
                itemBorrowView.BorrowStatus = "Borrow";
                itemBorrowView.LibraryLocationID = itemOrBooks.LibraryLocationID;
                itemBorrowView.BorrowDay = itemBorrowDay.GetItemBorrowDaysForALibrary(itemOrBooks.LibraryLocationID.ToString()).ToList();
                itemBorrowView.PartyName = itemBorrower.GetItemBorrowerOfALibrary(itemOrBooks.LibraryLocationID.ToString()).ToList();
            }

            return PartialView("_BorrowView", itemBorrowView);
        }

        [HttpPost]
        public ActionResult BookBorrow(ItemBorrowAddEditView itemBorrowData)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemBorrowData.CreatedBy = loggedInUser;
            itemBorrowData.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemOrBookData = new ItemOrBookData(connectionString);
                itemOrBookData.AddItemOrBookBorrowData(itemBorrowData);
            }

            return RedirectToAction("ViewBooks");
        }

        [HttpGet]
        public ActionResult BookReturn(int? bookId)
        {
            var itemOrBookData = new ItemOrBookData(connectionString);
            ItemBorrowAddEditView itemReturnView = new ItemBorrowAddEditView();

            if (bookId != 0)
            {
                itemReturnView = itemOrBookData.GetLastItemOrBookBorrowHistory(bookId);
                itemReturnView.BorrowStatus = "Return";
            }

            return PartialView("_ReturnView", itemReturnView);
        }

        [HttpPost]
        public ActionResult BookReturn(ItemBorrowAddEditView itemBorrowData)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            itemBorrowData.CreatedBy = loggedInUser;
            itemBorrowData.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemOrBookData = new ItemOrBookData(connectionString);
                itemOrBookData.AddItemOrBookBorrowData(itemBorrowData);
            }

            return RedirectToAction("ViewBooks");
        }

        [HttpGet]
        public ActionResult BookHistory(int? bookId)
        {
            var itemOrBookData = new ItemOrBookData(connectionString);
            IEnumerable<ItemHistoryView> itemHistoryView = null;

            if (bookId != 0)
            {
                itemHistoryView = itemOrBookData.GetHistoryListOfAItemOrBook(bookId).ToList();
            }

            return PartialView("_HistoryView", itemHistoryView);
        }


        [HttpGet]
        public ActionResult BookPhotoAddView(int? bookId)
        {
            var itemOrBookData = new ItemOrBookData(connectionString);
            ItemPhotoAddEditView itemPhotoView = null;

            if (bookId != 0)
            {
                itemPhotoView = itemOrBookData.GetItemOrBookPrimaryPhoto(bookId);
                if (itemPhotoView.PhotoPriority == 0) itemPhotoView.PhotoPriority = 1;
            }

            return View(itemPhotoView);
        }



        [HttpPost]
        public ActionResult BookPhotoAddView(ItemPhotoAddEditView bookPhoto)
        {
            System.Web.HttpPostedFileBase file = Request.Files["ImageData"];
            //getting the byte data from photofile
            bookPhoto.PhotoBinary = GetByteDataFromPhotoFile.ConvertToBytes(file);
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());

            var itemOrBookData = new ItemOrBookData(connectionString);
            bookPhoto.CreatedBy = loggedInUser;
            bookPhoto.ModifiedBy = loggedInUser;
            itemOrBookData.AddItemOrBookPrimaryPhoto(bookPhoto);

            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public ActionResult Add()
        {
            var librayLocationId = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            ItemViewForAdd item = new ItemViewForAdd();
            item.LibraryLocationID = librayLocationId;
            item.ItemTypeID = (new ItemTypeData(connectionString)).GetItemTypeIDForABook(librayLocationId);
            
            var itemPartyData = new ItemPartyData(connectionString);
            item.ItemParty = itemPartyData.GetAllItemPartyIdAndName(librayLocationId.ToString()).ToList();


            var itemBorrowStatusData = new ItemBorrowStatusTypeData(connectionString);
            item.ItemBorrowStatusID = itemBorrowStatusData.GetItemBorrowStatusID(librayLocationId);

            return View(item);
        }

        [HttpPost]
        public ActionResult Add(Item item)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            item.CreatedBy = loggedInUser;
            item.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemData = new ItemOrBookData(connectionString);
                itemData.AddOrEdit(item);
            }


            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            ItemViewForDetailPage itemOrBook = null;

            if (id != 0)
            {
                var itemOrBookData = new ItemOrBookData(connectionString);
                itemOrBook = itemOrBookData.GetSingleItemOrBookForViewOrEdit(id);
            }

            return View(itemOrBook);

        }

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            string loggedInUser = GetLoggedInUserInfo.GetUserName(User.Identity.GetUserId());
            item.CreatedBy = loggedInUser;
            item.ModifiedBy = loggedInUser;

            if (ModelState.IsValid)
            {
                var itemData = new ItemOrBookData(connectionString);
                itemData.AddOrEdit(item);
            }

            return RedirectToAction("GetAll");
        }


    }
}