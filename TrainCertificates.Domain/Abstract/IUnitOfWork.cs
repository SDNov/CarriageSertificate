using System;
using TrainCertificates.Domain.Repository;

namespace TrainCertificates.Domain.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        RailwayCarriageRepository RailwayCarriages { get; }
        TrainRepository Trains { get;  }
        OperatorRepository Operators { get; }
        int Complete();
    }
}
