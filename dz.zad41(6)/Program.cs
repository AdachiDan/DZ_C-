// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write (array[i]);   // ^1 - последний элемент
    }
    Console.WriteLine("]");
}

int CountPlusNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}



Console.WriteLine("Enter numbers throught space: ");
string str = Console.ReadLine();
string[] strArr = str.Split();
int[] arr = Array.ConvertAll(strArr, int.Parse);
PrintArray(arr);
int count = CountPlusNumber(arr);
Console.WriteLine($" -> {count}");



