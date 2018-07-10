namespace treasury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountIndexData1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("Dom.AccountIndex", new[] { "ParentId" });
            AddColumn("Dom.AccountIndex", "EnName", c => c.String());
            AlterColumn("Dom.AccountIndex", "ParentId", c => c.Int());
            CreateIndex("Dom.AccountIndex", "ParentId");
        }
        
        public override void Down()
        {
            DropIndex("Dom.AccountIndex", new[] { "ParentId" });
            AlterColumn("Dom.AccountIndex", "ParentId", c => c.Int(nullable: false));
            DropColumn("Dom.AccountIndex", "EnName");
            CreateIndex("Dom.AccountIndex", "ParentId");
        }
    }
}
