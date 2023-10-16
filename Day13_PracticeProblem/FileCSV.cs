using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_File_IO
{
    internal class FileIOCSV
    {
        public void File_IO__CSV()
        {

            // Example data for CSV file
            string FilePath = @"C:\Users\ugesh\source\repos\Day13_PracticeProblem\Day13_PracticeProblem\FileCSV.csv";

            string csvData = "Name,Age,Location\nkumar,22,india\nhari,25,Los Angeles\nvanapalli,16,Us";

            // Write to a CSV file
            File.WriteAllText(FilePath, csvData);

            // Read from a CSV file
            string csvContent = File.ReadAllText(FilePath);

            Console.WriteLine("CSV File Content:\n" + csvContent);


        }
    }
}