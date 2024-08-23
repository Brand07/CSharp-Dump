// Fizz Buzz Challenge
/*
 * From numbers 1 to 100, if the number is evenly
 * divisible by 3, print Fizz.
 * If the number is evenly divisible by 5, print buzz.
 * If the number is evenly divisible by 3 and 5, print FizzBuzz
 * 
 */

for (int number = 1; number <= 100; number++)
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine($"{number} - FizzBuzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine($"{number} - Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine($"{number} - Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}