namespace com.app.models.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RemovedDiagnosis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patient", "LineOne", c => c.String());
            AddColumn("dbo.Patient", "LineTwo", c => c.String());
            AddColumn("dbo.Patient", "LineThree", c => c.String());
            DropTable("dbo.Diagnosis");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Diagnosis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        LineOne = c.String(),
                        LineTwo = c.String(),
                        LineThree = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Patient", "LineThree");
            DropColumn("dbo.Patient", "LineTwo");
            DropColumn("dbo.Patient", "LineOne");
        }
    }
}
