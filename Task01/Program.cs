Console.WriteLine("Введите два числа: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int max = 0;

if (numberA > numberB)
{
     max = numberA;
     Console.WriteLine($"Большее число {max}");
 

}
else 
{

    max = numberB;
    Console.WriteLine($"Большее число {max}");

}