﻿/* Задача 19: Напишите программу, которая принимает на
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
else
Console.WriteLine ("Число не является палиндромом");
