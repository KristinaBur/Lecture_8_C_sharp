    // наименование метода - FillArray
    // аргумент (его название) - collection
void FillArray(int [] collection)
{
    int Length = collection.Length;
    int index = 0;

    while(index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0; // тоже самое, что index = 0 (просто даем переменным разные имена)
    while(position<count)
    {

        Console.WriteLine(col[position]);
        position++;
    }
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);

