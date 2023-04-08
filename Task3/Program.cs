//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = {-1.25, 48.75, 11.73, -47.75};

void Printarray(double [] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.Write(array[array.Length-1] + " ]");
}

double FindMax(double [] array)
{
    double max=0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]>max)
    {
        max=array[i];
    }
}
return max;
}

double FindMin(double [] array)
{
    double min=0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]<min)
    {
        min=array[i];
    }
}
return min;
}

double Max=FindMax(array);
double Min=FindMin(array);

void FindDiff(double Max, double Min)
{
    double Diff=Max-Min;
    System.Console.WriteLine("разность между макимальным и минимальным значением = " + Diff);
}
Printarray(array);
System.Console.WriteLine();
FindDiff(Max, Min);