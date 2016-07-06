using TrainCertificates.Domain.Core;

namespace TrainCertificates.Domain.Repository
{
    public class TrainRepository : Repository<Train>
    {
        public TrainRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
