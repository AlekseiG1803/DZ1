Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int i = 2;

while (i < number) 
{
    Console.Write($"{i}, ");
    i = i + 2;
}

if (number % 2 == 0) Console.Write($"{number}");