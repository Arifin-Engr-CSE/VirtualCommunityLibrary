namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemphotoup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemPhotoes", "PhotoPriority", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemPhotoes", "PhotoPriority");
        }
    }
}
