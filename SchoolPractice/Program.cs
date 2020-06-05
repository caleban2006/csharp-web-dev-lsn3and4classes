using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student myStudent = new Student();
            myStudent.name = "Logan";
            myStudent.studentId = 13;
            myStudent.numberOfCredits = 1;
            myStudent.gpa = 4.0;

            Console.WriteLine("Name: {0}, Student ID: {1}, Credits: {2}, GPA: {3}", myStudent.name, myStudent.studentId, myStudent.numberOfCredits, myStudent.gpa);

        }
    }
}
