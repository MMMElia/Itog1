// Итоговый проект


Console.Clear();
Console.Write("Введите длину массива");   // ввод длины массива
int n = int.Parse(Console.ReadLine());

string[] array = inputarray(n);  // Вызов метода создания и ввода нового массива
string[] arr=Result(array);    // Вызов метода основного решения


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


