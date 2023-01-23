//из массива строк сформировать массив строк, длина которых <=3
// ["hello","2","world",":-)"] --> ["2",":-)"]

Console.Clear();
string[] str = { "hello", "2", "world", ":-)", "!" };
//string[] str = { "hello", "Russia", "world" };
//string[] str = { "12354", "2", "world press", ":-))))", "!!!!" };

int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3) count++;
}
string[] strNew = new string[count];
count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3)
    {
        strNew[count] = str[i];
        count++;
    }
}
Console.WriteLine($"[{string.Join(", ", strNew)}]");