namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOldPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserMessages", "OldPassword", c => c.String(maxLength: 32));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserMessages", "OldPassword");
        }
    }
}
