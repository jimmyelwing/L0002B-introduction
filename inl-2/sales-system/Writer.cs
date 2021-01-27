using System;
using System.IO;

namespace sales_system
{
    public class Writer
    {
        private StreamWriter _stream = new StreamWriter("c:\\Temp\\result.txt");

        public void WriteToConsoleAndFile(string input)
        {
            Console.WriteLine(input);
            _stream.WriteLine(input);
        }

        public void CloseStream()
        {
            _stream.Close();
        }
    }
}
