using System;

namespace Assignment3Solving
{
    class Student
    {
        // Data members
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Semester { get; set; }
        public string Branch { get; set; }
        public int[] Marks { get; set; } = new int[5];

        // Constructor to initialize student details
        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            RollNo = rollNo;
            Name = name;
            Class = className;
            Semester = semester;
            Branch = branch;
        }

        // Method to input marks for 5 subjects
        public void GetMarks()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }

        // Method to calculate and display result
        public void DisplayResult()
        {
            int totalMarks = 0;
            bool hasFailedSubject = false;

            foreach (int mark in Marks)
            {
                totalMarks += mark;
                if (mark < 35)
                {
                    hasFailedSubject = true;
                }
            }

            double average = totalMarks / 5.0;

            if (hasFailedSubject)
            {
                Console.WriteLine("Result: Failed (One or more subjects have marks below 35)");
            }
            else if (average < 50)
            {
                Console.WriteLine("Result: Failed (Average marks below 50)");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        // Method to display all student details
        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine("Marks: " + string.Join(", ", Marks));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a student object
            Student student = new Student(1, "John Doe", "10th Grade", "Second", "Science");

            // Get marks for the student
            student.GetMarks();

            // Display student data and result
            student.DisplayData();
            student.DisplayResult();

            Console.ReadKey();
        }
    }
}