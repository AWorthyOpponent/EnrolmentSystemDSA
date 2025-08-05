using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem
{
    /// <summary>
    /// Enrollment class represents a student's enrollment in a subject.
    /// </summary>
    public class Enrollment
    {
        // Default constants
        public static readonly DateTime DEF_DATE_ENROLLED = new DateTime(2000, 1, 1);
        private const string DEF_GRADE = "N/A";
        private const string DEF_SEMESTER = "Unknown";

        // Property Assessor Methods
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject EnrolledSubject { get; set; }

        /// <summary>
        /// Constructor that initializes the Enrollment with default values.
        /// </summary>
        public Enrollment() : this(new Subject(), DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {
        }

        /// <summary>
        /// Constructor that initializes the Enrollment with a date enrolled, grade, and semester.
        /// </summary>
        /// <param name="subject"></param>
        public Enrollment(DateTime dateEnrolled, string grade, string semester) : this(new Subject(), dateEnrolled, grade, semester)
        {
        }

        /// <summary>
        /// Constructor that initializes the Enrollment with a Subject, date enrolled, grade, and semester.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="dateEnrolled"></param>
        /// <param name="grade"></param>
        /// <param name="semester"></param>
        public Enrollment(Subject subject, DateTime dateEnrolled, string grade, string semester)
        {
            EnrolledSubject = subject;
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
        }

        /// <summary>
        /// Tostring method to return a formatted string representation of the Enrollment.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Enrolled in: {EnrolledSubject.SubjectName} ({EnrolledSubject.SubjectCode}), " +
                   $"Date: {DateEnrolled:d}, Grade: {Grade}, Semester: {Semester}";
        }
    }
}
