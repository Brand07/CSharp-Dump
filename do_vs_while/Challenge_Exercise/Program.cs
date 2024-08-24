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

// Code Project 1 - Write code that validates integer input
int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter an integer between 5 and 10:");
do
{
 string? input = Console.ReadLine();
 if (int.TryParse(input, out numericValue))
 {
  if (numericValue >= 5 && numericValue <= 10)
  {
   validNumber = true;
   Console.WriteLine($"Your input of {numericValue} is valid.");
  }
  else
  {
   Console.WriteLine("Sorry, you entered an invalid integer.");
  }
 }
 else
 {
  Console.WriteLine("Please enter a valid integer.");
 }
} while (validNumber == false);

// Challenge Project 2 - Write code that validates string input
string? userInput;
bool validString = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User.):");
do
{
 userInput = Console.ReadLine();
 if (userInput != null)
 {
  if (userInput.ToLower() == "administrator" || userInput.ToLower() == "manager" || userInput.ToLower() == "user")
  {
   validString = true;
   Console.WriteLine($"Your role of {userInput} is valid.");
  }
  else
  {
   Console.WriteLine("Sorry, you entered an invalid role name.");
  }
 }
} while (validString == false);

// Challenge Project 3 - Write code that processes the contents of a string array
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringCount; i++)
{
 myString = myStrings[i];
 periodLocation = myString.IndexOf(".");

 string mySentence;

 while (periodLocation != -1)
 {
  mySentence = myString.Remove(periodLocation + 1);
  
  myString = myString.Substring(periodLocation + 1);
  
  // Remove leading space
  myString = myString.TrimStart();
  
  //update the comma location
  periodLocation = myString.IndexOf(".");
  Console.WriteLine(mySentence);
 }

 mySentence = myString.TrimStart();
 Console.WriteLine(mySentence);
}