using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOOP
{
    class Program
    {
        static void Main()
        {
            Base();
            Console.ReadKey();
        }
        
        static void Base()
        {
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y= ");
            int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}={x+y}"); //а могло бы быть всё гораздо проще...
            Operations operations = new Operations(x, y);
            operations.AddOperation(Print);
            operations.Sum();
            operations.DeleteOperation(Print);
        }

        static void Print(string text) => Console.WriteLine(text);
    }
}
