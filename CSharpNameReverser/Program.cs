using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNameReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name.");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reverse name: " + reversed);
        }
        // for practice with procedural programming, we separate the console procedures with the method procedures

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);

        }
    }
}
