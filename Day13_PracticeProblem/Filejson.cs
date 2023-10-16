using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Day_File_IO
{
    internal class FileIO_JSON
    {
        public void File_IOJSON()
        {

            var jsonData = new
            {
                Name = "Kumar",
                Age = 22,
                Location = "Chennai"


            };

            string FilePath = @"C:\Users\ugesh\source\repos\Day13_PracticeProblem\Day13_PracticeProblem\Filejson.json";

            string jsonContent = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
            File.WriteAllText(FilePath, jsonContent);

            string jsonText = File.ReadAllText(FilePath);
            var deserializedData = JsonConvert.DeserializeObject(jsonText);

            Console.WriteLine("JSON File Content:");
            Console.WriteLine(JsonConvert.SerializeObject(deserializedData, Formatting.Indented));


        }
    }
}
