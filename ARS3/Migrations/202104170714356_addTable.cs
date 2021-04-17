namespace ARS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblAdminLogin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        AName = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.TblFlightBook",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        From = c.String(nullable: false, maxLength: 40),
                        DDate = c.DateTime(nullable: false),
                        DTime = c.String(maxLength: 15),
                        Planeid = c.Int(nullable: false),
                        SeatType = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.bid)
                .ForeignKey("dbo.AeroPlaneInfoes", t => t.Planeid, cascadeDelete: true)
                .Index(t => t.Planeid);
            
            CreateTable(
                "dbo.AeroPlaneInfoes",
                c => new
                    {
                        Planeid = c.Int(nullable: false, identity: true),
                        APlaneName = c.String(nullable: false, maxLength: 30),
                        SeatingCapacity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Planeid);
            
            CreateTable(
                "dbo.TblUserAccount",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 40),
                        Email = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 20),
                        CPassword = c.String(maxLength: 20),
                        Age = c.String(nullable: false),
                        Phoneno = c.String(nullable: false, maxLength: 10),
                        NIC = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblFlightBook", "Planeid", "dbo.AeroPlaneInfoes");
            DropIndex("dbo.TblFlightBook", new[] { "Planeid" });
            DropTable("dbo.TblUserAccount");
            DropTable("dbo.AeroPlaneInfoes");
            DropTable("dbo.TblFlightBook");
            DropTable("dbo.TblAdminLogin");
        }
    }
}
