using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    public class SystemIOException
    {
        string fileName = "Advanced.txt";

        public void FileName()
        {
            try
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine("failed to read file");
                Console.WriteLine(fileNotFound.Message);
            }
        }
    }
}
