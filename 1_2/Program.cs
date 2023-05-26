Console.Clear();
Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число в");
int b = int.Parse(Console.ReadLine());

if (a > b) Console.WriteLine($"{a} > {b}");
else Console.WriteLine($"{a} < {b}");