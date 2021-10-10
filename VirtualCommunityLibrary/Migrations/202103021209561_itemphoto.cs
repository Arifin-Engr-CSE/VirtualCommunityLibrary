namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemphoto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemPhotoes",
                c => new
                    {
                        PhotoID = c.Int(nullable: false, identity: true),
                        PhotoURL = c.String(maxLength: 2000),
                        PhotoBinary = c.Binary(),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100),
                        ModifiedOn = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 100),
                        ItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhotoID)
                .ForeignKey("dbo.Items", t => t.ItemID, cascadeDelete: true)
                .Index(t => t.ItemID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemPhotoes", "ItemID", "dbo.Items");
            DropIndex("dbo.ItemPhotoes", new[] { "ItemID" });
            DropTable("dbo.ItemPhotoes");
        }
    }
}
