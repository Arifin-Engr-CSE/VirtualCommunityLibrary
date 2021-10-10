namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemborrowdaycout : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemBorrowDayCounts",
                c => new
                    {
                        ItemBorrowDayCountID = c.Int(nullable: false, identity: true),
                        LibraryLocationID = c.Int(nullable: false),
                        NumberOfDays = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemBorrowDayCountID)
                .ForeignKey("dbo.ItemLibraryLocations", t => t.LibraryLocationID, cascadeDelete: true)
                .Index(t => t.LibraryLocationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemBorrowDayCounts", "LibraryLocationID", "dbo.ItemLibraryLocations");
            DropIndex("dbo.ItemBorrowDayCounts", new[] { "LibraryLocationID" });
            DropTable("dbo.ItemBorrowDayCounts");
        }
    }
}
