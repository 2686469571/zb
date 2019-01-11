namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Rating");
        }
    }
}
