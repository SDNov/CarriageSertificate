using System;
using TrainCertificates.Domain.Core;
using TrainCertificates.Domain.Repository;

namespace CertificatesConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UnitOfWork uof = new UnitOfWork(new MainDbContext()))
            {
                var carriages = uof.RailwayCarriages.GetAll();
                foreach (var carriage in carriages)
                {
                    Console.WriteLine(carriage.CarriageNumber);
                }

                var train = uof.Trains.Get(1);
                Console.WriteLine(@train.DastinationStation + " вагонов - " + train.Carriages.Count);
            }
            Console.ReadKey();
        }
    }
}
