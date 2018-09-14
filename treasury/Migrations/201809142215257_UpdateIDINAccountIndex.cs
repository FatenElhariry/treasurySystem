namespace treasury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIDINAccountIndex : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Dom.AccountIndex", "ParentId", "Dom.AccountIndex");
            DropPrimaryKey("Dom.AccountIndex");
            AlterColumn("Dom.AccountIndex", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("Dom.AccountIndex", "Id");
            AddForeignKey("Dom.AccountIndex", "ParentId", "Dom.AccountIndex", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Dom.AccountIndex", "ParentId", "Dom.AccountIndex");
            DropPrimaryKey("Dom.AccountIndex");
            AlterColumn("Dom.AccountIndex", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("Dom.AccountIndex", "Id");
            AddForeignKey("Dom.AccountIndex", "ParentId", "Dom.AccountIndex", "Id");
        }
    }
}
