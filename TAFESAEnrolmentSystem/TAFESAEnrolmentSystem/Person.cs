using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TAFESAEnrolmentSystem
{
    class Person
    {
        // Constants for default values
        const string DEF_NAME = "Unknown";
        const string DEF_EMAIL = "No email provided";
        const string DEF_PHONE_NUMBER = "No phone number provided";

        // // Property Assessor Methods
        public string name;
        public string email;
        public string phoneNumber;
        private Address address = new Address();

        // Property Assessor Method for name
        public string PersonName { get; set; }
        // Property Assessor Method for email
        public string PersonEmail { get; set; }
        // Property Assessor Method for phoneNumber
        public string PersonPhoneNumber { get; set; }
        public Address PersonAddress { get; set; }

        // Constructor (no args)
        public Person(): this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER, new Address())
        {
        }

        // Constructor (with no Address)
        public Person(string name, string email, string phoneNumber) : this(name, email, phoneNumber,new Address())
        {
        }

        // Constructor (with all args)
        public Person(string name, string email, string phoneNumber, Address address)
        { 
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phoneNumber;
            PersonAddress = address;
        }

        public override string ToString()
        {
            return $"Name: {PersonName}, Email: {PersonEmail}, Phone: {PersonPhoneNumber}, Address: {PersonAddress}";
        }


        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //Return false if object is null or not a Person
            if (obj == null || (obj.GetType() != this.GetType()))
            {
                return false;
            }

            // Return true if the same reference
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            // Cast the object to Person
            Person person = (Person)obj;
            return person.PersonName == PersonName;
        }

        /// <summary>
        /// Returns a hash code for the current object.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.PersonName.GetHashCode();
        }

        /// <summary>
        /// Determines whether two Person objects are equal based on their Name.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Person p1, Person p2)
        {
            return object.Equals(p1, p2);
        }


        /// <summary>
        /// Determines whether two Person objects are not equal based on their Name.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Person p1, Person p2)
        {
            return !object.Equals(p1, p2);
        }
    }
}
