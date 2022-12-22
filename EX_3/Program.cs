int Palindrome(int numder)
{
    char[] myArray = numder.ToString().ToCharArray();

    char[] newArray = myArray.Reverse().ToArray();


    for (var i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Equals(newArray[i]))
        {
            if (i == myArray.Length - 1)
            {
                return numder;
            }

        }

    }
    return 0;
}




Console.WriteLine("Задайте размер массива.");
loop1:
Console.Write("\nРазмер по вертикали число больше 0: ");
int namder_y = Convert.ToInt32(Console.ReadLine());
Console.Write("\nРазмер по горизонтали число больше 0: ");
int namder_x = Convert.ToInt32(Console.ReadLine());
Random random = new Random();

if (namder_y > 0 && namder_x > 0)
{
    double[] myArray = new double[namder_x];
    int[,] TwoArray = new int[namder_y, namder_x];
    System.Console.WriteLine("Вывожу массив");

    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {

            TwoArray[i, j] = random.Next(100, 1000);
        }
    }

    for (int i = 0; i < TwoArray.GetLength(0); i++) // проверка массива на пол
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {

            Console.Write(TwoArray[i, j] + "\t");
        }
        Console.WriteLine();
    }



    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {

        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            TwoArray[i, j] = Palindrome(TwoArray[i, j]);
            Console.Write(TwoArray[i, j] + "\t");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < TwoArray.GetLength(1); i++)
    {
        double counter = 0;
        int summer = 0;
        for (int j = 0; j < TwoArray.GetLength(0); j++)
        {

            if (TwoArray[j, i] > 1)
            {
                summer += TwoArray[j, i];
                counter++;
                myArray[i] = summer / counter;
            }
        }
    }


    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + "\t");
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("\nДопускается  ввод числа больше 0.");
    goto loop1;
}
