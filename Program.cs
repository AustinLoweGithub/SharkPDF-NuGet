using System;
using Shark.PdfConvert;

namespace _4_9_21_Afternoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attempting to create a pdf using Shark.PdfConvert");

            Console.WriteLine("\n What is the name for your pdf?");

            string fileName = Console.ReadLine();

            string filePath = @"c:\temp\" + fileName + ".pdf";

            Console.WriteLine("Enter the text for the paragraph tag");

            string paragraphText = Console.ReadLine();

            Console.WriteLine("Enter the text for the h1 tag");

            string h1Text = Console.ReadLine();


            string content = @"!DOCTYPE html><html><body><h1>" + h1Text + @"</h1><p>" + paragraphText + @"</p></body></html>";


            Shark.PdfConvert.PdfConvert.Convert(new PdfConversionSettings
            {

                Title = "My First Time Using Shark.PdfConvert",
                Content = content,
                OutputPath = filePath,

            });

            Console.WriteLine("Converted successfully. File is at: " + filePath);

            Console.ReadLine();

        }
    }
}
