// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
int sum = 0;
int min = Int32.MaxValue;
int max = Int32.MinValue;
for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 100);
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

for(int i = 0; i < size; i++)
{
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];
    sum = min + max;
}
PrintArray(array);
Console.WriteLine(sum);