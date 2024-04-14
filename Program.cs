namespace ScriptCARPOOL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string inputPath = "data-KI_pvqgfwRDKdPSb8WNDq.csv";
        string inputPathFile = AppDomain.CurrentDomain.BaseDirectory + @"../../../" + inputPath;

        string outputPath = "CARPOOL.csv";
        string outputPathFile = AppDomain.CurrentDomain.BaseDirectory + @"../../../" + outputPath;
        

        ExtractAndWriteCSV(inputPathFile, outputPathFile);
    }

    static void ExtractAndWriteCSV(string inputPathFile, string outputPathFile)
    {
        try
        {
            using (StreamReader sr = new StreamReader(inputPathFile))
            {
                using (StreamWriter sw = new StreamWriter(outputPathFile))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] columns = line.Split(',');

                        string firstName = columns[0];
                        string lastName = columns[1];
                        string phoneNumber = columns[2];
                        string mail = columns[3];
                        sw.WriteLine($"{firstName},{lastName},{mail}");
                        
                    }
                }
            }

            Console.WriteLine("Yeepee");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
}
