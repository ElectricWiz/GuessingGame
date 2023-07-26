// See https://aka.ms/new-console-template for more information
Random rand  = new Random();
int numToGuess = rand.Next(1, 101);
int currentGuess;
int guesses = 0;
bool victoria = false;

Console.WriteLine("Dame cualquier adivinanza entre 1 y 100");
currentGuess = Convert.ToInt16(Console.ReadLine());

do
{
    if (currentGuess < 1 || currentGuess > 100)
    {
        guesses++;
        Console.WriteLine("Afuera del rango");

        Console.WriteLine("Dame cualquier adivinanza entre 1 y 100");
        currentGuess = Convert.ToInt16(Console.ReadLine());
    }
    else if (currentGuess > numToGuess)
    {
        guesses++;
        Console.WriteLine("Tu adivinanza es mas grande que el numero que debes adivinar");

        Console.WriteLine("Dame cualquier adivinanza entre 1 y 100");
        currentGuess = Convert.ToInt16(Console.ReadLine());
    }
    else if (currentGuess < numToGuess)
    {
        guesses++;
        Console.WriteLine("Tu adivinanza es muy chica!!");

        Console.WriteLine("Dame cualquier adivinanza entre 1 y 100");
        currentGuess = Convert.ToInt16(Console.ReadLine());
    }
    else
    {
        victoria = true;
        Console.WriteLine("Ganaste!!!!!");
        Console.WriteLine("Fueron " + guesses + " intentos!!");

        Console.WriteLine("Dame cualquier adivinanza entre 1 y 100");
        currentGuess = Convert.ToInt16(Console.ReadLine());
    }
} while (!victoria);