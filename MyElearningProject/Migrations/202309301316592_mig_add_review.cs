namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_review : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        CoursID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        ReviewScore = c.Int(nullable: false),
                        Course_CourseID = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Courses", t => t.Course_CourseID)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.Course_CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Reviews", "Course_CourseID", "dbo.Courses");
            DropIndex("dbo.Reviews", new[] { "Course_CourseID" });
            DropIndex("dbo.Reviews", new[] { "StudentID" });
            DropTable("dbo.Reviews");
        }
    }
}
