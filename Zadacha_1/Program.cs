﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

for(int i = 0; i < size; i++)
{
    numbers[i] =  new Random().Next(100, 1000);
}


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int count = 0;
for( int i = 0; i < size; i++)
{
 if (numbers[i] % 2 == 0) count++;
}

PrintArray( numbers);
Console.Write(count);