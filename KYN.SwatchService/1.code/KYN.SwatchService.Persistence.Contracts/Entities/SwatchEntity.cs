using System;
using System.Collections.Generic;
using System.Text;

namespace KYN.SwatchService.Persistence.Contracts.Entities
{
    class SwatchEntity
    {
        private Guid Id;
        private int NumberOfStitches;
        private int NumberOfRows;

        private String Name;
        private String Stitchpattern;
        private String Yarn; // Could be replaced by Yarn Object?
        private double NeedleSize;
    }
}
