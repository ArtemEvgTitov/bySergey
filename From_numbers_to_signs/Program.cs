Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
int numberOfDigits = number.ToString().Length;

string s = number.ToString();
char[] ar = s.ToCharArray();
Array.Reverse(ar);
s = new String(ar);
number = Convert.ToInt64(s);

char[,] CreateOutputArray(int numberOfDigits)
{
    int columns = 6 * numberOfDigits;
    char[,] outputArray = new char[5, columns];

    for (int i = 0; i < 5; i++)
        for (int j = 0; j < columns; j++)
            outputArray[i, j] = ' ';
    return outputArray;
}

void PrintArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

char[,] NumberArray(char[,] array)
{
    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 6; j++)
            array[i, j] = ' ';
    return array;
}

char[,] FillingArray(int numberOfDigits, long number, char[,] outputArray, char[,] zero, char[,] one, char[,] two, char[,] three, char[,] four, char[,] five, char[,] six, char[,] seven, char[,] eight, char[,] nine)
{
    long tempNumber = 0;
    int count = 1;
    int temp = 0;
    while (count <= numberOfDigits)
    {
        tempNumber = number % 10;
        number /= 10;
        for (int i = 0; i < 5; i++)
        {
            for (int j = temp, k = 0; j < count * 6; j++, k++)
            {
                if (tempNumber == 0)
                    outputArray[i, j] = zero[i, k];
                if (tempNumber == 1)
                    outputArray[i, j] = one[i, k];
                if (tempNumber == 2)
                    outputArray[i, j] = two[i, k];
                if (tempNumber == 3)
                    outputArray[i, j] = three[i, k];
                if (tempNumber == 4)
                    outputArray[i, j] = four[i, k];
                if (tempNumber == 5)
                    outputArray[i, j] = five[i, k];
                if (tempNumber == 6)
                    outputArray[i, j] = six[i, k];
                if (tempNumber == 7)
                    outputArray[i, j] = seven[i, k];
                if (tempNumber == 8)
                    outputArray[i, j] = eight[i, k];
                if (tempNumber == 9)
                    outputArray[i, j] = nine[i, k];
            }
        }
        temp += 6;
        count++;
    }
    return outputArray;
}

char[,] outputArray = CreateOutputArray(numberOfDigits);

char symbol = '@';
char[,] zero = new char[5, 6];
zero = NumberArray(zero);
zero[0, 3] = symbol;
zero[0, 4] = symbol;
zero[1, 1] = symbol;
zero[1, 5] = symbol;
zero[2, 1] = symbol;
zero[2, 5] = symbol;
zero[3, 1] = symbol;
zero[3, 5] = symbol;
zero[4, 3] = symbol;
zero[4, 4] = symbol;

char[,] one = new char[5, 6];
one = NumberArray(one);
one[0, 4] = symbol;
one[1, 3] = symbol;
one[1, 4] = symbol;
one[2, 2] = symbol;
one[2, 4] = symbol;
one[3, 4] = symbol;
one[4, 4] = symbol;

char[,] two = new char[5, 6];
two = NumberArray(two);
two[0, 2] = symbol;
two[0, 3] = symbol;
two[0, 4] = symbol;
two[1, 1] = symbol;
two[1, 4] = symbol;
two[2, 3] = symbol;
two[3, 2] = symbol;
two[4, 1] = symbol;
two[4, 2] = symbol;
two[4, 3] = symbol;
two[4, 4] = symbol;

char[,] three = new char[5, 6];
three = NumberArray(three);
three[0, 1] = symbol;
three[0, 2] = symbol;
three[0, 3] = symbol;
three[0, 4] = symbol;
three[1, 4] = symbol;
three[2, 2] = symbol;
three[2, 3] = symbol;
three[2, 4] = symbol;
three[3, 4] = symbol;
three[4, 1] = symbol;
three[4, 2] = symbol;
three[4, 3] = symbol;
three[4, 4] = symbol;

char[,] four = new char[5, 6];
four = NumberArray(four);
four[0, 1] = symbol;
four[0, 4] = symbol;
four[1, 1] = symbol;
four[1, 4] = symbol;
four[2, 1] = symbol;
four[2, 2] = symbol;
four[2, 3] = symbol;
four[2, 4] = symbol;
four[3, 4] = symbol;
four[4, 4] = symbol;

char[,] five = new char[5, 6];
five = NumberArray(five);
five[0, 1] = symbol;
five[0, 2] = symbol;
five[0, 3] = symbol;
five[0, 4] = symbol;
five[1, 1] = symbol;
five[2, 1] = symbol;
five[2, 2] = symbol;
five[2, 3] = symbol;
five[2, 4] = symbol;
five[3, 4] = symbol;
five[4, 1] = symbol;
five[4, 2] = symbol;
five[4, 3] = symbol;
five[4, 4] = symbol;

char[,] six = new char[5, 6];
six = NumberArray(six);
six[0, 1] = symbol;
six[0, 2] = symbol;
six[0, 3] = symbol;
six[0, 4] = symbol;
six[1, 1] = symbol;
six[2, 1] = symbol;
six[2, 2] = symbol;
six[2, 3] = symbol;
six[2, 4] = symbol;
six[3, 1] = symbol;
six[3, 4] = symbol;
six[4, 1] = symbol;
six[4, 2] = symbol;
six[4, 3] = symbol;
six[4, 4] = symbol;

char[,] seven = new char[5, 6];
seven = NumberArray(seven);
seven[0, 1] = symbol;
seven[0, 2] = symbol;
seven[0, 3] = symbol;
seven[0, 4] = symbol;
seven[1, 3] = symbol;
seven[2, 2] = symbol;
seven[3, 2] = symbol;
seven[4, 2] = symbol;

char[,] eight = new char[5, 6];
eight = NumberArray(eight);
eight[0, 1] = symbol;
eight[0, 2] = symbol;
eight[0, 3] = symbol;
eight[0, 4] = symbol;
eight[1, 1] = symbol;
eight[1, 4] = symbol;
eight[2, 1] = symbol;
eight[2, 2] = symbol;
eight[2, 3] = symbol;
eight[2, 4] = symbol;
eight[3, 1] = symbol;
eight[3, 4] = symbol;
eight[4, 1] = symbol;
eight[4, 2] = symbol;
eight[4, 3] = symbol;
eight[4, 4] = symbol;

char[,] nine = new char[5, 6];
nine = NumberArray(nine);
nine[0, 1] = symbol;
nine[0, 2] = symbol;
nine[0, 3] = symbol;
nine[0, 4] = symbol;
nine[1, 1] = symbol;
nine[1, 4] = symbol;
nine[2, 1] = symbol;
nine[2, 2] = symbol;
nine[2, 3] = symbol;
nine[2, 4] = symbol;
nine[3, 4] = symbol;
nine[4, 1] = symbol;
nine[4, 2] = symbol;
nine[4, 3] = symbol;
nine[4, 4] = symbol;


outputArray = FillingArray(numberOfDigits, number, outputArray, zero, one, two, three, four, five, six, seven, eight, nine);

PrintArray(outputArray);
