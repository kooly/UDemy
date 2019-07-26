namespace MyMVC_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdtDBError : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "MyProperty_ID", newName: "MembershipTypeID_ID");
            RenameIndex(table: "dbo.Customers", name: "IX_MyProperty_ID", newName: "IX_MembershipTypeID_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Customers", name: "IX_MembershipTypeID_ID", newName: "IX_MyProperty_ID");
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeID_ID", newName: "MyProperty_ID");
        }
    }
}
