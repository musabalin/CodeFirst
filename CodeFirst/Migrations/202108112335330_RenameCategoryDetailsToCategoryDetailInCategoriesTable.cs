namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCategoryDetailsToCategoryDetailInCategoriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDetail", c => c.String());
            DropColumn("dbo.Categories", "CategoryDetails");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryDetails", c => c.String());
            DropColumn("dbo.Categories", "CategoryDetail");
        }
    }
}
