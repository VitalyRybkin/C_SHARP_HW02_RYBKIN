/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


//Input checking func - wether the input is not an integer
string CheckInput (string get_string) {
    while (true) {
        if (get_string == "Q") Environment.Exit(0);
        if (int.TryParse(get_string, out int num)) return get_string;
        else {
                Console.Write("\nThis is not an int! ");
                Console.Write("Try again or type 'Q': ");
                get_string = Console.ReadLine() ?? "";
        }
    }
}   

Console.Clear();

//MATH VERSION
Console.WriteLine("MATH VERSION...\n");
Console.Write("Enter a number: ");
string text = Console.ReadLine() ?? "";
string get_string = CheckInput (text);

if (get_string.Length < 3) {
    Console.WriteLine("This number does't have a third digit!");
}
else {
    int num = Convert.ToInt32(get_string);
    while (num >= 1000) num /= 10;
    Console.Write($"Third digit of you num is {num % 10}");
}

//STRING VERSION
Console.WriteLine("\n\nSTRING VERSION...\n");
Console.Write("Enter a number: ");
text = Console.ReadLine() ?? "";
get_string = CheckInput (text);
if (get_string.Length < 3) {
    Console.WriteLine("This number does't have a third digit!");
}
else {
    Console.WriteLine($"Third digit of you num is {Convert.ToInt32(get_string[2].ToString())}");
}