// Task 25

// void Zadacha25()
// {
//     Random rand = new Random();
//     int A = rand.Next(1, 20);
//     int B = rand.Next(1, 20);
//     int result = Convert.ToInt32(Math.Pow(A, B));
//     Console.WriteLine($"{A}^{B }={result}");
// }
// Zadacha25();

// Task 27

// void Zadacha27()
// {
//     Random rand = new Random();
//     int N = rand.Next(1, 20);
//     int sum = 0;
//     for (int i = 1; i < N; i++)
//     {
//         sum = sum + i;
//     }
//     Console.WriteLine("Число N = " + N);
//     Console.WriteLine("Сумма цифр в числе N = " + sum);
// }
// Zadacha27();

// Task 29

void Zadacha29()
{
    int[] arr = new int[8];
    int i = 0;
    int jMin = 0; 
    Random rand = new Random();
    while (i < arr.Length)
    {
        arr[i] = rand.Next(-25, 25);
        i++;
    }
    i = 0;
    while (i < arr.Length)
    {
        Console.WriteLine(arr[i]);
        i++;
    }
    for (i = 0; i < arr.Length; i++)
    {
        int Min = arr[i];
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (Math.Abs(arr[j]) < Math.Abs(Min))
            {
                Min = arr[j];
                jMin = j;
            }
        }
        arr[jMin] = arr[i];
        arr[i] = Min;
    }
    Console.WriteLine("Новый массив");
    i = 0;
    while (i < arr.Length)
    {
        Console.WriteLine(arr[i]);
        i++;
    }
    

}



Zadacha29();