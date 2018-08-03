namespace MVCProyect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataAnotattiontoGenreTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Int());
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.Genres", "Id");
        }
    }
}
