using TrainCertificates.Domain.Core;

namespace TrainCertificates.Domain.Repository
{
    public class OperatorRepository : Repository<Operator>
    {
        public OperatorRepository(MainDbContext context)
            : base (context)
        {

        }
    }
}
