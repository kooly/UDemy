namespace MyMVC_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomerModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeID_ID", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeID_ID" });
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeID_ID", newName: "MembershipTypeID");
            AlterColumn("dbo.Customers", "MembershipTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeID");
            AddForeignKey("dbo.Customers", "MembershipTypeID", "dbo.MemberShipTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeID", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeID" });
            AlterColumn("dbo.Customers", "MembershipTypeID", c => c.Int());
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeID", newName: "MembershipTypeID_ID");
            CreateIndex("dbo.Customers", "MembershipTypeID_ID");
            AddForeignKey("dbo.Customers", "MembershipTypeID_ID", "dbo.MemberShipTypes", "ID");
        }
    }
}
