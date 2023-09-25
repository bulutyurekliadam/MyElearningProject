namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_course_Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseDescription", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "CourseDescription");
        }
    }
}
