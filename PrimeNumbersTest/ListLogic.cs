using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbersTest
{
    public class ListLogic : IListLogic
    {
        public List<int> primeMemory;

        public string printMemory(List<int> memory, int num)
        {
            String print = "";
            for (int cont = 0; cont< num; cont++)
            {
                print = print + memory[cont] + " "; 
            }

            return print;
        }

        public int checkMemory(int primeRequest, List<int> primeMemory)
        {
            if (primeMemory.Count > 0)
            {
                if (primeMemory.Count >= primeRequest)
                {
                    return primeRequest;
                }
                else
                {
                    return primeMemory.Count;
                }
            }
            return 0;
        }
    }
}
