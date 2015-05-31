namespace demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyTel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserMes", "Tel", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserMes", "Tel", c => c.Int(nullable: false));
        }
    }
}
