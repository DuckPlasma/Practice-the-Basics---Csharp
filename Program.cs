// vars
string MSG_FirstStart = "Welcome to Practice the Basics. This is a console app that shows of demonstrations of understanding some of the basics.";
string MSG_Statement = " I really wanted to make this to learn how to program in C#. For the longest time I would just get by on fundemantals but never really dove deep into practical applications. \n Recently I left a project because there was a contract dispute. The thing that held me back from just making the game myself was the lack of understanding how to build complex systems. I want to learn to make games the right way without relying on other tooling. When I want to make something, I want to be able to at least get to a working prototype before giving up. I want to make this so that when my son is older, we can make cool games together and he can make his own video games. I have nothing but time, I have nothing but passion. Lets do this!.";
string MSG_Options = "Here are where options will be stored. For now there is nothing so the program will end.";
string MSG_ExitMessage = "Bye.";

string MSG_Input;


string MSG_BorderEquals = "====================================================================================================";
string MSG_BorderDash = "----------------------------------------------------------------------------------------------------";
string MSG_BorderSpace = "                                                                                                    ";


//Start//
Console.WriteLine(MSG_BorderEquals + "\n");
Console.WriteLine(MSG_FirstStart);
Console.WriteLine(MSG_BorderEquals + "\n");
//

//ask Question
Console.WriteLine(MSG_BorderDash + "\n");
Console.WriteLine("Please select an option from the list below. Using the Numpad to enter the number of the application you want to run.");
Console.WriteLine(MSG_BorderDash + "\n");

Console.WriteLine("1. Statement");
Console.WriteLine("2. Options");
Console.WriteLine("3. Examples");
Console.WriteLine("4. Exit");

Console.WriteLine(MSG_BorderDash);
Console.WriteLine("\n\n\n\n");
//
MSG_Input = Console.ReadLine();
MSG_Input = Convert.ToString(MSG_Input);
//
if (MSG_Input == "1")
{
    Console.WriteLine(MSG_BorderDash + "\n");
    Console.WriteLine(MSG_Statement);
    Console.WriteLine(MSG_BorderDash + "\n");
}
else if (MSG_Input == "2")
{
    Console.WriteLine(MSG_BorderDash + "\n");
    Console.WriteLine(MSG_Options);
    Console.WriteLine(MSG_BorderDash + "\n");
}
else if (MSG_Input == "3")
{
    Console.WriteLine(MSG_BorderDash + "\n");
    Console.WriteLine("1. Strings: [string varName = value]; ex:    string FirstName = \"Duck\";");
    Console.WriteLine("2. Int: [int varName = value]; ex:    int Age = 1000;");
    Console.WriteLine("3. Float (32) / Double (64) / Decimal (128): [float varName = 0.ffddDD]"); // what a terrible way to write this. i should def come back and change this before someone thinks I am a dumb.
    Console.WriteLine("4. Char: [char varName = v]; ex:    char FirstInitial = \"D\";");
    Console.WriteLine("5. Bool: [bool varName = true or false]; ex:    bool EarthIsFlat = false;");
    Console.WriteLine(MSG_BorderDash + "\n");
}
else if (MSG_Input == "4")
{
    Console.WriteLine(MSG_BorderSpace + "\n");
    Console.WriteLine(MSG_ExitMessage);
    Console.WriteLine(MSG_BorderSpace + "\n");
}
else
{
    Console.WriteLine(MSG_BorderDash + "\n");
    Console.WriteLine(MSG_ExitMessage);
    Console.WriteLine(MSG_BorderDash + "\n");
}

