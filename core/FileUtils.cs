using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logFilter.core
{
    internal class FileUtils
    {
        // Path to the log file
        string logFilePath = "";
        private string outputFilePath = "";


        public List<string> readFileContents(string readFilePath, string savePath,  string searchKeyWord)
        {
            logFilePath = readFilePath;
            outputFilePath = savePath;

            List<string> errorLines = new List<string>();

            try
            {
                // Check if the log file exists
                if (File.Exists(logFilePath))
                {
                    // Open the log file for reading
                    using (StreamReader sr = new StreamReader(logFilePath))
                    {
                        // Open the output file for writing
                        using (StreamWriter sw = new StreamWriter(outputFilePath))
                        {
                            string line;
                            // Read each line from the log file
                            while ((line = sr.ReadLine()) != null)
                            {
                                // Check if the line contains the word "error"
                                if (line.IndexOf(searchKeyWord, StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    // Write the line to the output file
                                    sw.WriteLine(line);
                                    errorLines.Add(line);
                                    
                                }
                            }
                        }
                    }


                }
                else
                {
                    errorLines.Add("error: The log file does not exist");
                }
            }
            catch (Exception e)
            {
               errorLines.Add("error: " + e.Message);
            }

            return errorLines;

        }
    }
}
