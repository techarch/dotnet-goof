using System;
using System.IO;
using System.Text;

namespace dotNet_goof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dotnet-goof");
            Console.WriteLine("Enter the name of a file to display (e.g. README.md):");

            string filePath = "README.md";
            filePath = Console.ReadLine();
            ShowFileContents(filePath);
        }

        private static void ShowFileContents(string filePath)
        {
            string fileContents = File.ReadAllText(filePath, Encoding.UTF8);
            Console.WriteLine($"Contents of {filePath}:\n{fileContents}");
        }
    }
}
