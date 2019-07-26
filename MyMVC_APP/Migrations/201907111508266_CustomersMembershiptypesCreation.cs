namespace MyMVC_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomersMembershiptypesCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        MyProperty_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MemberShipTypes", t => t.MyProperty_ID)
                .Index(t => t.MyProperty_ID);
            
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        periodByDays = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MyProperty_ID", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MyProperty_ID" });
            DropTable("dbo.MemberShipTypes");
            DropTable("dbo.Customers");
        }
    }
}
