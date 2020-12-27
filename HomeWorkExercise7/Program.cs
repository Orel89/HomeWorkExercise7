using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allWords = new List<string>();
            string allCharactersByEndOfStream = String.Empty;
            string allCharactersByReadToEnd = String.Empty;
            int rowCount = 0;
            string[] arrayOfRows;
            using (var sr = new StreamReader("Info.txt")) //C:\Users\Алексей\source\repos\HomeWork\TEST\bin\Debug\Info.txt  Текстовый файл загрузил на гидхаб
            {
                allCharactersByReadToEnd = sr.ReadToEnd();
                arrayOfRows = allCharactersByReadToEnd.Split('/', '@', '<', '>', '#', '"', '?', '-', '+', ':', '!', '^', '%', '*', ' ', ',', '.', '\n', '\r', '(', ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
                foreach (var item in arrayOfRows)
                {
                    if (item != "")
                    {
                        allWords.Add(item);
                    }
                }
                sr.BaseStream.Position = 0;
                while (sr.EndOfStream != true)
                {
                    allCharactersByEndOfStream += sr.ReadLine();
                    rowCount++;
                }

            }
            int totalChar = allCharactersByEndOfStream.ToCharArray().Length;
            Console.WriteLine($"Totat characters in Info.txt: {totalChar}\nTotal rows in Info.txt: {rowCount}\nTotal words in the file: {allWords.Count}");
            Console.ReadKey();
        }
    }
}
