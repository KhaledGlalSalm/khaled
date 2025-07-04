# khaled using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Math { get; set; }
    public int English { get; set; }
    public int Science { get; set; }
    public double Average { get; set; }
    public string Result { get; set; }
}

class Program
{
    static double CalculateAverage(int math, int english, int science)
    {
        return (math + english + science) / 3.0;
    }

    static string DetermineResult(double average)
    {
        return average >= 50 ? "PASS" : "FAIL";
    }

    static void DisplayStudentInfo(Student student)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Student: {student.Name}");
        Console.WriteLine($"Math: {student.Math}, English: {student.English}, Science: {student.Science}");
        Console.WriteLine($"Average: {student.Average:F2}");
        Console.WriteLine($"Result: {student.Result}");
        Console.WriteLine("--------------------------------");
    }

    static int ReadInt(string prompt)
    {
        int value;
        do
        {
            Console.Write(prompt);
        }
        while (!int.TryParse(Console.ReadLine(), out value));
        return value;
    }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        int numberOfStudents = ReadInt("Enter the number of students: ");

        for (int i = 1; i <= numberOfStudents; i++)
        {
            Student student = new Student();

            Console.Write($"\nEnter student {i} name: ");
            student.Name = Console.ReadLine();

            student.Math = ReadInt("Enter Math grade: ");
            student.English = ReadInt("Enter English grade: ");
            student.Science = ReadInt("Enter Science grade: ");

            student.Average = CalculateAverage(student.Math, student.English, student.Science);
            student.Result = DetermineResult(student.Average);

            students.Add(student);
        }

        Console.WriteLine("\n===== Students Report =====");
        foreach (var student in students)
        {
            DisplayStudentInfo(student);
        }
    }
’
