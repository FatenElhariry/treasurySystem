namespace treasury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAccountIndex : DbMigration
    {
        public override void Up()
        {
            DropColumn("Dom.AccountIndex", "IsActive");
            DropColumn("Dom.AccountIndex", "Description");
        }
        
        public override void Down()
        {
            AddColumn("Dom.AccountIndex", "Description", c => c.String());
            AddColumn("Dom.AccountIndex", "IsActive", c => c.Boolean(nullable: false));
        }
    }
}
