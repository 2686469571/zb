namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String(maxLength: 200));
            DropColumn("dbo.Blogs", "Uri");
            DropColumn("dbo.Blogs", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "Rating", c => c.Int(nullable: false));
            AddColumn("dbo.Blogs", "Uri", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
        }
    }
}
