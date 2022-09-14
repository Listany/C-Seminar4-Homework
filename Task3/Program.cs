// программа принимает на вход массив из 8 элементов и выводит их на экран

int[] GetArray()
{
    int[] myArray = new int [8];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i]= int.Parse(Console.ReadLine());
    }
    return myArray;
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
			
}

Console.WriteLine("Введите 8 элементов массива: ");
int [] myArrayInput = GetArray();

PrintArray(myArrayInput);

Console.ReadLine();

