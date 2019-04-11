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
    public abstract class Parcel
    {
        // Precondition:  None
        // Postcondition: The parcel is created with the specified values for
        //                origin address and destination address
        public Parcel(Address originAddress, Address destAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destAddress;
        }

        public Address OriginAddress
        {
            // Precondition:  None
            // Postcondition: The parcel's origin address has been returned
            get;

            // Precondition:  None
            // Postcondition: The parcel's origin address has been set to the
            //                specified value
            set;
        }

        public Address DestinationAddress
        {
            // Precondition:  None
            // Postcondition: The parcel's destination address has been returned
            get;

            // Precondition:  None
            // Postcondition: The parcel's destination address has been set to the
            //                specified value
            set;
        }

        // Precondition:  None
        // Postcondition: The parcel's cost has been returned
        public abstract decimal CalcCost();

        // Precondition:  None
        // Postcondition: A String with the parcel's data has been returned
        public override String ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
                $"{DestinationAddress}{NL}Cost: {CalcCost():C}{NL}"; // Displays Origin and Destination addresses
                                                                     // as well as cost formatted
        }
    }
}
