namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemborrohistories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemBorrowHistories",
                c => new
                    {
                        ItemBorrowID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(),
                        ItemPartyID = c.Int(),
                        LibraryLocationID = c.Int(),
                        BorrowDate = c.DateTime(),
                        BorrowedForHowManyDays = c.Int(nullable: false),
                        ReturnDate = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100),
                        ModifiedOn = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 100),
                        ItemBorrowDayCountID = c.Int(),
                    })
                .PrimaryKey(t => t.ItemBorrowID)
                .ForeignKey("dbo.Items", t => t.ItemID)
                .ForeignKey("dbo.ItemBorrowDayCounts", t => t.ItemBorrowDayCountID)
                .ForeignKey("dbo.ItemLibraryLocations", t => t.LibraryLocationID)
                .ForeignKey("dbo.ItemParties", t => t.ItemPartyID)
                .Index(t => t.ItemID)
                .Index(t => t.ItemPartyID)
                .Index(t => t.LibraryLocationID)
                .Index(t => t.ItemBorrowDayCountID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemBorrowHistories", "ItemPartyID", "dbo.ItemParties");
            DropForeignKey("dbo.ItemBorrowHistories", "LibraryLocationID", "dbo.ItemLibraryLocations");
            DropForeignKey("dbo.ItemBorrowHistories", "ItemBorrowDayCountID", "dbo.ItemBorrowDayCounts");
            DropForeignKey("dbo.ItemBorrowHistories", "ItemID", "dbo.Items");
            DropIndex("dbo.ItemBorrowHistories", new[] { "ItemBorrowDayCountID" });
            DropIndex("dbo.ItemBorrowHistories", new[] { "LibraryLocationID" });
            DropIndex("dbo.ItemBorrowHistories", new[] { "ItemPartyID" });
            DropIndex("dbo.ItemBorrowHistories", new[] { "ItemID" });
            DropTable("dbo.ItemBorrowHistories");
        }
    }
}
