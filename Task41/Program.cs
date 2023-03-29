// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int Prompt(string mes) //считываем число с консоли
{
    Console.WriteLine(mes); //вывести сообщение
    string value = Console.ReadLine(); //считывает с консоли сообщение
    int result = Convert.ToInt32(value); // преобразовывает строку в число
    return result; // вернуть результат
}
//метод для ввода массива:
int length = Prompt("Введите количество элементов");

int [] InputArray(int length)
{
    int [] array = new int[length];
    for  (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент ");
    }
    return array;
}
//метод печати массива
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
//метод подсчета элементов больше 0 в массиве
int CountPositive(int [] array)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0) 
        {
            count++;
        }
    }
    return count;
}
   


int[] array;
 array = InputArray(length);
 PrintArray(array);
Console.WriteLine("Количество элементов больше нуля: ");
Console.WriteLine(CountPositive(array));