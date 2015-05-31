namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConfirmPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserMessages", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserMessages", "ConfirmPassword");
        }
    }
}
