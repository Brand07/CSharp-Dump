/*
 * Author: Brandon Y.
 * Date: 8/23/2024
 * do vs while - challenge exercise
*/

// Manage user input
// nullable type string
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
 readResult = Console.ReadLine();
 if (readResult != null)
 {
  if (readResult.Length >= 3)
  {
   validEntry = true;
  }
  else
  {
   Console.WriteLine("Your input is invalid, please try again.");
  }
 }
} while (validEntry == false);

// Challenge Project
// https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements