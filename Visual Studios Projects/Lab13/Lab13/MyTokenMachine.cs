using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class MyTokenMachine
    {
        // Token Machine Class
        // Keeps track of tokens and quarters
        private int numTokens;
        private int numQuarters;
        const int FULLTOKENS = 100;

        public MyTokenMachine()
        {
            numQuarters = 0;
            numTokens = FULLTOKENS;
        }
        
        public void ResetMethod()
        {
            numQuarters = 0;
            numTokens = FULLTOKENS;
        }

        public void GetTokens()
        {
            numQuarters++;
            numTokens--;
        }

        public int CountTokens()
        {
            return numTokens;
        }

        public int CountQuarters()
        {
            return numQuarters;
        }
    }
}
