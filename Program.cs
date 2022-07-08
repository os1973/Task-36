/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int [] GetArray(int dimension)
{
int[N] arr = new int[dimension];
Random randomizer = new Random();

for(int i=0; i < arr.Length; i++)
{
   arr[i] = randomizer.Next(-99, 100);
}

return arr;
}

void PrintArray(int [N] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
}

int Summ(int[N%10], arr);
{
int summ = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] > 0)
        summ += 1; 
}

return summ;
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

int [N] array = GetArray(dimension);
PrintArray(array);

int Summ = Summ(N % 10);

Console.WriteLine();
Console.WriteLine($"Сумма 'элементов, стоящих на нечетных позициях");
