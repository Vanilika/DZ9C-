//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

void SumNumbers (int m, int n, int sum)

{
    if (m > n)
    {
        System.Console.WriteLine($"Cумма от М до N =  {sum}");
        return;
    }
    sum = sum + (m++);

 SumNumbers(m, n, sum);
}

SumNumbers(m, n, 0);