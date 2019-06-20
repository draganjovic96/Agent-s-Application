namespace AgentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accommodations",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        AccommodationType = c.Int(nullable: false),
                        Address_id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Addresses", t => t.Address_id, cascadeDelete: true)
                .Index(t => t.Address_id);
            
            CreateTable(
                "dbo.AccommodationUnits",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Floor = c.Int(nullable: false),
                        Number = c.String(nullable: false),
                        NumberOfBeds = c.Int(nullable: false),
                        DefaultPrice = c.Double(nullable: false),
                        Accommodation_id = c.Long(nullable: false),
                        AccommodationUnitType_id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accommodations", t => t.Accommodation_id, cascadeDelete: true)
                .ForeignKey("dbo.AccommodationUnitTypes", t => t.AccommodationUnitType_id, cascadeDelete: true)
                .Index(t => t.Accommodation_id)
                .Index(t => t.AccommodationUnitType_id);
            
            CreateTable(
                "dbo.AccommodationUnitTypes",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PeriodPrices",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Pice = c.Double(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        AccommodationUnit_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccommodationUnits", t => t.AccommodationUnit_Id)
                .Index(t => t.AccommodationUnit_Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Confirmed = c.Boolean(nullable: false),
                        AgentConfirmed = c.Boolean(nullable: false),
                        AccommodationUnit_Id = c.Long(nullable: false),
                        CommentRate_Id = c.Long(),
                        Guest_id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccommodationUnits", t => t.AccommodationUnit_Id, cascadeDelete: true)
                .ForeignKey("dbo.CommentRates", t => t.CommentRate_Id)
                .ForeignKey("dbo.Users", t => t.Guest_id)
                .Index(t => t.AccommodationUnit_Id)
                .Index(t => t.CommentRate_Id)
                .Index(t => t.Guest_id);
            
            CreateTable(
                "dbo.CommentRates",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ApprovedComment = c.Boolean(nullable: false),
                        ContentOfComment = c.String(),
                        CommentDateTime = c.DateTime(nullable: false),
                        Ocena = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        lastname = c.String(nullable: false),
                        email = c.String(maxLength: 50),
                        username = c.String(maxLength: 50),
                        password = c.String(nullable: false),
                        enabled = c.Boolean(nullable: false),
                        deleted = c.Boolean(nullable: false),
                        role = c.Int(nullable: false),
                        businessRegistrationNumber = c.Long(nullable: false),
                        blocked = c.Boolean(nullable: false),
                        address_id = c.Long(nullable: false),
                        AgentOfAccommodation_id = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Addresses", t => t.address_id, cascadeDelete: true)
                .ForeignKey("dbo.Accommodations", t => t.AgentOfAccommodation_id)
                .Index(t => t.email, unique: true)
                .Index(t => t.username, unique: true)
                .Index(t => t.address_id)
                .Index(t => t.AgentOfAccommodation_id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        country = c.String(nullable: false),
                        city = c.String(nullable: false),
                        postalCode = c.Int(nullable: false),
                        street = c.String(nullable: false),
                        number = c.String(nullable: false),
                        apartmentNumber = c.String(),
                        longitude = c.Double(nullable: false),
                        latitude = c.Double(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        MessageContent = c.String(),
                        Seen = c.Boolean(nullable: false),
                        DatumVreme = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Accommodation_id = c.Long(),
                        Receiver_id = c.Long(),
                        Reservation_Id = c.Long(),
                        Sender_id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accommodations", t => t.Accommodation_id)
                .ForeignKey("dbo.Users", t => t.Receiver_id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .ForeignKey("dbo.Users", t => t.Sender_id)
                .Index(t => t.Accommodation_id)
                .Index(t => t.Receiver_id)
                .Index(t => t.Reservation_Id)
                .Index(t => t.Sender_id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Img = c.Byte(nullable: false),
                        Accommodation_id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accommodations", t => t.Accommodation_id)
                .Index(t => t.Accommodation_id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceAccommodations",
                c => new
                    {
                        Service_Id = c.Long(nullable: false),
                        Accommodation_id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_Id, t.Accommodation_id })
                .ForeignKey("dbo.Services", t => t.Service_Id, cascadeDelete: true)
                .ForeignKey("dbo.Accommodations", t => t.Accommodation_id, cascadeDelete: true)
                .Index(t => t.Service_Id)
                .Index(t => t.Accommodation_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceAccommodations", "Accommodation_id", "dbo.Accommodations");
            DropForeignKey("dbo.ServiceAccommodations", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Images", "Accommodation_id", "dbo.Accommodations");
            DropForeignKey("dbo.Accommodations", "Address_id", "dbo.Addresses");
            DropForeignKey("dbo.Messages", "Sender_id", "dbo.Users");
            DropForeignKey("dbo.Messages", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Messages", "Receiver_id", "dbo.Users");
            DropForeignKey("dbo.Messages", "Accommodation_id", "dbo.Accommodations");
            DropForeignKey("dbo.Reservations", "Guest_id", "dbo.Users");
            DropForeignKey("dbo.Users", "AgentOfAccommodation_id", "dbo.Accommodations");
            DropForeignKey("dbo.Users", "address_id", "dbo.Addresses");
            DropForeignKey("dbo.Reservations", "CommentRate_Id", "dbo.CommentRates");
            DropForeignKey("dbo.Reservations", "AccommodationUnit_Id", "dbo.AccommodationUnits");
            DropForeignKey("dbo.PeriodPrices", "AccommodationUnit_Id", "dbo.AccommodationUnits");
            DropForeignKey("dbo.AccommodationUnits", "AccommodationUnitType_id", "dbo.AccommodationUnitTypes");
            DropForeignKey("dbo.AccommodationUnits", "Accommodation_id", "dbo.Accommodations");
            DropIndex("dbo.ServiceAccommodations", new[] { "Accommodation_id" });
            DropIndex("dbo.ServiceAccommodations", new[] { "Service_Id" });
            DropIndex("dbo.Images", new[] { "Accommodation_id" });
            DropIndex("dbo.Messages", new[] { "Sender_id" });
            DropIndex("dbo.Messages", new[] { "Reservation_Id" });
            DropIndex("dbo.Messages", new[] { "Receiver_id" });
            DropIndex("dbo.Messages", new[] { "Accommodation_id" });
            DropIndex("dbo.Users", new[] { "AgentOfAccommodation_id" });
            DropIndex("dbo.Users", new[] { "address_id" });
            DropIndex("dbo.Users", new[] { "username" });
            DropIndex("dbo.Users", new[] { "email" });
            DropIndex("dbo.Reservations", new[] { "Guest_id" });
            DropIndex("dbo.Reservations", new[] { "CommentRate_Id" });
            DropIndex("dbo.Reservations", new[] { "AccommodationUnit_Id" });
            DropIndex("dbo.PeriodPrices", new[] { "AccommodationUnit_Id" });
            DropIndex("dbo.AccommodationUnits", new[] { "AccommodationUnitType_id" });
            DropIndex("dbo.AccommodationUnits", new[] { "Accommodation_id" });
            DropIndex("dbo.Accommodations", new[] { "Address_id" });
            DropTable("dbo.ServiceAccommodations");
            DropTable("dbo.Services");
            DropTable("dbo.Images");
            DropTable("dbo.Messages");
            DropTable("dbo.Addresses");
            DropTable("dbo.Users");
            DropTable("dbo.CommentRates");
            DropTable("dbo.Reservations");
            DropTable("dbo.PeriodPrices");
            DropTable("dbo.AccommodationUnitTypes");
            DropTable("dbo.AccommodationUnits");
            DropTable("dbo.Accommodations");
        }
    }
}
