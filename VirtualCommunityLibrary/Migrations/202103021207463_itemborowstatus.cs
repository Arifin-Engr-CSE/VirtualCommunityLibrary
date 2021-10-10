namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemborowstatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemBorrowStatus",
                c => new
                    {
                        ItemBorrowStatusID = c.Int(nullable: false, identity: true),
                        BorrowStatus = c.String(nullable: false, maxLength: 50),
                        BorrowDescription = c.String(nullable: false, maxLength: 1000),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100),
                        ModifiedOn = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 100),
                        ItemTypeID = c.Int(nullable: false),
                        LibraryLocationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemBorrowStatusID)
                .ForeignKey("dbo.ItemLibraryLocations", t => t.LibraryLocationID, cascadeDelete: true)
                .ForeignKey("dbo.ItemTypes", t => t.ItemTypeID, cascadeDelete: true)
                .Index(t => t.ItemTypeID)
                .Index(t => t.LibraryLocationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemBorrowStatus", "ItemTypeID", "dbo.ItemTypes");
            DropForeignKey("dbo.ItemBorrowStatus", "LibraryLocationID", "dbo.ItemLibraryLocations");
            DropIndex("dbo.ItemBorrowStatus", new[] { "LibraryLocationID" });
            DropIndex("dbo.ItemBorrowStatus", new[] { "ItemTypeID" });
            DropTable("dbo.ItemBorrowStatus");
        }
    }
}
