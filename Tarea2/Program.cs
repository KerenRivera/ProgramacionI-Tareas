
Console.WriteLine("----------------Even or Odd------------------");
int chosenNumber;

Console.WriteLine("Please choose a number to know if it is odd or even:");
chosenNumber = int.Parse(Console.ReadLine());

int result = chosenNumber % 2;

if (result == 0)
{
    Console.WriteLine("Is even!");
}
else
{
    Console.WriteLine("It's odd!");
}



