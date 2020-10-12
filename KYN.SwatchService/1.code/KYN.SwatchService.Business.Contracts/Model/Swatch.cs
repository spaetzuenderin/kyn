using System;
using System.Collections.Generic;
using System.Text;

namespace KYN.SwatchService.Business.Contracts.Model
{
    /// <summary>
    /// Represents a knitted swatch measuring 10 x 10 cm.
    /// Swatch can be named for easy recognition and connection with yarns or projects.
    /// </summary>
    public class Swatch
    {
        public Guid Id { get; set; }
        public int NumberOfStitches { get; set; }
        public int NumberOfRows { get; set; }

        public string Name { get; set; }
        public string Stitchpattern { get; set; }
        public string Yarn { get; set; }
        public double NeedleSize { get; set; }

        public Swatch()
        {
            this.Id = Guid.NewGuid();
        }

        public Swatch(int numberOfStitches, int numberOfRows)
        {
            this.NumberOfStitches = numberOfStitches;
            this.NumberOfRows = numberOfRows;
        }

    }
}
