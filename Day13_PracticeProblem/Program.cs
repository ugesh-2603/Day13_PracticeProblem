using Day_File_IO;

namespace Day13_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileIOText fileIOText = new FileIOText();
            fileIOText.File_IOText();

            FileIOCSV fileIOCSV = new FileIOCSV();
            fileIOCSV.File_IO__CSV();

            FileIO_JSON fileIO_JSON = new FileIO_JSON();
            fileIO_JSON.File_IOJSON();
        }
    }
}
