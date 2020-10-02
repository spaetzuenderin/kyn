using System;

namespace KYN.SwatchService.Business.Models
{
    /// <summary>
    /// Represents a knitted swatch measuring 10 x 10 cm.
    /// Swatch can be named for easy recognition and connection with yarns or projects.
    /// </summary>
    public class Swatch
    {
        private Guid Id;
        private int NumberOfStitches;
        private int NumberOfRows;

        private String Name;
        private String Stitchpattern;
        private String Yarn; // Could be replaced by Yarn Object?
        private double NeedleSize;

        public Swatch(int numberOfStitches, int numberOfRows)
        {
            this.Id = Guid.NewGuid();
            this.NumberOfStitches = numberOfStitches;
            this.NumberOfRows = numberOfRows;
        }

    }
}