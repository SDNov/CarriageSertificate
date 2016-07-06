using System;
using System.Collections.Generic;

namespace TrainCertificates.Domain.Core
{
    public class RailwayCarriage
    {
        public int Id { get; set; }
        public int CarriageNumber { get; set; }
        public DateTime ConstructionDate { get; set; }
        public string Manufacturer { get; set; }
        public DateTime OverhaulDate { get; set; }
        public string OverhaulManufacturer { get; set; }
        public DateTime DepotRepairDate { get; set; }
        public string DepotRepairManufacturer { get; set; }
        public ICollection<Train> Trains { get; set; }
    }
}
