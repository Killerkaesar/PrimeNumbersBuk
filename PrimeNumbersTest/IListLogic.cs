using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbersTest
{
    interface IListLogic
    {
        public string printMemory(List<int> memory, int num);
        public int checkMemory(int primeRequest, List<int> primeMemory);

    }
}
