namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addcontactbool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "IsRead", c => c.Boolean(nullable: false));
            AddColumn("dbo.Contacts", "IsImportant", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "IsImportant");
            DropColumn("dbo.Contacts", "IsRead");
        }
    }
}
