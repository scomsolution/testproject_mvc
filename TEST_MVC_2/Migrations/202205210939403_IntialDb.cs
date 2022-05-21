namespace TEST_MVC_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "City");
        }
    }
}
