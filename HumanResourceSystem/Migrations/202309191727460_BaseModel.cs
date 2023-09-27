namespace HumanResourceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Manager_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.DepartmentId)
                .ForeignKey("dbo.Employees", t => t.Manager_EmployeeId)
                .Index(t => t.Manager_EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        HireDate = c.DateTime(nullable: false),
                        Department_DepartmentId = c.Int(),
                        Department_DepartmentId1 = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId1)
                .Index(t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId1);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "Manager_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Department_DepartmentId1", "dbo.Departments");
            DropForeignKey("dbo.Employees", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_DepartmentId1" });
            DropIndex("dbo.Employees", new[] { "Department_DepartmentId" });
            DropIndex("dbo.Departments", new[] { "Manager_EmployeeId" });
            DropTable("dbo.Users");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
