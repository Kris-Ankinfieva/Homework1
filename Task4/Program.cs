// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("vvedite chislo: ");
int a = int.Parse (Console.ReadLine());
int max = 2;
while (max <= a)
{
    Console.Write( max );
    max = max + 2;
}