int a;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
a = a / 100 * 100 + a % 10 * 10 + a % 100 / 10;
Console.WriteLine($"Число {a}");
