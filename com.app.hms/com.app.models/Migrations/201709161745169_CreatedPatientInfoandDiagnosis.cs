namespace com.app.models.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreatedPatientInfoandDiagnosis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNo = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Diagnosis");
            DropTable("dbo.Patient");
        }
    }
}
