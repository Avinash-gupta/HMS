using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace com.app.models.Context
{
    public class HMSContext : BaseContext<HMSContext>
    {
        public HMSContext()
        {
            Database.SetInitializer(new HMSContextIntializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new DelegateInfoConfiguration());
            modelBuilder.Configurations.Add(new PatientInfoConfiguration());
        }
    }

    public class HMSContextIntializer : CreateDatabaseIfNotExists<HMSContext>
    {
        protected override void Seed(HMSContext context)
        {
            base.Seed(context);
        }
    }

    public class DelegateInfoConfiguration : EntityTypeConfiguration<DelegateInfo>
    {
        public DelegateInfoConfiguration()
        {
            ToTable("DelegateInfo", "dbo");
        }
    }

    public class PatientInfoConfiguration : EntityTypeConfiguration<PatientInfo>
    {
        public PatientInfoConfiguration()
        {
            ToTable("Patient", "dbo");
        }
    }
}
