namespace Bakalov.WebSite.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminInSeed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "IsDeleted" });
            DropTable("dbo.Posts");
        }
    }
}
