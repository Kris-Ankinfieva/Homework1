//  Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Веведите первое число: ");
int a = int.Parse (Console.ReadLine());
Console.WriteLine ("Веведите второе число: ");
int b = int.Parse (Console.ReadLine());
if (a > b)
{
    Console.WriteLine ($"Число {a} является больше, чем чем число {b}");

}
else if (b > a)
{
    Console.WriteLine ($"Число {b} является больше, чем чем число {a}");
}
else if (a == b)
{
    Console.WriteLine ($"Число {a} и число {b} равны между собой");
}
