int GetArraySize(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int size;
        if(int.TryParse(Console.ReadLine(), out size) && size > 0)
            return size;
        Console.WriteLine(errorMessage);
    }
}
string[] GetArray(int size)
{
    string[] myArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"\nВведите элемент массива под индексом {i}: ");
        myArray[i] = Console.ReadLine();
    }
    return myArray;
}

static void ReturnNewArray(string[] myArray)
{
    string[] NewArray = new string[0];
    foreach (var value in myArray)
    {
        if (value.Length <= 3)
        {
            Array.Resize(ref NewArray, NewArray.Length + 1);
            NewArray[NewArray.Length - 1] = value;
        }
    }
    if(NewArray.Length > 0)
    {
        Console.WriteLine(String.Join(", ", NewArray));
    }
    else
    {
        Console.WriteLine("Ни одного элемента массива <= 3 символов не найдено.");
    }
}