using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem
{
    /// <summary>
    /// Setup a class called Address with the following properties: StreetNumber, Street, Suburb, State, Postcode.
    /// </summary>
    public class Address
    {
        const int DEF_STREET_NUMBER = 0;
        const string DEF_STREET = "Unknown";
        const string DEF_SUBURB = "Unknown";
        const string DEF_STATE = "Unknown";
        const string DEF_POSTCODE = "0000";

        // Property Assessor Methods
        public int StreetNumber { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }

        /// <summary>
        /// Constructor that initializes the Address with default values.
        /// </summary>
        public Address(): this(DEF_STREET_NUMBER, DEF_STREET, DEF_SUBURB, DEF_STATE, DEF_POSTCODE)
        {
        }

        /// <summary>
        /// Constructor that initializes the Address with specified values.
        /// </summary>
        /// <param name="streetNumber"></param>
        /// <param name="street"></param>
        /// <param name="suburb"></param>
        /// <param name="state"></param>
        /// <param name="postcode"></param>
        public Address(int streetNumber, string street, string suburb, string state, string postcode)
        {
            StreetNumber = streetNumber;
            Street = street;
            Suburb = suburb;
            State = state;
            Postcode = postcode;
        }

        /// <summary>
        /// ToString method to return a formatted string representation of the Address.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Address: {StreetNumber} {Street}, {Suburb}, {State} {Postcode}";
        }
    }
}
