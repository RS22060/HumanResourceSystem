namespace HumanResourceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTeamEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lead_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.TeamId)
                .ForeignKey("dbo.Employees", t => t.Lead_EmployeeId)
                .Index(t => t.Lead_EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Lead_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Teams", new[] { "Lead_EmployeeId" });
            DropTable("dbo.Teams");
        }
    }
}
