using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VirtualCommunityLibrary.Models;

namespace VirtualCommunityLibrary.DatabaseContext
{
    public class LibraryDbContext : DbContext
    {


        public DbSet<ItemType> itemTypes { get; set; }

        public DbSet<ItemPartyType> itemPartyTypes { get; set; }

        public DbSet<ItemParty> itemParties { get; set; }

        public DbSet<ItemLibraryLocation> itemLibraryLocations { get; set; }

        public DbSet<ItemBorrowStatus> itemBorrowStatuses { get; set; }

        public DbSet<ItemBorrowDayCount> itemBorrowDayCounts { get; set; }

        public DbSet<Item> items { get; set; }

        public DbSet<ItemPhoto> itemPhotos { get; set; }

        public DbSet<ItemBorrowHistory> itemBorrowHistories { get; set; }

    }
}