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
    public abstract class AirPackage : Package
    {
        // Preconditions: length, width, height, and weight must be > 0
        // Postconditions: The air package is created with the specified values for
        //                origin address, destination address, length, width,
        //                height, and weight
        public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            // Properties are inherited from package
        }

        public const double MIN_HEAVY = 75; // Creates constant for minimum amount to be "heavy"

        //Preconditions: Weight must be >=75
        //Postconditions: Determines if the package is heavy or not
        public bool IsHeavy()
        {
            if (Weight >= MIN_HEAVY)
            {
                return true; // When weight is >= 75
            }
            else
            {
                return false; // When weight is not >= 75
            }
        }

        public const double MIN_LARGE = 100; // Creates constant that is minimum value for a large package

        //Preconditions: Length + Width + Height must be >=100
        //Postconditions: Determines if the package is large or not
        public bool IsLarge()
        {
            if (Length + Width + Height >= MIN_LARGE)
            {
                return true; // When combined Length, width, and height are >=100
            }
            else
            {
                return false; // When combines length, width, and height are not >=100
            }
        }

        // Precondition:  None
        // Postcondition: A String with the air package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{base.ToString()}{NL}{NL}Is Heavy:{NL}" +
                IsHeavy() + $"{NL}{NL}Is Large: {NL}" + IsLarge(); // Formats string to have everything from ToString in 
                                                                   // package and adds IsHeavy and IsLarge

        }
    }
}
