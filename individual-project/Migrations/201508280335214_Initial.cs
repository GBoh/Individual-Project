namespace Individual_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventType = c.String(),
                        MFTFormSubmission_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MFTFormSubmissions", t => t.MFTFormSubmission_Id)
                .Index(t => t.MFTFormSubmission_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupLocation = c.String(),
                        MFTFormSubmission_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MFTFormSubmissions", t => t.MFTFormSubmission_Id)
                .Index(t => t.MFTFormSubmission_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.MFTFormSubmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        StartTime = c.DateTime(),
                        ClockHours = c.DateTime(),
                        SupervisorInitials = c.String(),
                        Comments = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ObservableDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ObservableDataType = c.String(),
                        MFTFormSubmission_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MFTFormSubmissions", t => t.MFTFormSubmission_Id)
                .Index(t => t.MFTFormSubmission_Id);
            
            CreateTable(
                "dbo.Supervisors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupervisorType = c.String(),
                        MFTFormSubmission_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MFTFormSubmissions", t => t.MFTFormSubmission_Id)
                .Index(t => t.MFTFormSubmission_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.MFTFormSubmissions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Supervisors", "MFTFormSubmission_Id", "dbo.MFTFormSubmissions");
            DropForeignKey("dbo.ObservableDatas", "MFTFormSubmission_Id", "dbo.MFTFormSubmissions");
            DropForeignKey("dbo.Groups", "MFTFormSubmission_Id", "dbo.MFTFormSubmissions");
            DropForeignKey("dbo.Events", "MFTFormSubmission_Id", "dbo.MFTFormSubmissions");
            DropIndex("dbo.Supervisors", new[] { "MFTFormSubmission_Id" });
            DropIndex("dbo.ObservableDatas", new[] { "MFTFormSubmission_Id" });
            DropIndex("dbo.MFTFormSubmissions", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "Group_Id" });
            DropIndex("dbo.Groups", new[] { "MFTFormSubmission_Id" });
            DropIndex("dbo.Events", new[] { "MFTFormSubmission_Id" });
            DropTable("dbo.Supervisors");
            DropTable("dbo.ObservableDatas");
            DropTable("dbo.MFTFormSubmissions");
            DropTable("dbo.Users");
            DropTable("dbo.Groups");
            DropTable("dbo.Events");
        }
    }
}
