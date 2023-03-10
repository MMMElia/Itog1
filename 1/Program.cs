// Итоговый проект


Console.Clear();
Console.Write("Введите длину массива  ");   // ввод длины массива
int n = int.Parse(Console.ReadLine());

string[] array = inputarray(n);  // Вызов метода создания и ввода нового массива
string[] arr=Result(array);    // Вызов метода основного решения
Console.WriteLine("Исходный массив ");
print(array);   // вызов метода вывода исходного массива для наглядности
Console.WriteLine();
Console.WriteLine("Результат ");
print(arr);   // вызов метода вывода результата


string[] inputarray(int n)   // Метод создания и ввода нового массива
{
    string[] arr= new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите значение массива {i}");
        arr[i] = Console.ReadLine();
    }
return arr;    
}


string [] Result(string [] arr)   // метод основного решения
{
    int k = 0;
    int s = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length < 4)
        {
            k++;
        }
    }
    string [] array = new string [k];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length < 4)
        {
            array[s] = arr[i];
            s++;
        }
    }
    return array;
}


void print (string [] arr)    // метод вывода результата
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($" {arr[i]}");

    }
}
