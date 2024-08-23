/*
* The do-while statement executes a statement or a block of statements while a
 * specified Boolean expression evaluates to true.
 * Because that expression is evaluated after each execution of the loop,
 * a do-while loop executes one or more times.
*/

// Write a do-while statement to break when a certain random number is generated
Random random = new Random();
int current = 0;

do
{
 current = random.Next(1, 11);
 Console.WriteLine(current);

} while (current != 7);
