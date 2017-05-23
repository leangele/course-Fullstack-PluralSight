namespace FullStack.net.PluralSight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCanceToGig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "IsCanceled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gigs", "IsCanceled");
        }
    }
}
