using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_system
{
    public class Writer
    {
        private StreamWriter _stream = new StreamWriter("result.txt");

        public void Write(string input)
        {
            _stream.WriteLine(input);

            Console.WriteLine(input);
        }

        public void CloseStream()
        {
            _stream.Close();
        }
    }
}
