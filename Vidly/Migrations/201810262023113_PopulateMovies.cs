namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'Hangover', CAST('2015-12-11' AS DATETIME), GETDATE(), 5, 5)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'Titanic', CAST('1999-05-11' AS DATETIME), GETDATE(), 3, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
