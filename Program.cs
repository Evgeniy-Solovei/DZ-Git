string myString = "12,Apple,20,8,asde,acc";
string[] subStrings = myString.Split(',');
string[] Array(string[] Arr)
{
    int count = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length <= 3)
        {
            count++;
        }
    }
    string[] NewArray = new string[count];
    for (int i = 0; i < Arr.Length; i++)
    {
        int a = 0;
        if (Arr[i].Length <= 3)
        {
            NewArray[a] = Arr[i];
            Console.Write($"{NewArray[a]} ");
            a++;
        }
    }
    return NewArray;
}

Array(subStrings);
