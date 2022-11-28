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

//MATH VERSION *** WARNING *** WORKS ONLY WITH #-DIGIT NUMS!!!
Console.WriteLine("MATH VERSION...\n");
Console.WriteLine("*** ACHTUNG *** WORKS PROPERLY ONLY WITH 3-DIGIT NUMS!\n");
Console.Write("Enter a number: ");
string text = Console.ReadLine() ?? "";
string get_string = CheckInput (text);
int num = Convert.ToInt32(get_string);

num = num / 10 % 10;

Console.Write($"Second digit of you num is {num}");

Console.WriteLine("\n\nSTRING VERSION...\n");
Console.Write("Enter a number: ");
text = Console.ReadLine() ?? "";
get_string = CheckInput (text);


char[] get_num = get_string.ToCharArray(0, get_string.Length);

// OUTPUT OPTION LIST
// Output option 1.
// int res = get_num[0] - '0';
// Outout option 2.
// int res = Convert.ToInt32(new string(get_num[1], 1));
// Outout option 3.
int res = Convert.ToInt32(get_num[1].ToString());
// ... or write an expression straight into output (instead of res) 

Console.WriteLine($"\nSecond digit of you num is {res}");