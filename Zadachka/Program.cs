Console.Clear();


string[] input = new string[5] {"exit", "01", "yes", "15", "5679"};
string[] output = new string[input.Length];


void FirstArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}


void SecondArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FirstArray(input, output);
SecondArray(output);

