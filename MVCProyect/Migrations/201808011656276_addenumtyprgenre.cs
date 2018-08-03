namespace MVCProyect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addenumtyprgenre : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "Name", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "Name", c => c.Int(nullable: false));
        }
    }
}
