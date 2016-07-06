using System;
using System.Data.Entity;
using TrainCertificates.Domain.Core;

namespace TrainCertificates.Domain.Utils
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<MainDbContext>
    {
        protected override void Seed(MainDbContext context)
        {
            RailwayCarriage car1 = new RailwayCarriage
            {
                CarriageNumber = 50150317,
                ConstructionDate = DateTime.Parse("17.04.2009"),
                Manufacturer = "ОАО \"НПК\"Уралвагонзавод\"\"",
                OverhaulDate = DateTime.Parse("14.08.2012"),
                OverhaulManufacturer = "ВЧДр Кинель ОАО \"ВРК-1\"",
                DepotRepairDate = DateTime.Parse("14.08.2014"),
                DepotRepairManufacturer = "ВЧДр Рыбное ОАО \"ВРК-1\""
            };

            RailwayCarriage car2 = new RailwayCarriage
            {
                CarriageNumber = 60180329,
                ConstructionDate = DateTime.Parse("17.04.2009"),
                Manufacturer = "ОАО \"НПК\"Уралвагонзавод\"\"",
                OverhaulDate = DateTime.Parse("14.08.2012"),
                OverhaulManufacturer = "ВЧДр Кинель ОАО \"ВРК-1\"",
                DepotRepairDate = DateTime.Parse("14.08.2014"),
                DepotRepairManufacturer = "ВЧДр Рыбное ОАО \"ВРК-1\""
            };

            Train train = new Train
            {
                TrainNumber = 123,
                DastinationStation = "Вышестеблиевская СК ЖД",
                ShippingName = "Бензин для промышленных целей",
                AK = "328",
                UN = "3295"
            };
            train.Carriages.Add(car1);
            train.Carriages.Add(car2);
            context.RailwayCarriages.Add(car1);
            context.RailwayCarriages.Add(car2);
            context.Trains.Add(train);
            context.SaveChanges();
        }
    }
}
