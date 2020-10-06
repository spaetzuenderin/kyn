using System;

namespace KYN.SwatchService.Persistence.Contracts.Entities
{
   public class SwatchEntity
    {
        public Guid Id { get; }
        public int NumberOfStitches { get; }
        public int NumberOfRows { get; }

        public string Name { get; }
        public string Stitchpattern { get; }
        public string Yarn { get; }
        public double NeedleSize { get; }
    }
}
