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
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee; // Creates backing field for express fee

        // Preconditions: length, width, height, and weight must be > 0, expressFee must be >=0
        // Postconditions: The next day air package is created with the specified values for
        //                origin address, destination address, length, width,
        //                height, weight, and expressFee
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, decimal expressFee)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            // Use properties to ensure validation occurs

            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        {
            // Preconditions: None
            // Postconditions: Express Fee has been returned 
            get
            {
                return _expressFee; 
            }
            // Preconditions: Express fee must be >=0
            // Postconditions: sets _expressFee equal to input
            private set
            {
                if (value >= 0)
                    _expressFee = value; // If value is >= 0, _expressFee is set to value
                else
                    throw new ArgumentOutOfRangeException("Express Fee", value,
                        "Express Fee must be a non-negative number."); // If value is less than 0, throw exception
            }
        }

        // Precondition:  None
        // Postcondition: The next day air package's cost has been returned
        public override decimal CalcCost()
        {
            // equation for determining the base cost of the next day air package
            decimal baseCost = (decimal).40 * ((decimal)Length + (decimal)Width + (decimal)Height) + (decimal).30 * ((decimal)Weight) + ExpressFee;
            bool package; // Creates bool variable to help control IsHeavy and IsLarge
            decimal weightCharge; // variable to hold weight charge
            decimal sizeCharge;  // variable to hold size charge

            // If package is heavy, adds a weight charge to the base cost
            if (package = IsHeavy())
            {
                return weightCharge = baseCost + (decimal)Weight * (decimal).25;
            }

            // If package is large, adds a size charge to the base cost
            else if (package = IsLarge())
            {
                return sizeCharge = baseCost + (decimal).25 * ((decimal)Length + (decimal)Width + (decimal)Height);
            }

            // If package is not heavy or large, just gives base cost
            else
            {
                return baseCost;
            }
        }

        // Precondition:  None
        // Postcondition: A String with the next day air package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Next Day Air Package:{NL}{base.ToString()}{NL}--------------------";
            // Formats string to have everything from ToString in 
            // AirPackage
        }
    }
}
