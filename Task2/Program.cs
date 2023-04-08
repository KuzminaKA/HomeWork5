//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int Getint(string arg)
{
    System.Console.Write($"введите {arg}");
    return int.Parse(Console.ReadLine());
} 

int [] Createarray(int Length, int max, int min)
{
    int [] array= new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void Printarray(int [] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.Write(array[array.Length-1] + " ]");
}

void SumOdd(int [] array)
{
   int Sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 != 0)
        {
            Sum = Sum + array[i];
        }
    }
   System.Console.WriteLine("сумма элементов на нечетных позициях = " + Sum);
}

int Length= Getint("длину массива:");
int max = Getint("максимальный элемент массива: ");
int min = Getint ("минимальный элемент массива: ");
int [] array = Createarray(Length, max, min);
Printarray(array);
System.Console.WriteLine();
SumOdd(array);