namespace ExcelOpertationInMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingAccesslog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccessLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                        Name = c.String(),
                        EmployeeID = c.Int(nullable: false),
                        Mode = c.String(),
                        CardSerialNo = c.String(),
                        Result = c.String(),
                        ExternalDevice = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccessLogs");
        }
    }
}
