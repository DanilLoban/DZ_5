// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
int sum = 0;
for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 100);
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
    if(i % 2 != 0) sum = sum + array[i];
}
PrintArray(array);
Console.Write(sum);