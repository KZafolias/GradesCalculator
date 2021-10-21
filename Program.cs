using System;
//grades are on 20/20
namespace SchoolGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter English Grade: ");
            double eng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Maths Grade: ");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Computer Science Grade: ");
            double cps = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Greek Grade: ");
            double gre = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter History Grade: ");
            double his = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Science Grade: ");
            double sci = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Biology Grade: ");
            double bio = Convert.ToDouble(Console.ReadLine());

            double average = (eng + math + cps + gre + his + sci + bio) / 7;

            if(average >= 10)
            {
                Console.WriteLine("The student " + name + " passes");
            }
            else
            {
                Console.WriteLine("Student " + name + " failed and has to repeat a grade");
            }

            Console.Write("The general avarage of the student " + name + "is " + average);
        }
    }
}
