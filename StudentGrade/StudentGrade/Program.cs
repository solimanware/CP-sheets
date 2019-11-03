using System;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double subject1, subject2, subject3, subject4, subject5, studentGrade, totalGrade;
            totalGrade = 500;
            Console.Write("Subject1: ");
            subject1 = double.Parse(Console.ReadLine());
            Console.Write("Subject2: ");
            subject2 = double.Parse(Console.ReadLine());
            Console.Write("Subject3: ");
            subject3 = double.Parse(Console.ReadLine());
            Console.Write("Subject4: ");
            subject4 = double.Parse(Console.ReadLine());
            Console.Write("Subject5: ");
            subject5 = double.Parse(Console.ReadLine());
            studentGrade = (subject1 + subject2 + subject3 + subject4 + subject5) / totalGrade;
            Console.WriteLine("Total Grade = {0}", studentGrade);



        }
    }
}
