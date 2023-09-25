namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseDescription", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "CourseDescription", c => c.Int(nullable: false));
        }
    }
}
