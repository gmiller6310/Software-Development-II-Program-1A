//Grading ID: C6485
// Program #: 1A
// Due Date: September 25, 2017 11:59 P.M.
// Course Number: CIS200-01
// Brief Decsription: Creates a system of classes that deals with shipping and receiving of packages from a company such as UPS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public class GroundPackage : Package
    {

        // Precondition:  length, width, height, and weight must be > 0
        // Postcondition: The ground package is created with the specified values for
        //                origin address, destination address, length, width,
        //                height, and weight
        public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight)
            : base(originAddress, destAddress, length, width, height, weight)
        {
     // Properties are inhereited from Package
        }


        public double ZoneDistance
        {
            // Precondition:  None
            // Postcondition: The ground package's zone distance is returned.
            //                The zone distance is the positive difference between the
            //                first digit of the origin zip code and the first
            //                digit of the destination zip code.
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int diff;                             // Calculated zone difference

                diff = (OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR);

                return Math.Abs(diff); // Absolute value in case negative
            }
        }

        // Precondition:  None
        // Postcondition: The ground package's cost has been returned
        public override decimal CalcCost()
        {
            const decimal DIM_FACTOR = .20M;   // Dimension coefficient in cost equation
            const decimal WEIGHT_FACTOR = .05M; // Weight coefficient in cost equation

            return DIM_FACTOR * ((decimal)Length + (decimal) Width + (decimal) Height) + WEIGHT_FACTOR * ((decimal) ZoneDistance + 1) * (decimal) Weight;
            // Returns the cost
        }
        
        // Precondition:  None
        // Postcondition: A String with the ground package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Ground Package {NL} {base.ToString()}{NL}{NL}Zone Distance:{NL}" +
                $"{ZoneDistance}{NL}--------------------"; // Formats string to have everything from ToString in 
                                                          // package and adds Zone distance
        }
    }
}
