using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMessages;
            string userEnters;

            Console.WriteLine("Введите сообщение");
            userEnters= Console.ReadLine();
            Console.WriteLine("Введите количество повторов");
            numberMessages = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberMessages; i++) 
            {
                Console.WriteLine(userEnters);
            }           
        }
    }
}
