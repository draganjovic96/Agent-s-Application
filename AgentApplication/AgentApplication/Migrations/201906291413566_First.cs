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
                        Id = c.Long(nullable: false),
                        Description = c.String(),
                        Name = c.String(),
                        Category = c.String(),
                        AccommodationType = c.Int(nullable: false),
                        Address_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.AccommodationUnits",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Floor = c.Int(nullable: false),
                        Number = c.String(nullable: false),
                        NumberOfBeds = c.Int(nullable: false),
                        DefaultPrice = c.Double(nullable: false),
                        Accommodation_Id = c.Long(nullable: false),
                        AccommodationUnitType_id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accommodations", t => t.Accommodation_Id, cascadeDelete: true)
                .ForeignKey("dbo.AccommodationUnitTypes", t => t.AccommodationUnitType_id, cascadeDelete: true)
                .Index(t => t.Accommodation_Id)
                .Index(t => t.AccommodationUnitType_id);
            
            CreateTable(
                "dbo.AccommodationUnitTypes",
                c => new
                    {
                        id = c.Long(nullable: false),
                        name = c.String(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PeriodPrices",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Pice = c.Double(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        AccommodationUnit_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccommodationUnits", t => t.AccommodationUnit_Id, cascadeDelete: true)
                .Index(t => t.AccommodationUnit_Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Long(nullable: false),
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
                        Id = c.Long(nullable: false),
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
                        id = c.Long(nullable: false),
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
                        address_Id = c.Long(nullable: false),
                        AgentOfAccommodation_Id = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Addresses", t => t.address_Id, cascadeDelete: true)
                .ForeignKey("dbo.Accommodations", t => t.AgentOfAccommodation_Id)
                .Index(t => t.email, unique: true)
                .Index(t => t.username, unique: true)
                .Index(t => t.address_Id)
                .Index(t => t.AgentOfAccommodation_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Country = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Number = c.String(),
                        ApartmentNumber = c.String(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        MessageContent = c.String(),
                        Seen = c.Boolean(nullable: false),
                        DatumVreme = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Accommodation_Id = c.Long(),
                        Receiver_id = c.Long(),
                        Reservation_Id = c.Long(),
                        Sender_id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accommodations", t => t.Accommodation_Id)
                .ForeignKey("dbo.Users", t => t.Receiver_id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .ForeignKey("dbo.Users", t => t.Sender_id)
                .Index(t => t.Accommodation_Id)
                .Index(t => t.Receiver_id)
                .Index(t => t.Reservation_Id)
                .Index(t => t.Sender_id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(),
                        Img = c.Byte(nullable: false),
                        Accommodation_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accommodations", t => t.Accommodation_Id)
                .Index(t => t.Accommodation_Id);
            
            CreateTable(
                "dbo.ServiceAccommodations",
                c => new
                    {
                        Service_Id = c.Long(nullable: false),
                        Accommodation_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_Id, t.Accommodation_Id })
                .ForeignKey("dbo.Services", t => t.Service_Id, cascadeDelete: true)
                .ForeignKey("dbo.Accommodations", t => t.Accommodation_Id, cascadeDelete: true)
                .Index(t => t.Service_Id)
                .Index(t => t.Accommodation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "Accommodation_Id", "dbo.Accommodations");
            DropForeignKey("dbo.ServiceAccommodations", "Accommodation_Id", "dbo.Accommodations");
            DropForeignKey("dbo.ServiceAccommodations", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Users", "AgentOfAccommodation_Id", "dbo.Accommodations");
            DropForeignKey("dbo.Accommodations", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Messages", "Sender_id", "dbo.Users");
            DropForeignKey("dbo.Messages", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Messages", "Receiver_id", "dbo.Users");
            DropForeignKey("dbo.Messages", "Accommodation_Id", "dbo.Accommodations");
            DropForeignKey("dbo.Reservations", "Guest_id", "dbo.Users");
            DropForeignKey("dbo.Users", "address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Reservations", "CommentRate_Id", "dbo.CommentRates");
            DropForeignKey("dbo.Reservations", "AccommodationUnit_Id", "dbo.AccommodationUnits");
            DropForeignKey("dbo.PeriodPrices", "AccommodationUnit_Id", "dbo.AccommodationUnits");
            DropForeignKey("dbo.AccommodationUnits", "AccommodationUnitType_id", "dbo.AccommodationUnitTypes");
            DropForeignKey("dbo.AccommodationUnits", "Accommodation_Id", "dbo.Accommodations");
            DropIndex("dbo.ServiceAccommodations", new[] { "Accommodation_Id" });
            DropIndex("dbo.ServiceAccommodations", new[] { "Service_Id" });
            DropIndex("dbo.Images", new[] { "Accommodation_Id" });
            DropIndex("dbo.Messages", new[] { "Sender_id" });
            DropIndex("dbo.Messages", new[] { "Reservation_Id" });
            DropIndex("dbo.Messages", new[] { "Receiver_id" });
            DropIndex("dbo.Messages", new[] { "Accommodation_Id" });
            DropIndex("dbo.Users", new[] { "AgentOfAccommodation_Id" });
            DropIndex("dbo.Users", new[] { "address_Id" });
            DropIndex("dbo.Users", new[] { "username" });
            DropIndex("dbo.Users", new[] { "email" });
            DropIndex("dbo.Reservations", new[] { "Guest_id" });
            DropIndex("dbo.Reservations", new[] { "CommentRate_Id" });
            DropIndex("dbo.Reservations", new[] { "AccommodationUnit_Id" });
            DropIndex("dbo.PeriodPrices", new[] { "AccommodationUnit_Id" });
            DropIndex("dbo.AccommodationUnits", new[] { "AccommodationUnitType_id" });
            DropIndex("dbo.AccommodationUnits", new[] { "Accommodation_Id" });
            DropIndex("dbo.Accommodations", new[] { "Address_Id" });
            DropTable("dbo.ServiceAccommodations");
            DropTable("dbo.Images");
            DropTable("dbo.Services");
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
