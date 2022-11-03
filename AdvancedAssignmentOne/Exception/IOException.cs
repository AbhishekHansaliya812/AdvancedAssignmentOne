using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    /* Class for IO Exception */
    public class IOException
    {
        /* Method to read file */
        public void FileName(string fileName)
        {
            /* try block - print texts from file */
            try
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
            /* catch block - print exception message */
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine("failed to read file");
                Console.WriteLine(fileNotFound.Message);
            }
            /* finally block */
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
        }
    }
}
