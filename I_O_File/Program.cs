using System;
using System.IO;

namespace I_O_File
{
    class Program
    {
        static void Main(string[] args)
        {
            // to write to a file use the 'StreamWriter' object
          
            
            // loop this
            //string mikeString = "I like tomato soup.";

            //for(int i = 0; i < mikeString.Length; i++)
            //{
               // writer.Write(mikeString[i]);
            //}

            // have to close the process to close the connection b/n this file and file being written
            //writer.Close();
            //int interator = 1;
            // foreach(char c in mikeString)
            // { 
            //     StreamWriter writer = new StreamWriter("file.txt", true);
            //     writer.WriteLine($"{interator++} {mikeString}");
            //     writer.Close();
            //     //calls int in concatonation so you don't call it later
            // }
        
            StreamReader reader = new StreamReader("file.txt");
            
            // int i = 0;
            // while(reader.EndOfStream)
            // {
            //   string str = reader.ReadLine();
            //   Console.WriteLine($"{i++}{str}");
            // }

            //int i = 0;
            string str = "";
            while(!reader.EndOfStream)
            {
                str += reader.ReadLine() + " "; 
            }
            Console.WriteLine(str);

        }
    }
}
