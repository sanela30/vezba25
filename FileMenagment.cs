using System;
using System.Collections.Generic;
using System.IO;

namespace vezba25
{
    internal class FileMenagment
    {
        private static string fileName = @"D:\SACUVANO\RajakKurs\25.cas\New folder\imenik.txt";

        public static void Store(string firstName, string lastName, string address,string phone)
        {
            using(StreamWriter fileHandle = new StreamWriter(fileName, true))
            {
                fileHandle.WriteLine("{0};{1};{2};{3}",firstName,lastName,address,phone);
            }
        }

        public static List<string>Read()
        {
            List<string> listOfNames = new List<string>();

            using (StreamReader fileHandle = new StreamReader(fileName))
            {
                string fileContents = "";
                while((fileContents = fileHandle.ReadLine()) != null)
                {
                    listOfNames.Add(fileContents);
                }

            }

            return listOfNames;
        }
    }
}
