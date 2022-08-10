int [] array = {1,63,21,3,14,5,63,7,18};

int n = array.Length; //определение длинны массива//
int find =63;

int index = 0;

while (index < n)
{
    if(array[index]== find)
    {
        Console.WriteLine(index);
        break; //операция прерывания, т.е. нашли первый совпадающий элемент и на этом остновились//
    }
    index ++; // index = index + 1 //

}
