using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Exploreif()
        {
            int a=5;
            int b=3;
            if (a+b>10)
                Console.WriteLine("Answer is greater then 10.");
            else 
                Console.WriteLine("Answer is less then 10.");

            int c=4;
            if ((a+b+c>10) && (a==b))
            {
                Console.WriteLine("Answer is greater then 10.");
                Console.WriteLine("And the first number is equal to second");
            }
            else
            {
                Console.WriteLine("Answer is less then 10.");
                Console.WriteLine("And the first number is not equal to second");
            }
            if ((a+b+c>10) || (a==b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }
        static void testwhile()
        {
            int counter=0;
            while (counter<10)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }
            counter=0;
            do
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            } while (counter<10);
        }
        static void testfor()
        {
            for (int index=0; index <10; index++)
            {
                Console.WriteLine($"Index is {index}");
            }
        }
        static void nestedfor()
        {
            for (int row=1; row<11; row++)
            {
                for (char column='a'; column<'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row},{column})");
                }
                
           
                
            }
        }
        static void challenge()
        {
            int suma=0;
            for (int i=0; i<21; i++)
            {
                if (i%3==0)
                {
                    suma=suma+i;
                }
            }
            Console.WriteLine($"Suma je: {suma}");
        }
        static void Main(string[] args)
        {
            //Exploreif();
            //testwhile();
            //testfor();
            //nestedfor();
            challenge();
        }
    }
}
