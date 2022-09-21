Console.WriteLine("Введите кол-во строк ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  кол-во столбцов ");
int columsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {

            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "");
        }
        Console.WriteLine("]");
        Console.WriteLine(" ");
    }
}
