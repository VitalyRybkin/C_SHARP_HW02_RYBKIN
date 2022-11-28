/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
using System.Diagnostics;

// Checking execution time
Stopwatch stopwatch_switch = new Stopwatch();
Stopwatch stopwatch_dict = new Stopwatch();
stopwatch_switch.Start();

Console.Clear();

//Input checking func - wether the input is not a weekday or not a number
int CheckInput (string get_string) {
    while (true) {
        if (get_string == "Q") Environment.Exit(0);
        if (int.TryParse(get_string, out int day_num)){ 
            if (1 <= day_num & day_num <= 7) {
                Console.WriteLine();
                return day_num;
            }
            else {
                Console.Write("\nOut of range of weekdays!");
                Console.Write("Try again or type 'Q': ");
                get_string = Console.ReadLine() ?? "";
            }
        }
        else {
                Console.Write("\nThis is not an number! ");
                Console.Write("Try again or type 'Q': ");              
                get_string = Console.ReadLine() ?? "";
        }
    }
} 

// SWITCH CASE VERSION
Console.WriteLine("SWITCH CASE VERSION...\n");
Console.Write("Enter a number of a weekday: ");
string get_string = Console.ReadLine() ?? "";
int day_num = CheckInput(get_string);
// Execution time evaluation only
// int day_num = 5;
// Console.WriteLine($"Entry: {day_num}");

switch (day_num) {
    case 1:
    Console.WriteLine("Monday is a workday!");
    break;
    case 2:
    Console.WriteLine("Tuesday is a workday!");
    break;
    case 3:
    Console.WriteLine("Wednesday is a workday!");
    break;
    case 4:
    Console.WriteLine("Thursday is a workday!");
    break;
    case 5:
    Console.WriteLine("Friday is a workday!");
    break;
    case 6:
    Console.WriteLine("Saturday is a WEEKEND!!!");
    break;
    case 7:
    Console.WriteLine("Sunday is a WEEKEND!!!");
    break;
}

stopwatch_switch.Stop();

stopwatch_dict.Start();
//DICTIONARY VERSION
Console.WriteLine("\nDICTIONARY VERSION...\n");
Dictionary<int, string> weekdays = new Dictionary<int, string>()
{
    { 1, "Monday is a workday!"},
    { 2, "Tuesday is a workday!"},
    { 3, "Wednesday is a workday!"},
    { 4, "Thursday is a workday!"},
    { 5, "Friday is a workday!"},
    { 6, "Saturday is a WEEKEND!!!"},
    { 7, "Sunday is a WEEKEND!!!"},
};

Console.Write("Enter a number of a weekday: ");
get_string = Console.ReadLine() ?? "";
day_num = CheckInput(get_string);
//Execution time evaluation only
// day_num = 5;
// Console.WriteLine($"Entry: {day_num}");

foreach (var day in weekdays) {
    if (day.Key == day_num){ 
        Console.WriteLine(day.Value);
        break;
    }
}
stopwatch_dict.Stop();

//Checking and printing code execution time (does effect with pre-entered day_nums)
Console.WriteLine();
Console.WriteLine("\nCode execution time is (only with pre-entered weekdays): \nswitch ver. - " + stopwatch_switch.ElapsedMilliseconds + " ms, \ndictionary ver. - " + stopwatch_dict.ElapsedMilliseconds + " ms\n");