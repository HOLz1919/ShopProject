namespace ShopProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracja1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tbl_Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Mail = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tbl_Users");
        }
    }
}
