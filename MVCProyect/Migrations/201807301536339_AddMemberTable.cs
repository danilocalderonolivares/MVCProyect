namespace MVCProyect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        MembershipTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        SignUpFree = c.Short(nullable: false),
                        DurationInMonth = c.Byte(nullable: false),
                        DiscontRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MembershipTypeId);
            
            AddColumn("dbo.Users", "IsSuscribedToNewsLetter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Users", "Birthdate", c => c.DateTime());
            AddColumn("dbo.Users", "MembershipType_MembershipTypeId", c => c.Int());
            CreateIndex("dbo.Users", "MembershipType_MembershipTypeId");
            AddForeignKey("dbo.Users", "MembershipType_MembershipTypeId", "dbo.MembershipTypes", "MembershipTypeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "MembershipType_MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Users", new[] { "MembershipType_MembershipTypeId" });
            DropColumn("dbo.Users", "MembershipType_MembershipTypeId");
            DropColumn("dbo.Users", "Birthdate");
            DropColumn("dbo.Users", "MembershipTypeId");
            DropColumn("dbo.Users", "IsSuscribedToNewsLetter");
            DropTable("dbo.MembershipTypes");
        }
    }
}
