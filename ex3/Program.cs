// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int ArraySize = 6;
float max = -1000;
float min = 999;
float[] array = new float[ArraySize];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-1000, 1000);

}
Console.WriteLine('[' + string.Join(", ", array) + ']');

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " + min);
Console.WriteLine("Разница максимального и минимального эелементов массива:  " + (max - min));


//for (int i = 0; i < array.Length; i++)
//{
//  if (array[i] % 2 == 0)
//{
//  CheckEven++;
//}
//}    
//Console.WriteLine("количество четных элементов: " + CheckEven);