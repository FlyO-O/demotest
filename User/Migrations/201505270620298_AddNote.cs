namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNote : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserMessages", "UserName", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.UserMessages", "PassWord", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserMessages", "PassWord", c => c.String());
            AlterColumn("dbo.UserMessages", "UserName", c => c.String());
        }
    }
}
