namespace Kadry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documentations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Path = c.String(),
                        Person_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.Person_ID)
                .Index(t => t.Person_ID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Street_nr = c.String(),
                        Local = c.Int(),
                        Post_Code = c.String(),
                        Pesel = c.String(),
                        Birth_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documentations", "Person_ID", "dbo.People");
            DropIndex("dbo.Documentations", new[] { "Person_ID" });
            DropTable("dbo.People");
            DropTable("dbo.Documentations");
        }
    }
}
