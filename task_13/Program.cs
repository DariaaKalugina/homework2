// task13
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99)
    Console.WriteLine($"Третье число: {a%10}");
else
    Console.WriteLine("Третьей цифры нет");