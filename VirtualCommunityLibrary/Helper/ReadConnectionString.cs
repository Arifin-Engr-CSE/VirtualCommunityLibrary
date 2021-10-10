using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Linq;
using System.Web;

namespace VirtualCommunityLibrary.Helper
{
    public static class ReadConnectionString
    {
        public static string Read()
        {
            return WebConfigurationManager.ConnectionStrings["LibraryDbContext"].ConnectionString;
        }
    }
}