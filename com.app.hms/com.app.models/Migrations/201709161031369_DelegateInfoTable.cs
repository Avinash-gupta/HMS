namespace com.app.models.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class DelegateInfoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DelegateInfo",
                c => new
                    {
                        DelegateId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.DelegateId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DelegateInfo");
        }
    }
}
