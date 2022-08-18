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

char[,] zero = new char[5, 6];
zero = NumberArray(zero);
zero[0, 3] = '#';
zero[0, 4] = '#';
zero[1, 1] = '#';
zero[1, 5] = '#';
zero[2, 1] = '#';
zero[2, 5] = '#';
zero[3, 1] = '#';
zero[3, 5] = '#';
zero[4, 3] = '#';
zero[4, 4] = '#';

char[,] one = new char[5, 6];
one = NumberArray(one);
one[0, 4] = '#';
one[1, 3] = '#';
one[1, 4] = '#';
one[2, 2] = '#';
one[2, 4] = '#';
one[3, 4] = '#';
one[4, 4] = '#';

char[,] two = new char[5, 6];
two = NumberArray(two);
two[0, 2] = '#';
two[0, 3] = '#';
two[0, 4] = '#';
two[1, 1] = '#';
two[1, 4] = '#';
two[2, 3] = '#';
two[3, 2] = '#';
two[4, 1] = '#';
two[4, 2] = '#';
two[4, 3] = '#';
two[4, 4] = '#';

char[,] three = new char[5, 6];
three = NumberArray(three);
three[0, 1] = '#';
three[0, 2] = '#';
three[0, 3] = '#';
three[0, 4] = '#';
three[1, 4] = '#';
three[2, 2] = '#';
three[2, 3] = '#';
three[2, 4] = '#';
three[3, 4] = '#';
three[4, 1] = '#';
three[4, 2] = '#';
three[4, 3] = '#';
three[4, 4] = '#';

char[,] four = new char[5, 6];
four = NumberArray(four);
four[0, 1] = '#';
four[0, 4] = '#';
four[1, 1] = '#';
four[1, 4] = '#';
four[2, 1] = '#';
four[2, 2] = '#';
four[2, 3] = '#';
four[2, 4] = '#';
four[3, 4] = '#';
four[4, 4] = '#';

char[,] five = new char[5, 6];
five = NumberArray(five);
five[0, 1] = '#';
five[0, 2] = '#';
five[0, 3] = '#';
five[0, 4] = '#';
five[1, 1] = '#';
five[2, 1] = '#';
five[2, 2] = '#';
five[2, 3] = '#';
five[2, 4] = '#';
five[3, 4] = '#';
five[4, 1] = '#';
five[4, 2] = '#';
five[4, 3] = '#';
five[4, 4] = '#';

char[,] six = new char[5, 6];
six = NumberArray(six);
six[0, 1] = '#';
six[0, 2] = '#';
six[0, 3] = '#';
six[0, 4] = '#';
six[1, 1] = '#';
six[2, 1] = '#';
six[2, 2] = '#';
six[2, 3] = '#';
six[2, 4] = '#';
six[3, 1] = '#';
six[3, 4] = '#';
six[4, 1] = '#';
six[4, 2] = '#';
six[4, 3] = '#';
six[4, 4] = '#';

char[,] seven = new char[5, 6];
seven = NumberArray(seven);
seven[0, 1] = '#';
seven[0, 2] = '#';
seven[0, 3] = '#';
seven[0, 4] = '#';
seven[1, 3] = '#';
seven[2, 2] = '#';
seven[3, 2] = '#';
seven[4, 2] = '#';

char[,] eight = new char[5, 6];
eight = NumberArray(eight);
eight[0, 1] = '#';
eight[0, 2] = '#';
eight[0, 3] = '#';
eight[0, 4] = '#';
eight[1, 1] = '#';
eight[1, 4] = '#';
eight[2, 1] = '#';
eight[2, 2] = '#';
eight[2, 3] = '#';
eight[2, 4] = '#';
eight[3, 1] = '#';
eight[3, 4] = '#';
eight[4, 1] = '#';
eight[4, 2] = '#';
eight[4, 3] = '#';
eight[4, 4] = '#';

char[,] nine = new char[5, 6];
nine = NumberArray(nine);
nine[0, 1] = '#';
nine[0, 2] = '#';
nine[0, 3] = '#';
nine[0, 4] = '#';
nine[1, 1] = '#';
nine[1, 4] = '#';
nine[2, 1] = '#';
nine[2, 2] = '#';
nine[2, 3] = '#';
nine[2, 4] = '#';
nine[3, 4] = '#';
nine[4, 1] = '#';
nine[4, 2] = '#';
nine[4, 3] = '#';
nine[4, 4] = '#';


outputArray = FillingArray(numberOfDigits, number, outputArray, zero, one, two, three, four, five, six, seven, eight, nine);

PrintArray(outputArray);
