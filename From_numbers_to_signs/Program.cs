Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOfDigits = number.ToString().Length;

char[,] CreateOutputArray(int numberOfDigits)
{
    int columns = 6*numberOfDigits;
    char[,] outputArray = new char [5,columns];

    for (int i = 0; i < 5; i++)
        for (int j = 0; j < columns; j++)
            outputArray[i, j] = ' ';
    return outputArray;
} 

char[,] outputArray = CreateOutputArray(numberOfDigits);

void PrintArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +" ");
        Console.WriteLine();
    }
}


PrintArray(outputArray);
