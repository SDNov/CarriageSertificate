using TrainCertificates.Domain.Core;

namespace TrainCertificates.Domain.Repository
{
    public class RailwayCarriageRepository : Repository<RailwayCarriage>
    {
        public RailwayCarriageRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
