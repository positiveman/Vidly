namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1991-12-16' AS DATETIME) WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
