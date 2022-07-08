Console.WriteLine("Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А");
void Task24()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine ($"Сумма чисел от 1 до N равна {FindSum(number)}");

}
int FindSum(int number)
{
    int sum = 0;
    for (int i =1; i <= number; i++)
    {
        sum +=i;
    }
    return sum;
}
//Task24();

Console.WriteLine("Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.");
void Task26()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine ($"В этом числе {CountDigits(number)} цифр(-ы)");

}
int CountDigits(int number)
{
    int count = 1;
    while (number/10 > 0)
    {
        
        count++;
        number = number/10;       
        
    }
    return count;
}
//Task26();

Console.WriteLine("Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");
void Task28()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine ($"Факториал числа {number} – {FindFact(number)}");

}
int FindFact(int number)
{
    int fact = 1;
    for (int i = 2; i <= number; i++)
    {
        fact = fact*i;
        
    }
    return fact;
}
//Task28();

Console.WriteLine("Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.");
void Task30 ()
{
    int number;
    int size = 8;
    int[] array = new int[size];
    array = FillArray(size);
    PrintArray(array);

int [] FillArray(int size)
{
    int[] fillArray = new int[size];
    Random random = new Random();
    for (int i = 0; i <fillArray.Length; i++)
    {
        fillArray[i] = random.Next(0,2);
        
    }
    return fillArray;
}

void PrintArray (int [] array)
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i <array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
}

}
Task30 (); 