namespace FullStack.net.PluralSight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genres (id,name) values(1,'Jazz')");
            Sql("insert into genres (id,name) values(2,'Blues')");
            Sql("insert into genres (id,name) values(3,'Rock')");
            Sql("insert into genres (id,name) values(4,'Contry')");
        }
        
        public override void Down()
        {
            Sql("Delete from Genres where id in (1,2,3,4)");
        }
    }
}
