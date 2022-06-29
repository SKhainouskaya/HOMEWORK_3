/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

Console.WriteLine ("введите пятизначное число");
int N = int.Parse(Console.ReadLine());
int C1 = N/10000;
int C2 = (N/1000)%10;
int C4 = (N%100)/10;
int C5 = N%10;

if (C1==C5 && C2==C4)
{
Console.WriteLine ("Число является палиндромом");
}
Else
Console.WriteLine ("Число не является палиндромом");



/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("введите координату X1");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату Y1");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату Z1");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите координату X2");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату Y2");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату Z2");
int Z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X1-X2, 2)+ Math.Pow(Y1-Y2, 2)+ Math.Pow(Z1-Z2, 2));
Console.WriteLine(Math.Round(result, 2));


/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("введите число N");
int N = int.Parse(Console.ReadLine());
int count = 1;

while (count<= N)
{
    Console.Write(Math.Pow(count, 3) + " ");
    count++;
}
