namespace MVCProyect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthdateToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Birthdate", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Birthdate");
        }
    }
}
