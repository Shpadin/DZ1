// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine ("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine(" Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max =a;
if (b > a )  max = b;

Console.WriteLine($" самое большое число из {a} и {b} будет {max} ");
Console.WriteLine();


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine(" Введите первое число: ");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c1 = int.Parse(Console.ReadLine());

max =0;
if (a1 > max) max=a1;
if (b1 > max) max=b1;
if (c1 > max) max=c1;

Console.WriteLine($" самое большое число будет {max} ");
Console.WriteLine();




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.");
Console.WriteLine("Введите четное число: ");
int even = int.Parse(Console.ReadLine());

if (even%2 == 0)
Console.WriteLine($" Число четное");
else 
Console.WriteLine($" Ну просили же четное ");
Console.WriteLine();




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Четные числа до {number}: ");
int i = 2;
while (i <= number)
{
if( i %2  == 0)
 Console.Write($"{i} ");
i++;
}

