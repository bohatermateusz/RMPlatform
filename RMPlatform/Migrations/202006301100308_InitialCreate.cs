namespace RMPlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConfidentialInformations",
                c => new
                    {
                        ConfidentialInformationsID = c.Int(nullable: false, identity: true),
                        NameOfConfidentialInformation = c.String(),
                        RiskLevel = c.Int(nullable: false),
                        Impact = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ConfidentialInformationsID);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        ConfidentialInformations_ConfidentialInformationsID = c.Int(),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.ConfidentialInformations", t => t.ConfidentialInformations_ConfidentialInformationsID)
                .ForeignKey("dbo.Department", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.EmployeeID)
                .Index(t => t.ConfidentialInformations_ConfidentialInformationsID);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        DataInputDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Enrollment", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.Enrollment", "ConfidentialInformations_ConfidentialInformationsID", "dbo.ConfidentialInformations");
            DropIndex("dbo.Enrollment", new[] { "ConfidentialInformations_ConfidentialInformationsID" });
            DropIndex("dbo.Enrollment", new[] { "EmployeeID" });
            DropIndex("dbo.Enrollment", new[] { "DepartmentID" });
            DropTable("dbo.Employee");
            DropTable("dbo.Department");
            DropTable("dbo.Enrollment");
            DropTable("dbo.ConfidentialInformations");
        }
    }
}
