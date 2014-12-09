namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MdUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MDUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InGameName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "MdUser_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "MdUser_Id");
            AddForeignKey("dbo.AspNetUsers", "MdUser_Id", "dbo.MDUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "MdUser_Id", "dbo.MDUsers");
            DropIndex("dbo.AspNetUsers", new[] { "MdUser_Id" });
            DropColumn("dbo.AspNetUsers", "MdUser_Id");
            DropTable("dbo.MDUsers");
        }
    }
}
