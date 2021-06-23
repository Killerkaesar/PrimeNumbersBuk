using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbersTest
{
    public class PrimeLogic : IPrimeLogic
    {

        public bool checkNumber(int primeCount)
        {
            int temp = 2;

            while (temp * temp <= primeCount)
            {
                if (primeCount % temp == 0)
                {
                    return false;
                }
                temp += 1;
            }
            return true;
        }

       
    }
}
