using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem
{
    /// <summary>
    /// Student class represents a student in the TAFESA Enrolment System.
    /// </summary>
    class Student : Person
    {
        // Default constants
        const string DEF_STUDENT_ID = "00000000";
        const string DEF_PROGRAM = "No program enrolled";
        static readonly DateTime DEF_DATE_REGISTERED = new DateTime(2000, 1, 1);

        // Property Assessor Methods
        public string StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }

        /// <summary>
        /// Constructor that initializes the Student with default values.
        /// </summary>
        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED, new Enrollment())
        {
        }

        /// <summary>
        /// Constructor that initializes the Student with default value for enrollment.
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        public Student(string studentID, string program, DateTime dateRegistered)
            : this(studentID, program, dateRegistered, new Enrollment())
        {
        }

        /// <summary>
        /// Constructor with all properties except for Person details.
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        /// <param name="enrollment"></param>
        public Student(string studentID, string program, DateTime dateRegistered, Enrollment enrollment) : base()
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }

        /// <summary>
        /// Constructor that initializes the Student with all properties.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="studentID"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        /// <param name="enrollment"></param>
        public Student(string name, string email, string phoneNumber, Address address,
                      string studentID, string program, DateTime dateRegistered, Enrollment enrollment)
                      : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Student ID: {StudentID}, Program: {Program}, " +
                   $"Registered Date: {DateRegistered:d}\nEnrollment: {StudentEnrollment}";
        }


        /// <summary>
        /// Determines whether the specified object is equal to the current student.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //Return false if object is null or not a Student
            if (obj == null || (obj.GetType() != this.GetType()))
            {
                return false;
            }

            // Return true if the same reference
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            // Cast the object to Student
            Student student = (Student)obj;
            return student.StudentID == this.StudentID;
        }


        /// <summary>
        /// Returns a hash code for the current student.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // Use StudentID for hash code (null-safe)
            return this.StudentID.GetHashCode();
        }


        /// <summary>
        /// Determines whether two Student objects are equal based on their StudentID.
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns></returns>
        public static Boolean operator ==(Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }


        /// <summary>
        /// Determines whether two Student objects are not equal based on their StudentID.
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns></returns>
        public static Boolean operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }

    }
}
