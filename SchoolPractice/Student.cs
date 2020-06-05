using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    class Student
    {
        private string Name;
        private int StudentId;
        private int NumberOfCredits;
        private double Gpa;
        public string name { get; set; }
        public int studentId { get; set; }
        public int numberOfCredits { get; set; }
        public double gpa { get; set; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student() 
        {
            
        }
    }
}
