using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
    public class AllBookCount
    {
        public int TotalBookCount { get; set; }
        public int CurrentlyAvailableBookCount { get; set; }
        public int TotalBorrowed { get; set; }
        public int CurrentlyBorrowed { get; set; }


    }
}