using System;

namespace KYN.SwatchService.Persistence.Contracts.Entities
{
   public class SwatchEntity
    {
        public Guid Id { get; set; }
        public int NumberOfStitches { get; set; }
        public int NumberOfRows { get; set; }

        public string Name { get; set; }
        public string Stitchpattern { get; set; }
        public string Yarn { get; set; }
        public double NeedleSize { get; set; }
    }
}
