using System;

namespace TAFESAEnrolmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // Test Address
            // -------------------------------
            Console.WriteLine("\n=== Testing Address Class ===");
            // Create a new Address with default values
            Address myAddress = new Address();
            Console.WriteLine(myAddress);

            // Test Property Accessor Methods
            myAddress.StreetNumber = 101;
            myAddress.Street = "Main Street";
            myAddress.Suburb = "Adelaide";
            myAddress.State = "SA";
            myAddress.Postcode = "5000";

            Console.WriteLine("Street Number: " + myAddress.StreetNumber);
            Console.WriteLine("Street: " + myAddress.Street);
            Console.WriteLine("Suburb: " + myAddress.Suburb);
            Console.WriteLine("State: " + myAddress.State);
            Console.WriteLine("Postcode: " + myAddress.Postcode);

            // Print the updated Address using ToString method
            Console.WriteLine("Updated Address: " + myAddress);

            // Create a new Address using the full constructor and print it
            Address myAddress2 = new Address(45, "North Terrace", "Adelaide", "SA", "5005");
            Console.WriteLine(myAddress2);

            // -------------------------------
            // Test Subject
            // -------------------------------
            Console.WriteLine("\n=== Testing Subject Class ===");
            // Create a new Subject with default values
            Subject mySubject = new Subject();
            Console.WriteLine(mySubject);

            // Test Property Accessor Methods
            mySubject.SubjectCode = "ICT101";
            mySubject.SubjectName = "Introduction to Programming";
            mySubject.Cost = 1500.50;

            Console.WriteLine("Subject Code: " + mySubject.SubjectCode);
            Console.WriteLine("Subject Name: " + mySubject.SubjectName);
            Console.WriteLine("Cost: " + mySubject.Cost);

            // Print the updated Subject using ToString method
            Console.WriteLine("Updated Subject: " + mySubject);

            // Create a new Subject using the full constructor and print it
            Subject mySubject2 = new Subject("MATH200", "Advanced Mathematics", 1200.00);
            Console.WriteLine(mySubject2);

            // -------------------------------
            // Test Enrollment
            // -------------------------------
            Console.WriteLine("\n=== Testing Enrollment Class ===");
            // Create a new Enrollment with default values
            Enrollment enrollment1 = new Enrollment();
            Console.WriteLine(enrollment1);

            // Test Property Accessor Methods
            Subject sub1 = new Subject("ICT101", "Introduction to Programming", 1500.50);
            enrollment1.EnrolledSubject = sub1;
            enrollment1.DateEnrolled = new DateTime(2025, 2, 15);
            enrollment1.Grade = "A";
            enrollment1.Semester = "Semester 1";

            Console.WriteLine("Enrollment 1 Details:");
            Console.WriteLine("Subject: " + enrollment1.EnrolledSubject);
            Console.WriteLine("Date Enrolled: " + enrollment1.DateEnrolled);
            Console.WriteLine("Grade: " + enrollment1.Grade);
            Console.WriteLine("Semester: " + enrollment1.Semester);
            Console.WriteLine("Formatted: " + enrollment1);

            // Create a new Enrollment with only date, grade, and semester
            Enrollment enrollment2 = new Enrollment(
                new DateTime(2024, 7, 10),
                "B+",
                "Semester 2"
            );
            Console.WriteLine("Enrollment 2: " + enrollment2);

            // Create a new Enrollment with a Subject, date, grade, and semester
            Subject sub2 = new Subject("MATH200", "Advanced Mathematics", 1200.00);
            Enrollment enrollment3 = new Enrollment(sub2, DateTime.Now, "HD", "Semester 1");
            Console.WriteLine("Enrollment 3: " + enrollment3);

            // -------------------------------
            // Test Person
            // -------------------------------
            Console.WriteLine("\n=== Testing Person Class ===");
            // Create a new Person with default values
            Person defaultPerson = new Person();
            Console.WriteLine("Default Person:");
            Console.WriteLine(defaultPerson);

            // Create a new Person using the constructor with no Address
            Person personNoAddress = new Person("Alice", "alice@example.com", "123456789");
            Console.WriteLine("\nPerson without custom Address:");
            Console.WriteLine(personNoAddress);

            // Create a new Person using the constructor with custom Address
            Address address = new Address(10, "King St", "Adelaide", "SA", "5000");
            Person personWithAddress = new Person("Bob", "bob@example.com", "987654321", address);
            Console.WriteLine("\nPerson with custom Address:");
            Console.WriteLine(personWithAddress);

            // Test Property Accessor Methods
            personWithAddress.PersonName = "Robert";
            personWithAddress.PersonEmail = "robert@example.com";
            personWithAddress.PersonPhoneNumber = "1122334455";
            personWithAddress.PersonAddress = new Address(22, "Queen St", "Melbourne", "VIC", "3000");
            Console.WriteLine("\nAfter modifying properties:");
            Console.WriteLine(personWithAddress);

            // Test equality and hash code
            Person personSameName = new Person("Robert", "different@example.com", "000000000", new Address());
            Console.WriteLine("\nEquals test: " + personWithAddress.Equals(personSameName)); // true
            Console.WriteLine("== operator test: " + (personWithAddress == personSameName)); // true
            Console.WriteLine("!= operator test: " + (personWithAddress != personNoAddress)); // true

            // Test GetHashCode
            Console.WriteLine("\nHash codes:");
            Console.WriteLine("personWithAddress: " + personWithAddress.GetHashCode());
            Console.WriteLine("personSameName: " + personSameName.GetHashCode());

            // -------------------------------
            // Test Student
            // -------------------------------
            Console.WriteLine("\n=== Testing Student Class ===");
            // Create a new Student with default values
            Student defaultStudent = new Student();
            Console.WriteLine("Default Student:");
            Console.WriteLine(defaultStudent);

            // Create a new Student using the constructor with no Enrollment
            Student studentNoEnrollment = new Student(
                "12345678",
                "Diploma of IT",
                new DateTime(2024, 1, 15)
            );
            Console.WriteLine("\nStudent without custom Enrollment:");
            Console.WriteLine(studentNoEnrollment);

            // Create a new Student using the constructor with custom Enrollment
            Subject subject = new Subject("IT101", "Intro to IT", 10);
            Enrollment enrollment = new Enrollment(subject, new DateTime(2024, 2, 1), "Pass", "1");
            Student studentFull = new Student(
                "Alice", "alice@example.com", "123456789", address,
                "87654321", "Bachelor of CS", new DateTime(2023, 7, 10), enrollment
            );
            Console.WriteLine("\nStudent with full details:");
            Console.WriteLine(studentFull);

            // Test Property Accessor Methods
            studentFull.PersonName = "Alicia";
            studentFull.PersonEmail = "alicia@example.com";
            studentFull.PersonPhoneNumber = "987654321";
            studentFull.PersonAddress = new Address(22, "Queen St", "Melbourne", "VIC", "3000");
            studentFull.StudentID = "88888888";
            studentFull.Program = "Master of Data Science";
            studentFull.DateRegistered = new DateTime(2025, 1, 1);
            studentFull.StudentEnrollment = new Enrollment(
                new Subject("DS101", "Data Science Basics", 12),
                DateTime.Now,
                "Credit",
                "1"
            );
            Console.WriteLine("\nAfter modifying properties:");
            Console.WriteLine(studentFull);

            // Test equality and hash code
            Student sameIDStudent = new Student("88888888", "Different Program", DateTime.Now);
            Console.WriteLine("\nEquals test (same ID): " + studentFull.Equals(sameIDStudent)); // true
            Console.WriteLine("== operator test: (same ID)" + (studentFull == sameIDStudent)); // true
            Console.WriteLine("!= operator test: (student no enrollment)" + (studentFull != studentNoEnrollment)); // true

            // Test GetHashCode
            Console.WriteLine("\nHash codes:");
            Console.WriteLine("studentFull: " + studentFull.GetHashCode());
            Console.WriteLine("sameIDStudent: " + sameIDStudent.GetHashCode());

            // Test CompareTo
            Student studentA = new Student("11111111", "Program A", DateTime.Now);
            Student studentB = new Student("22222222", "Program B", DateTime.Now);
            Console.WriteLine("\nCompareTo test:");
            Console.WriteLine("studentA vs studentB: (should be -1)" + studentA.CompareTo(studentB)); // negative
            Console.WriteLine("studentB vs studentA: (should be 1)" + studentB.CompareTo(studentA)); // positive
            Console.WriteLine("studentA vs sameIDStudent: (should be 0)" + studentA.CompareTo(studentA)); // 0

            Console.ReadKey();
        }
    }
}
