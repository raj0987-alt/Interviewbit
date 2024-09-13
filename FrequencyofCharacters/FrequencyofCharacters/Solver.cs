using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyofCharacters
{
    internal class Solver
    {
        public List<int> ints = new List<int>()
        {
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        public void CalculateVal(string data)
        {
            char[] charArray = data.ToCharArray();
            foreach (char ch in charArray)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    int index = ch - 'a';  // Get the position in the alphabet
                    ints[index]++;
                }
            }

            
        }


    }
}
