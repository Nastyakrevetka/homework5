//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int ArraySize = 6;
int CheckEven = 0;
int[] array = new int[ArraySize];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);

}
Console.WriteLine('[' + string.Join(", ", array) + ']');
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        CheckEven++;
    }
}    
Console.WriteLine("количество четных элементов: " + CheckEven);
