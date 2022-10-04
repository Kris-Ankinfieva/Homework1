// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Веведите число: ");
int a = int.Parse (Console.ReadLine());
int b = a % 2;
if (a % 2 == 0) 
{
    Console.WriteLine($"Число {a} чётное");
    
}
if (a % b == 0 );
{ 
    Console.WriteLine($"Число {a} не чётное");
}