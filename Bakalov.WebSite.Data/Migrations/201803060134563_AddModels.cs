namespace Bakalov.WebSite.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carousels",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ItemId = c.Int(),
                        FolderId = c.Int(nullable: false),
                        Name = c.String(),
                        IsItemCarousel = c.Boolean(nullable: false),
                        IsInCarousel = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.Folders",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ParentFolderId = c.Int(),
                        Image = c.String(),
                        Url = c.String(),
                        MySort = c.Int(nullable: false),
                        FolderStatus = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        ParentFolder_ID = c.Guid(),
                        Carousel_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Folders", t => t.ParentFolder_ID)
                .ForeignKey("dbo.Carousels", t => t.Carousel_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.ParentFolder_ID)
                .Index(t => t.Carousel_ID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FolderId = c.Int(nullable: false),
                        PromotionId = c.Int(),
                        CategoryId = c.Int(),
                        CarouselId = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        Carousel_ID = c.Guid(),
                        Category_ID = c.Guid(),
                        Folder_ID = c.Guid(),
                        Promotion_ID = c.Guid(),
                        Order_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Carousels", t => t.Carousel_ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.Folders", t => t.Folder_ID)
                .ForeignKey("dbo.Promotions", t => t.Promotion_ID)
                .ForeignKey("dbo.Orders", t => t.Order_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.Carousel_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.Folder_ID)
                .Index(t => t.Promotion_ID)
                .Index(t => t.Order_ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ParentCategoryId = c.Int(),
                        ItemId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        ImagePath = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        ParentCategory_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.ParentCategory_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.ParentCategory_ID);
            
            CreateTable(
                "dbo.ItemSpecifications",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Key = c.String(),
                        Value = c.String(),
                        ItemId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        Item_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.Item_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.Item_ID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OldPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ParentPromotionId = c.Int(),
                        ImagePath = c.String(),
                        SatartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        ParentPromotion_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Promotions", t => t.ParentPromotion_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.ParentPromotion_ID);
            
            CreateTable(
                "dbo.FolderCategories",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FolderId = c.Int(nullable: false),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        Folder_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Folders", t => t.Folder_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.Folder_ID);
            
            CreateTable(
                "dbo.ItemImages",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IntemId = c.Int(nullable: false),
                        PostId = c.Int(),
                        Image = c.String(),
                        Position = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        Item_ID = c.Guid(),
                        Post_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.Item_ID)
                .ForeignKey("dbo.Posts", t => t.Post_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.Item_ID)
                .Index(t => t.Post_ID);
            
            CreateTable(
                "dbo.OrderDatas",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        OrderId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        Item_ID = c.Guid(),
                        Order_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.Item_ID)
                .ForeignKey("dbo.Orders", t => t.Order_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.Item_ID)
                .Index(t => t.Order_ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ItemId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        PaymentTypeId = c.Int(nullable: false),
                        PaymentType = c.Int(nullable: false),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        QuantityOfAdults = c.Int(nullable: false),
                        QuantityOfRooms = c.Int(nullable: false),
                        HasChidren = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        Address_ID = c.Guid(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Address_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.Address_ID)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        UserId = c.Int(nullable: false),
                        Phone = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Street = c.String(),
                        ZipKod = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.OrderInvoiceDatas",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Name = c.String(),
                        City = c.String(),
                        Mol = c.String(),
                        Eik = c.Int(nullable: false),
                        Dds = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        Order_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.Order_ID)
                .Index(t => t.IsDeleted)
                .Index(t => t.Order_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderInvoiceDatas", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.OrderDatas", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Items", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDatas", "Item_ID", "dbo.Items");
            DropForeignKey("dbo.ItemImages", "Post_ID", "dbo.Posts");
            DropForeignKey("dbo.ItemImages", "Item_ID", "dbo.Items");
            DropForeignKey("dbo.FolderCategories", "Folder_ID", "dbo.Folders");
            DropForeignKey("dbo.Items", "Promotion_ID", "dbo.Promotions");
            DropForeignKey("dbo.Promotions", "ParentPromotion_ID", "dbo.Promotions");
            DropForeignKey("dbo.ItemSpecifications", "Item_ID", "dbo.Items");
            DropForeignKey("dbo.Items", "Folder_ID", "dbo.Folders");
            DropForeignKey("dbo.Items", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.Categories", "ParentCategory_ID", "dbo.Categories");
            DropForeignKey("dbo.Items", "Carousel_ID", "dbo.Carousels");
            DropForeignKey("dbo.Folders", "Carousel_ID", "dbo.Carousels");
            DropForeignKey("dbo.Folders", "ParentFolder_ID", "dbo.Folders");
            DropIndex("dbo.OrderInvoiceDatas", new[] { "Order_ID" });
            DropIndex("dbo.OrderInvoiceDatas", new[] { "IsDeleted" });
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropIndex("dbo.Addresses", new[] { "IsDeleted" });
            DropIndex("dbo.Orders", new[] { "User_Id" });
            DropIndex("dbo.Orders", new[] { "Address_ID" });
            DropIndex("dbo.Orders", new[] { "IsDeleted" });
            DropIndex("dbo.OrderDatas", new[] { "Order_ID" });
            DropIndex("dbo.OrderDatas", new[] { "Item_ID" });
            DropIndex("dbo.OrderDatas", new[] { "IsDeleted" });
            DropIndex("dbo.ItemImages", new[] { "Post_ID" });
            DropIndex("dbo.ItemImages", new[] { "Item_ID" });
            DropIndex("dbo.ItemImages", new[] { "IsDeleted" });
            DropIndex("dbo.FolderCategories", new[] { "Folder_ID" });
            DropIndex("dbo.FolderCategories", new[] { "IsDeleted" });
            DropIndex("dbo.Promotions", new[] { "ParentPromotion_ID" });
            DropIndex("dbo.Promotions", new[] { "IsDeleted" });
            DropIndex("dbo.ItemSpecifications", new[] { "Item_ID" });
            DropIndex("dbo.ItemSpecifications", new[] { "IsDeleted" });
            DropIndex("dbo.Categories", new[] { "ParentCategory_ID" });
            DropIndex("dbo.Categories", new[] { "IsDeleted" });
            DropIndex("dbo.Items", new[] { "Order_ID" });
            DropIndex("dbo.Items", new[] { "Promotion_ID" });
            DropIndex("dbo.Items", new[] { "Folder_ID" });
            DropIndex("dbo.Items", new[] { "Category_ID" });
            DropIndex("dbo.Items", new[] { "Carousel_ID" });
            DropIndex("dbo.Items", new[] { "IsDeleted" });
            DropIndex("dbo.Folders", new[] { "Carousel_ID" });
            DropIndex("dbo.Folders", new[] { "ParentFolder_ID" });
            DropIndex("dbo.Folders", new[] { "IsDeleted" });
            DropIndex("dbo.Carousels", new[] { "IsDeleted" });
            DropTable("dbo.OrderInvoiceDatas");
            DropTable("dbo.Addresses");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDatas");
            DropTable("dbo.ItemImages");
            DropTable("dbo.FolderCategories");
            DropTable("dbo.Promotions");
            DropTable("dbo.ItemSpecifications");
            DropTable("dbo.Categories");
            DropTable("dbo.Items");
            DropTable("dbo.Folders");
            DropTable("dbo.Carousels");
        }
    }
}
