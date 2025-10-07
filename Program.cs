using System;

namespace My_personal_portfolio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.Title = "My personal portfolio");
            Console.ReadKey(true);
            Console.ReadKey(false);
            Console.Clear();
            Console.WriteLine("Hello, I'm Noah Kalaile, a passionate software developer with a knack for creating innovative solutions. Welcome to my personal portfolio!");
            Console.ReadKey(true);
            Console.ReadKey(false);
            Console.Clear();
            Console.WriteLine("Feel free to explore my projects, skills and experiences showcased here. I'm excited to share my journey and accomplishments with you.");
            Console.ReadKey(true);
            Console.ReadKey(false);
            Console.Clear();
            Console.WriteLine(args.Length > 0 ? string.Join(" ", args) : "Thank you for visiting my portfolio. Let's connect and create something amazing together!");

        }
    }
}
