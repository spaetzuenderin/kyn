using System;

namespace KYN.SwatchService.Business.Models
{
    /// <summary>
    /// Represents a knitted swatch measuring 10 x 10 cm.
    /// Swatch can be named for easy recognition and connection with yarns or projects.
    /// </summary>
    public class Swatch
    {
        public Guid Id { get; }
        public int NumberOfStitches { get; }
        public int NumberOfRows { get; }

        public string Name { get; }
        public string Stitchpattern { get; }
        public string Yarn { get; }
        public double NeedleSize { get; }

        public Swatch(int numberOfStitches, int numberOfRows)
        {
            this.Id = Guid.NewGuid();
            this.NumberOfStitches = numberOfStitches;
            this.NumberOfRows = numberOfRows;
        }

    }
}