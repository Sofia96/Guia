namespace bsi24tallerbilly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removestate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WorkshopServices", "state");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkshopServices", "state", c => c.String());
        }
    }
}
