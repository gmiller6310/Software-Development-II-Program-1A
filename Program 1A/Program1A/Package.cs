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
    public abstract class Package : Parcel
    {
        // List of backing fields made to help with values
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        // Preconditions: length, width, height, and weight must be positive numbers
        // Postconditions: Package is created with values for addresses, length, width, height, and weight
        public Package(Address originAddress, Address destAddress, double length, double width, double height, double weight)
            : base(originAddress, destAddress)
        {
            // Properties to ensure validation
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public double Length
        { 
            // Precondition:  None
            // Postcondition: The length has been returned
        get
            {
                return _length;
            }

            // Precondition:  Value > 0
            // Postcondition: The length has been set to the
            //                specified value
            set
            {
                if (value > 0)
                    _length = value; // Length must be positive
                else
                    throw new ArgumentOutOfRangeException("Length", value,
                        "Length must be a positive number."); // If not positive, exception is thrown
            }
        }

        public double Width
        {
            // Precondition:  None
            // Postcondition: The width has been returned
            get
            {
                return _width;
            }

            // Precondition:  Value > 0
            // Postcondition: The width has been set to the
            //                specified value
            set
            {
                if (value > 0)
                    _width = value; // Width must be a positive number
                else
                    throw new ArgumentOutOfRangeException("Width", value,
                        "Width must be a positive number."); // If not positive, exception is thrown
            }
        }

        public double Height
        {
            // Precondition:  None
            // Postcondition: The height has been returned
            get
            {
                return _height;
            }

            // Precondition:  Value > 0 
            // Postcondition: The height has been set to the
            //                specified value
            set
            {
                if (value > 0)
                    _height = value; // Height must be a positive number
                else
                    throw new ArgumentOutOfRangeException("Height", value,
                        "Height must be a positive number."); // If not positive, excpetion is thrown
            }
        }

                public double Weight
        {
            // Precondition:  None
            // Postcondition: The weight has been returned
            get
            {
                return _weight;
            }

            // Precondition:  Value > 0
            // Postcondition: The weight has been set to the
            //                specified value
            set
            {
                if (value > 0)
                    _weight = value; // Weight must be a postiive number
                else
                    throw new ArgumentOutOfRangeException("Weight", value,
                        "Weight must be a positive number."); // If not positive, exception is thrown
            }
        }

        // Precondition:  None
        // Postcondition: A String with the package's data has been returned
        public override String ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Length:{NL}{Length} inches{NL}{NL}Width:{NL}" +
                $"{Width} inches{NL}{NL}Height:{NL}{Height} inches{NL}{NL}" +
                $"Weight:{NL}{Weight} pounds{NL}{NL}Cost: {NL}{CalcCost():C}"; 
            // Formats the length, width, and height in inches. Weight in pounds, and the cost in a string
        }

    }
        
    
}
