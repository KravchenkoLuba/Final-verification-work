string[] GreateStringArray(int number)
{
    string[] stringArray = new string[number];
    for(int i = 0; i < number; i++)
    {
        Console.Write($"Input {i+1} name ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}

void ShowStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] ModifiesArrayToElementsOfThreeCharacters(string[] array)
{
    string[] array1 = new string[array.Length];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            array1[count] = array[i];
            count++;
        } 
        

    }
    return array1;
}

string[] firstArray = GreateStringArray(6);
string[] secondArray = ModifiesArrayToElementsOfThreeCharacters(firstArray);
ShowStringArray(firstArray); 
ShowStringArray(secondArray);

