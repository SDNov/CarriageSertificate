using System;

namespace TrainCertificates.Domain.Core
{
    public class Certificate
    {
        public int Id { get; set; }
        public int CertificateNumber { get; set; }
        public DateTime CertificateDate { get; set; }
        public Train Train { get; set; }
        public Operator Operator { get; set; }
    }
}
