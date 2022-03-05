namespace Kadry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mozeteraz : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Documentations", "Person_ID", "dbo.People");
            DropIndex("dbo.Documentations", new[] { "Person_ID" });
            DropTable("dbo.Documentations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Documentations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        File = c.String(),
                        Person_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Documentations", "Person_ID");
            AddForeignKey("dbo.Documentations", "Person_ID", "dbo.People", "ID");
        }
    }
}
