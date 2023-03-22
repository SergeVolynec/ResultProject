
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

/// <summary>
/// Определяет количество элементов массива, длина которых менее заданного числа
/// </summary>
/// <param name="arr">Проверяемый массив</param>
/// <param name="charQuantity">Ограничение длины строки</param>
/// <returns>Количество элементов массива</returns>
int DefineNewSize(string[] arr, int charQuantity)
{
    int resultSize = 0;
    int initSize = arr.Length;
    for (int i = 0; i < initSize; i++)
    {
        if (arr[i].Length <= charQuantity)
        {
            resultSize++;
        }
    }
    return resultSize;
}
