using System;
using System.Text;

namespace WorkingwithText
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
          
            string greeting = "Hello, ";
            string name = "John";
            string message = greeting + name + "! Welcome to the world of C#.";
            Console.WriteLine(message);

            
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("This is a long ");
            stringBuilder.Append("string that we want to ");
            stringBuilder.Append("manipulate efficiently. ");
            stringBuilder.AppendFormat("We can also insert values like {0} and {1}.", 42, 3.14);
            string result = stringBuilder.ToString();
            Console.WriteLine(result);
        }
    }
}
