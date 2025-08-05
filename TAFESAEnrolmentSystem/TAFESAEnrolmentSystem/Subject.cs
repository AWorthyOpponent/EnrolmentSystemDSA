using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem
{
    /// <summary>
    /// Setup a class called Subject with the following properties: SubjectCode, SubjectName, Cost.
    /// </summary>
    public class Subject
    {
        // Default constants
        const string DEF_SUBJECT_CODE = "Unknown";
        const string DEF_SUBJECT_NAME = "Unknown";
        const double DEF_COST = 0.0;

        // Property Assessor Methods
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        /// <summary>
        /// Constructor that initializes the Subject with default values.
        /// </summary>
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {
        }

        /// <summary>
        ///  Constructor that initializes the Subject with specified values.
        /// </summary>
        /// <param name="subjectCode"></param>
        /// <param name="subjectName"></param>
        /// <param name="cost"></param>
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        /// <summary>
        /// ToString method to return a formatted string representation of the Subject.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Name: {SubjectName}, Cost: {Cost:C}";
        }
    }
}
