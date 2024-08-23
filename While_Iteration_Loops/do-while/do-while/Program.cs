/*
* The do-while statement executes a statement or a block of statements while a
 * specified Boolean expression evaluates to true.
 * Because that expression is evaluated after each execution of the loop,
 * a do-while loop executes one or more times.
*/

// Write a do-while statement to break when a certain random number is generated
Console.WriteLine("Example One:\n");
Random randomOne = new Random();
int currentOne = 0;

do
{
 currentOne = randomOne.Next(1, 11);
 Console.WriteLine(currentOne);

} while (currentOne != 7);
Console.WriteLine("End of example One\n\n");

// Write a while statement that iterates only
// while a random number is greater than some value
Console.WriteLine("Example Two\n");
Random randomTwo = new Random();
int currentTwo = randomTwo.Next(1, 11);

while (currentTwo >= 3)
{
 Console.WriteLine(currentTwo);
 currentTwo = randomTwo.Next(1, 11);
}
Console.WriteLine($"Last number: {currentTwo}");
Console.WriteLine("End of example two\n\n");

// Example three - Use the continue statement to step directly to the Boolean expression.
Console.WriteLine("Example three:\n");
Random randomThree = new Random();
int currentThree = randomThree.Next(1, 11);

do
{
 currentThree = randomThree.Next(1, 11);
 if (currentThree >= 8) continue;
 Console.WriteLine(currentThree);
} while (currentThree != 7);
Console.WriteLine("End of example three\n\n");

// Code Challenge - Role Playing game battle challenge
// Initialize the Hero and Monster HP.
int heroHealth = 10;
int monsterHealth = 10;
// Init Hero and Monster attack points
int heroAttack = 0;
int monsterAttack = 0;

// Random attack points
Random attackPts = new Random();
int attack = attackPts.Next(1, 11);

while (heroHealth > 0 && monsterHealth > 0)
{
 // Hero
 heroAttack = attackPts.Next(1, 11);
 Console.WriteLine($"The hero did {heroAttack} in damage!");
 monsterHealth = monsterHealth - heroAttack;
 if (monsterHealth <= 0)
 {
  Console.WriteLine("The monster has perished.");
  break;
 }

 Console.WriteLine($"The monster has {monsterHealth} points left.");
 Console.WriteLine("");
 // Monster
 monsterAttack = attackPts.Next(1, 11);
 Console.WriteLine($"The monster did {monsterAttack} in damage!");
 heroHealth = heroHealth - monsterAttack;
 if (heroHealth <= 0)
 {
  Console.WriteLine("The hero has perished.");
  break;
 }

 Console.WriteLine($"The hero has {heroHealth} points left.");
 Console.WriteLine("");
}


