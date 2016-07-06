using System.Data.Entity;
using TrainCertificates.Domain.Utils;

namespace TrainCertificates.Domain.Core
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
            : base("MainDbContext")
        {
            Database.SetInitializer<MainDbContext>(new ContextInitializer());
        }
        public virtual DbSet<RailwayCarriage> RailwayCarriages { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
    }
}
