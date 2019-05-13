namespace ShopProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tbl_Belts",
                c => new
                    {
                        BeltId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cost = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        ProductImage = c.String(),
                    })
                .PrimaryKey(t => t.BeltId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tbl_Belts");
        }
    }
}
