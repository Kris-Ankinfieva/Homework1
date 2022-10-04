//  Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Веведите первое число: ");
int a = int.Parse (Console.ReadLine());
Console.WriteLine ("Веведите второе число: ");
int b = int.Parse (Console.ReadLine());
Console.WriteLine ("Веведите третье число: ");
int c = int.Parse (Console.ReadLine());
if (a > b)
{
    Console.WriteLine ($"Число {a} является максимальным");

}
else if (b > c)
{
    Console.WriteLine ($"Число {b} является максимальным");
}
else if (c > a)
{
    Console.WriteLine ($"Число {c}является максимальным");
}
