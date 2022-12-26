//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int ArraySize = 6;
int SumUneven = 0;
int[] array = new int[ArraySize];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);

}
Console.WriteLine('[' + string.Join(", ", array) + ']');
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        SumUneven+= array[i];
    }
}    
Console.WriteLine("сумма элементов массива на нечетных позициях: " + SumUneven);
