//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int Getint(string arg)
{
    System.Console.Write($"введите {arg}");
    return int.Parse(Console.ReadLine());
} 

int [] Createarray(int Length)
{
    int [] array= new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

void Countpositive(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
}

int Length= Getint("длину массива: ");

int [] array = Createarray(Length);
Printarray(array);
System.Console.WriteLine();
Countpositive(array);