// See https://aka.ms/new-console-template for more information

using TAFESAEnrolmentSystem;

Student student1 = new Student();
Console.WriteLine("Student 1 (default):");
Console.WriteLine(student1);

// Test Property Accessor Methods
student1.StudentID = "S1234567";
student1.Program = "IT Programming";
student1.DateRegistered = new DateTime(2023, 3, 15);

// Set person details via inherited accessors
student1.PersonName = "Alice Johnson";
student1.PersonEmail = "alice@example.com";
student1.PersonPhoneNumber = "0412 345 678";
student1.PersonAddress = new Address(22, "Main St", "Adelaide", "SA", "5000");

Console.WriteLine("\nUpdated Student 1 Info:");
Console.WriteLine("Name: " + student1.PersonName);
Console.WriteLine("Email: " + student1.PersonEmail);
Console.WriteLine("Phone: " + student1.PersonPhoneNumber);
Console.WriteLine("Address: " + student1.PersonAddress);
Console.WriteLine("Student ID: " + student1.StudentID);
Console.WriteLine("Program: " + student1.Program);
Console.WriteLine("Date Registered: " + student1.DateRegistered.ToShortDateString());

// Create a new student using full constructor
Subject subject = new Subject("ICT101", "Intro to Programming", 1200.00);
Enrollment enrollment = new Enrollment(subject, new DateTime(2023, 3, 15), "HD", "Semester 1");

Student student2 = new Student(
    "Bob Smith",
    "bob@example.com",
    "0423 456 789",
    new Address(45, "North Tce", "Adelaide", "SA", "5005"),
    "S7654321",
    "Networking",
    new DateTime(2022, 8, 10),
    enrollment
);

Console.WriteLine("\nStudent 2 (full constructor):");
Console.WriteLine(student2);

// Compare students using overloaded operators
Console.WriteLine("\nStudent1 == Student2? " + (student1 == student2));
student2.StudentID = "S1234567"; // Same ID now
Console.WriteLine("Student ID for Student 2 has been changed to S1234567.");
Console.WriteLine("Student1 == Student2 after same ID? " + (student1 == student2));

Console.ReadKey();

