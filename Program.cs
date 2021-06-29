using System;
using System.IO;


// foreach(string line in lines)
// {
//     string[] columns = line.Split(',');
//     foreach (string column in columns) {
//         // Do something
//     }
// }

namespace Support_Bank_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "./Data/Transactions2014.csv";

            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                Console.WriteLine(line);
                foreach (string column in columns)
                {
                    // Console.Write(column);
                }   
            }
        }
    }
}
