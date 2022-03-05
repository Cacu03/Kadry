namespace Kadry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes_in_person : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Region", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.People", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "City", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.People", "Street", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "Street_nr", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.People", "Post_Code", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.People", "Pesel", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Pesel", c => c.String());
            AlterColumn("dbo.People", "Post_Code", c => c.String());
            AlterColumn("dbo.People", "Street_nr", c => c.String());
            AlterColumn("dbo.People", "Street", c => c.String());
            AlterColumn("dbo.People", "City", c => c.String());
            AlterColumn("dbo.People", "Surname", c => c.String());
            AlterColumn("dbo.People", "Name", c => c.String());
            DropColumn("dbo.People", "Region");
        }
    }
}
