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
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early = 0, Saver = 1}; // Creates enum Delivery, with values Earlay and Saver

        // Preconditions: length, width, height, and weight must be > 0, DeliveryType must be 0 or 1
        // Postconditions: The two day air package is created with the specified values for
        //                origin address, destination address, length, width,
        //                height, weight, and DeliveryType
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, Delivery DeliveryType)
            : base(originAddress, destAddress, length, width, height, weight)
        {
           // Properties inherited from AirPackage
        }

        public Delivery DeliveryType
        {
            // Preconditions: none
            // Postonditions: none
            get;
            // Preconditions: none
            //Postconditions: none
            private set;
        }

        // Precondition:  None
        // Postcondition: The next day air package's cost has been returned
        public override decimal CalcCost()
        {
            // Creates baseCost and contains formula for price
            decimal baseCost = (decimal).25 * ((decimal)Length + (decimal)Width + (decimal)Height) + (decimal).25 * (decimal)Weight;

            // What to do in the case that the package is of enum Saver, gives 10% discount
            if (DeliveryType == Delivery.Saver)
            {
                return baseCost * (decimal).90;
            }
            else
            {
                return baseCost; // If not saver, gives base cost
            }
        }

        // Precondition:  None
        // Postcondition: A String with the two day air package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            // Formats string to have everything from ToString in 
            // AirPackage and Delivery Type as well
            return $"Two Day Air Package{NL}{base.ToString()}{NL}{NL}Delivery Type:{NL}{DeliveryType}{NL}--------------------";
        }

    }
}
