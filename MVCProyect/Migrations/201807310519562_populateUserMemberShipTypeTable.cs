namespace MVCProyect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateUserMemberShipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes(Id,SignUpFree,DurationInMonth,DiscountRate) values(1,0,0,0)");
            Sql("Insert into MembershipTypes(Id,SignUpFree,DurationInMonth,DiscountRate) values(2,30,1,10)");
            Sql("Insert into MembershipTypes(Id,SignUpFree,DurationInMonth,DiscountRate) values(3,90,3,15)");
            Sql("Insert into MembershipTypes(Id,SignUpFree,DurationInMonth,DiscountRate) values(4,300,12,15)");



        }
        
        public override void Down()
        {
        }
    }
}
