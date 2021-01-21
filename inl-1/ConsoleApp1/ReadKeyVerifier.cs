using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changecalculator.consoleapp
{
    public class InputVerifier
    {
        public bool VerifyPrice(string input)
        {
            var isANumber = int.TryParse(input, out var result);

            return isANumber;
        }
    }
}
