using TrainCertificates.Domain.Abstract;
using TrainCertificates.Domain.Core;

namespace TrainCertificates.Domain.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainDbContext _context;

        public UnitOfWork(MainDbContext context)
        {
            this._context = context;
            RailwayCarriages = new RailwayCarriageRepository(_context);
            Trains = new TrainRepository(_context);
            Operators = new OperatorRepository(_context);
        }

        public RailwayCarriageRepository RailwayCarriages { get; private set; }

        public TrainRepository Trains { get; private set; }

        public OperatorRepository Operators { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
