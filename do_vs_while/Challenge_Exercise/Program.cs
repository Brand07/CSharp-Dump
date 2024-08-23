/*
 * Author: Brandon Y.
 * Date: 8/23/2024
 * do vs while - challenge exercise
*/

// Manage user input
// nullable type string
string? readResult;
Console.WriteLine("Enter a string: ");
do
{
 readResult = Console.ReadLine();
} while (readResult == null);