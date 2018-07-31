namespace MVCProyect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataBaseAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Name", c => c.String());
        }
    }
}
