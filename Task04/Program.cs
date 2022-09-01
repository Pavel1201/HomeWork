
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
Console.Write("Четные числа: ");
while(count <= N)
{
    if(count%2 == 0)
    {
        Console.Write($"{count} ");
    }


    count++;
}
