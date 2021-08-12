namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCategoryDetailsColumnInCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDetails", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryDetails");
        }
    }
}
