namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCustomerTitleInCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerTitle", c => c.String());
            DropColumn("dbo.Customers", "CustomerLastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerLastName", c => c.String());
            DropColumn("dbo.Customers", "CustomerTitle");
        }
    }
}
