
/// <summary>
/// Создает новый массив строк, которые пользователь вводит с консоли
/// </summary>
/// <returns>Возвращает введенный массив строк</returns>
string[] InitializeArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] initArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-ый элемент массива: ");
        string element = Console.ReadLine();
        initArray[i] = element.Trim();
    }
    return initArray;
}

