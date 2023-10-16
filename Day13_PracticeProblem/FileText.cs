using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_File_IO
{
    internal class FileIOText
    {
        public void File_IOText()
        {
            // Define the file path
            string filePath = @"C:\Users\ugesh\source\repos\Day13_PracticeProblem\Day13_PracticeProblem\TextFile1.txt";

            WriteToFile(filePath);

            ReadFromFile(filePath);
        }

        static void WriteToFile(string filePath)
        {
            try
            {
                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Hello, this is a sample text file.");
                    writer.WriteLine("You can add more lines here.");
                }

                Console.WriteLine("Text has been written to the file.");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        static void ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    Console.WriteLine("Contents of the text file:");

                    // Read and display each line of the file
                    line = File.ReadAllText(filePath);
                    Console.ReadKey();
                    Console.WriteLine(line);
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }

}