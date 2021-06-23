using System;
using System.Collections.Generic;

namespace PrimeNumbersTest
{
    public class Program
    {

        public static void Main(string[] args)
        {
            PrimeLogic primeLogic = new PrimeLogic();
            ListLogic listLogic = new ListLogic();

            listLogic.primeMemory = new List<int>();

            int number;
           
            Console.WriteLine("Hello! Welcome to my program :)");
            
            do
            {
                Console.WriteLine("Please give me the amount of prime numbers, press 0 to exit: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    String result;
                    result = primes(number, listLogic, primeLogic);
                    Console.WriteLine(result);

                }
                   
                else
                    Console.WriteLine("Please enter a valid number");
            } while (number != 0);

        }

        /*  
         *  Function: primes
         *  Purpose: Call the methods that involve the prime and memory logic 
         */
        public static string primes(int primeRequest, ListLogic memory, PrimeLogic primeLogic)
        {
            //Variable Declaration
            int requestCount = 1, primeTest, memoryCount;
            String result = "[";
            bool res;


            //Memory logic
            memoryCount = memory.checkMemory(primeRequest, memory.primeMemory);

            if (memoryCount > 0)
            {
                result = result + memory.printMemory(memory.primeMemory, memoryCount);
                primeTest = memory.primeMemory[memoryCount-1]+1;
                requestCount = memoryCount;
            }
            else
            {
                //if the memory is empty we start with the prime number 2
                primeTest = 2;
            }

            //Prime numbers calculation
            if (memoryCount < primeRequest)
            {
                do
                {
                    if (primeTest == 2)
                    {
                        result = result + primeTest + " ";
                        memory.primeMemory.Add(primeTest);
                    }

                    if (primeTest % 2 != 0)
                    {
                        res = primeLogic.checkNumber(primeTest);

                        if (res)
                        {
                            result = result + primeTest + " ";
                            memory.primeMemory.Add(primeTest);
                            requestCount++;
                        }
                    }

                    primeTest++;

                } while (requestCount < primeRequest);
            }   

            result = result + "]";

            return result;
        }
    }
}
