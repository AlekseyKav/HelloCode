// void метод не возвращает позицию! ( с void не используется reten)//

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {

        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray(int[] coll2)
{
    int count = coll2.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll2[position]);
        position ++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; /*если писать int position = 0; , и ввести заведомо несуществующий элемент, то программа выдаст ответ 0, 
                        но если заменить int position = -1, то все отработает красиво */
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //до первого совпадения/нахождения //
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // new int [10] - означает, создай новый массив в котором будет 10 элементов//

FillArray(array);
array[4] = 4; // принудительное добавление элемента "4" на четвертую позицию//
array[7] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);