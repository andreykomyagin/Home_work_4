// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, это дз 4!");



int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//задние 25 Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B. 3, 5 -> 243 (3⁵)2, 4 -> 16

double Task25(int C, int D)
{
    double result = Math.Pow(C, D);
    return result;
}

int A = Input("Введите число А:");
int B = Input("Введите число В:");

Console.WriteLine("Результат задачи - " + Task25(A, B));



//задание 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Задача 27");
int nom = Input("Введите число: ");
string nom_1 = Convert.ToString(nom);
int i = nom_1.Length;
Console.WriteLine("Длина числа = " + i);
int count = 0;
int sum = 0;
if (nom >= 10)
{
    while(count < i)
    {
        int nom_2 = nom % 10;
        nom = nom / 10;
        sum = sum + nom_2;
        count++; 
    }
    Console.WriteLine($"Результат задачи - {sum}");
}
else
{
    Console.WriteLine($"Результат задачи - {nom}");
}



// Задача 29 Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void Task29()
{
   
    int[] array = new int[8];
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        array[i] = new Random().Next();
        Console.Write($"{array[i]} ");
    }
    for (int i = 0; i < count - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < count; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    } 
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine(array[i]);
    }
}

Task29();
