namespace demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMessage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserMes", "PassWord", c => c.String(nullable: false));
            AlterColumn("dbo.UserMes", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.UserMes", "UserName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserMes", "UserName", c => c.String());
            AlterColumn("dbo.UserMes", "Email", c => c.String());
            DropColumn("dbo.UserMes", "PassWord");
        }
    }
}
