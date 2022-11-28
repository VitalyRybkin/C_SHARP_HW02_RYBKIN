/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


//Input checking func - wether the input too short or not an integer
string CheckInput (string get_string) {
    while (true) {
        if (get_string == "Q") Environment.Exit(0);
        if (get_string.Length < 2){
            Console.WriteLine("\nThis num is to short or not an integer! ");
            Console.Write("Try again or type 'Q': ");
            get_string = Console.ReadLine() ?? "";
        }
        else {
            if (int.TryParse(get_string, out int num)) return get_string;
            else {
                Console.Write("\nThis is not an int! ");
                Console.Write("Try again or type 'Q': ");
                get_string = Console.ReadLine() ?? "";
            }
        }
    }   
}


Console.Clear();

//MATH VERSION
Console.WriteLine("MATH VERSION...\n");
Console.Write("Enter a number: ");
string text = Console.ReadLine() ?? "";
string get_string = CheckInput (text);
int num = Convert.ToInt32(get_string);

while (num >= 100) num /= 10;
    int res = num % 10;

Console.Write($"Second digit of you num is {res}");

//STRING VERSION
Console.WriteLine("\n\nSTRING VERSION...\n");
Console.Write("Enter a number: ");
text = Console.ReadLine() ?? "";
get_string = CheckInput (text);
res = Convert.ToInt32(get_string[1].ToString());
Console.WriteLine($"Second digit of you num is {Convert.ToInt32(get_string[1].ToString())}");
