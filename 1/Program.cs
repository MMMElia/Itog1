// Итоговый проект


Console.Clear();
Console.Write("Введите длину массива");   // ввод длины массива
int n = int.Parse(Console.ReadLine());

string[] array = inputarray(n);  // Вызов метода создания и ввода нового массива

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
