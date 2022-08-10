/* Вид_1 - ничего не принимает и не выдает */ 

// void Method1()
// {
//     Console.WriteLine("Автор: Алексей Кавешников");
// }
// Method1();

/* Вид_2 - ничего не принимают, но могут возвращать */

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

/* Вид_2.1 */ 

// void Method21(string msg, int coumt) // метод_21(строка с сообщением, количество раз)
// {                                   
//     int i = 0;
//     while (i < coumt) // счетчик
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// /* Method21("Текст", 4); -- выведет солово "Текст" - 4 раза.*/
// Method21(coumt: 4, msg: "новый текст");

/* Вид_3 - что-то возвращают, но ничего не принимают*/

// void Method21(string msg, int coumt) // метод_21(строка с сообщением, количество раз)
// {                                   
//     int i = 0;
//     while (i < coumt) // счетчик
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

/* Вид_4 - что-то принимают и что-то возвращают*/ 

/*string Method4(int count, char c) /* char - используется для храниния символов*/

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "ОПА - ");
// Console.WriteLine(res);

/* Цикл - for */
string Method_for(int count, string text)
{
        string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method_for(10, "АгА - ");
Console.WriteLine(res);