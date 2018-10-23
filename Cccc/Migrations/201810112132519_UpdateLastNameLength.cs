namespace Cccc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLastNameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
