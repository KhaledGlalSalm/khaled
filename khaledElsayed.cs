
using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Math;
    public int English;
    public int Science;
    public double Average;
    public string Result;
}

class Program
{
    // دالة لحساب المتوسط
    static double CalculateAverage(int math, int english, int science)
    {
        return (math + english + science) / 3.0;
    }

    // دالة لتحديد النجاح أو الرسوب
    static string DetermineResult(double average)
    {
        return average >= 50 ? "PASS" : "FAIL";
    }

    // دالة لعرض البيانات
    static void DisplayStudentInfo(Student student)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Student: {student.Name}");
        Console.WriteLine($"Math: {student.Math}, English: {student.English}, Science: {student.Science}");
        Console.WriteLine($"Average: {student.Average:F2}");
        Console.WriteLine($"Result: {student.Result}");
        Console.WriteLine("--------------------------------");
    }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfStudents; i++)
        {
            Student student = new Student();

            Console.Write($"
Enter student {i} name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Math grade: ");
            student.Math = int.Parse(Console.ReadLine());

            Console.Write("Enter English grade: ");
            student.English = int.Parse(Console.ReadLine());

            Console.Write("Enter Science grade: ");
            student.Science = int.Parse(Console.ReadLine());

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
}
