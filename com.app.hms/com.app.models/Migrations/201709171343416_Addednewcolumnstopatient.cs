namespace com.app.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addednewcolumnstopatient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patient", "Email", c => c.String());
            AddColumn("dbo.Patient", "Age", c => c.String());
            AddColumn("dbo.Patient", "DateOfBirth", c => c.String());
            AddColumn("dbo.Patient", "Gender", c => c.String());
            AddColumn("dbo.Patient", "Pincode", c => c.String());
            AddColumn("dbo.Patient", "Type", c => c.String());
            AddColumn("dbo.Patient", "Symptoms", c => c.String());
            AddColumn("dbo.Patient", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patient", "Description");
            DropColumn("dbo.Patient", "Symptoms");
            DropColumn("dbo.Patient", "Type");
            DropColumn("dbo.Patient", "Pincode");
            DropColumn("dbo.Patient", "Gender");
            DropColumn("dbo.Patient", "DateOfBirth");
            DropColumn("dbo.Patient", "Age");
            DropColumn("dbo.Patient", "Email");
        }
    }
}
