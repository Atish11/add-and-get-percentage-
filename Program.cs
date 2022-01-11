using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_and_get_percentage
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[5];
            double sum = 0;
            Console.WriteLine("Enter marks for 5 Subjects: (Adv. programming," +
                "Research, BI, App. development, Web Development)");
            for(int i = 0; i<5; i++)
            {
                double tempMarks = Convert.ToDouble(Console.ReadLine());
                a[i] = tempMarks;
                sum += tempMarks;
            }
            Console.WriteLine("The sum of all the marks is: {0}", sum);
            Console.WriteLine("The percentage is: {0}%", sum / 500 * 100);
            Console.ReadKey();
        }
    }
}
