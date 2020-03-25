namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Course", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Students", "StudentFirstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "StudentFirstName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Students", "Course");
        }
    }
}
