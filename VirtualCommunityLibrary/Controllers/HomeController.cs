using Dapper;
using DataAccessLayer;
using DataViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualCommunityLibrary.DatabaseContext;
using VirtualCommunityLibrary.Helper;
using VirtualCommunityLibrary.Models;

namespace VirtualCommunityLibrary.Controllers
{
   
    [Authorize]

   
    public class HomeController : Controller
    {
        readonly string connectionString = ReadConnectionString.Read();
        private IDbConnection dbConnection;
        private object itemOrBookData;
        private string _connectionString;
       
        //this 
        public ActionResult Index()
        {

            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemOrBookData = new ItemCount(connectionString);
            var itemOrBooks = itemOrBookData.GetAllBookStatusCount(libraryLocationID).FirstOrDefault();
            string Name= LibaName();
            ViewBag.LibName = Name;
            return View(itemOrBooks);

        }

        public string LibaName()
        {

            int libraryLocationID = GetLoggedInUserInfo.GetLibraryID(User.Identity.GetUserId());
            var itemOrBookData = new LibName(connectionString);
            var LibLOcName = itemOrBookData.GetLibName(libraryLocationID);
            return LibLOcName.ToString();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}