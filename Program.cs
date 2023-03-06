// * This is the main file for the project. It contains the main entry point for the application.
// * ====================================================================================================
// *   Var Initialization
// * ====================================================================================================
// * MESSAGES
// * ====================================================================================================
string MSG_FirstStart = "Welcome to Practice the Basics. This is a console app that shows of demonstrations of understanding some of the basics.";
string MSG_Statement = " I really wanted to make this to learn how to program in C#. For the longest time I would just get by on fundemantals but never really dove deep into practical applications. \n Recently I left a project because there was a contract dispute. The thing that held me back from just making the game myself was the lack of understanding how to build complex systems. I want to learn to make games the right way without relying on other tooling. When I want to make something, I want to be able to at least get to a working prototype before giving up. I want to make this so that when my son is older, we can make cool games together and he can make his own video games. I have nothing but time, I have nothing but passion. Lets do this!.";
string MSG_OptionsText = "Here are where options will be stored. For now there is nothing so the program will end.";
string MSG_OptionHeaderText = "Please select an option from the list below. Using the Numpad to enter the number of the application you want to run.";
string MSG_ExitMessage = "Bye.";
//  *   
//  USER INPUT
//  *
string MSG_Input;
// options
int OPTIONVALUE_SleepTimer = 200;
// *
// DECO
// *
string MSG_BorderEquals = "====================================================================================================";
string MSG_BorderDash = "----------------------------------------------------------------------------------------------------";
string MSG_BorderSpace = "                                                                                                    ";
// *
// EXAMPLES
// *
string ex_MSG_String = "Duck"; // demonstrate what a string is
int ex_MSG_Int = 1000; // demonstrate what an int is
float ex_MSG_Float = 0.1234567890f; // demonstrate what a float is
double ex_MSG_Double = 0.1234567890; // demonstrate what a double is
bool ex_MSG_Bool = false; // demonstrate what a bool is
char ex_MSG_Char = 'D'; // demonstrate what a char is
decimal ex_MSG_Decimal = 0.1234567890m; // demonstrate what a decimal is
// *
// MATH
// *
int ex_MSG_MathCounter = 0;





// *
// START
// *
Console.WriteLine(MSG_BorderEquals + "\n");
Console.WriteLine(MSG_FirstStart);
Console.WriteLine(MSG_BorderEquals + "\n");
//

//ask Question
Console.WriteLine(MSG_BorderDash + "\n");
Console.WriteLine(MSG_OptionHeaderText);
Console.WriteLine(MSG_BorderDash + "\n");

Console.WriteLine("1. Statement");
Console.WriteLine("2. Options");
Console.WriteLine("3. Examples");
Console.WriteLine("4. Counter");
Console.WriteLine("Exit");

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
    Console.WriteLine(MSG_OptionsText);
    Console.WriteLine(MSG_BorderDash + "\n");
}
else if (MSG_Input == "3") // # - Needs to up date to show all examples + needs to be able to loop back to the main menu + should be in a method
{
    Console.WriteLine(MSG_BorderDash + "\n");
    Console.WriteLine("String: [string varName = value]; ex:    string FirstName = \"Duck\";");
    Console.WriteLine("^->: " + ex_MSG_String + "\n");
    //
    Console.WriteLine("Int: [int varName = value]; ex:    int Age = 1000;");
    Console.WriteLine("^->: " + ex_MSG_Int + "\n");
    //
    Console.WriteLine("Float (32) / Double (64) / Decimal (128) : EX VALUE IS 0.1234567890");
    Console.WriteLine("^->: " + ex_MSG_Float + "  [float ex_MSG_Float =  0.1234567890f;]\n" + "^->: " + ex_MSG_Double + "  [double ex_MSG_Double = 0.1234567890;]\n" + "^->: " + ex_MSG_Decimal + "  [decimal ex_MSG_Decimal = 0.1234567890m];\n");
    //
    Console.WriteLine("Char: [char varName = v]; ex:    char FirstInitial = \"D\";");
    Console.WriteLine("^->: " + ex_MSG_Char + "\n");
    //
    Console.WriteLine("Bool: [bool varName = true or false]; ex:    bool EarthIsFlat = false;");
    Console.WriteLine("^->: " + ex_MSG_Bool + "\n");
    //
    Console.WriteLine(MSG_BorderDash + "\n");
}
else if (MSG_Input == "exit")
{
    Console.WriteLine(MSG_BorderSpace + "\n");
    Console.WriteLine(MSG_ExitMessage);
    Console.WriteLine(MSG_BorderSpace + "\n");
}
else if (MSG_Input == "4")
{
    Console.Clear();
    Console.WriteLine(MSG_BorderDash + "\n");
    Console.WriteLine("Math Fun" + "\n");
    Console.WriteLine("\n\n Count to Ten \n\n");
    while (ex_MSG_MathCounter < 11)
    {
        if (ex_MSG_MathCounter == 10)
        {
            Console.Write(ex_MSG_MathCounter);
            break;
        }
        Console.Write(ex_MSG_MathCounter + ", ");
        // pause for 1 seconds then continue
        Thread.Sleep(OPTIONVALUE_SleepTimer);
        ex_MSG_MathCounter++;
    }
    Console.WriteLine("\n BYE");

}
else
{
    Console.WriteLine(MSG_BorderDash + "\n");
    Console.WriteLine(MSG_ExitMessage);
    Console.WriteLine(MSG_BorderDash + "\n");
}
