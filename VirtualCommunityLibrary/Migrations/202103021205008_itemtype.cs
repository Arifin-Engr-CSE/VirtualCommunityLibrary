namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemtype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemTypeName = c.String(nullable: false, maxLength: 50),
                        TypeDescription = c.String(maxLength: 1000),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100),
                        ModifiedOn = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemTypes");
        }
    }
}
