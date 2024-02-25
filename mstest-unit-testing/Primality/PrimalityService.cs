namespace Primality;

public class PrimalityService
{
    public bool IsPrime(long number)
    {
        // As of April 2023, C# does not have a built-in, predefined method in its standard library
        // (similar to Java's BigInteger.isProbablePrime() method) for checking if a number is prime.
        // In C#, prime number checking is typically done through custom implementation.
        if (number <= 1) //el 1 no es primo lol
            return false;
        if (number <= 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for(int i = 5; i < number; i++) //esta bien asi? vi que hay formulas pero son muy raras
        {
            if(i % number == 0)
                return false;
        }
        // TODO: Complete the code (Replace the return statement if needed).
        return true;
    }
}
