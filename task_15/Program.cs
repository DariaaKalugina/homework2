
// task15
Console.Write("Введите цифру, обозначающую день недели: ");
int d = Convert.ToInt32(Console.ReadLine());
while (d < 1 || d > 7)
{
    Console.Write("Вы ошиблись! Введите день недели: ");
    d = Convert.ToInt32(Console.ReadLine());
}
if (d==6 || d==7)
    Console.Write("Это выходной!");
else
    Console.Write("Это не выходной!");
