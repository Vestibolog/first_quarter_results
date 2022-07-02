string[] inputArray = 	{"hello", "2", "world", ":-)"};

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]},  ");
    }
    Console.WriteLine();
}

int numberShortWords = 0;
for (int i = 0; i < inputArray.GetLength(0); i++)
{
    if ( inputArray[i] .Length <= 3){
        numberShortWords++;
    }
}


PrintArray(inputArray);
Console.WriteLine($"Количество слов <=3 символов = {numberShortWords}");
