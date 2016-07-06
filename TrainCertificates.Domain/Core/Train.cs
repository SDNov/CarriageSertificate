using System.Collections.Generic;

namespace TrainCertificates.Domain.Core
{
    public class Train
    {
        public Train()
        {
            Carriages = new List<RailwayCarriage>();
        }
        public int Id { get; set; }
        public int TrainNumber { get; set; }
        public string DastinationStation { get; set; }
        public string ShippingName { get; set; }
        public string AK { get; set; }
        public string UN { get; set; }
        public ICollection<RailwayCarriage> Carriages { get; set; }
    }
}
