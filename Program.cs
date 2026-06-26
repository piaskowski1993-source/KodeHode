/*
1) Program som leser inn en temperaturvariabel, 
og basert på grenser dere definerer selv, gir tilbakemelding 
i terminalen om temperaturen.

0) Console.WrireLine() = "enter a temperature or type 'exit' to quit"

1) use Console.ReadLine() to read a temperature variable
2) create a variable which contains the numbered entered 
3) if temperature is below 0, print "It's freezing!"
4) if temperature is between 0 and 20, print "It's cold!"
5) if temperature is between 20 and 30, print "It's warm!"
6) if temperature is above 30, print "It's hot!"
7) if temperature is exactly 20, print "It's perfect!"
8) if temperature is lower than 0, print "icicles"
9) if temperature is higher then 30, print "Crispy"
9) if temperature is not a number, print "Please enter a valid number."
10)if user types "exit", quit the program.

11) loop the function so the user can enter  multiple temperatures until they type "exit"
    to quit the program.
*/



while(true)
{

Console.WriteLine("Enter a temperature or type 'exit' to quit");

String temp = Console.ReadLine();


if (temp == "exit")
    {
        Console.WriteLine("Bye");
        break;
    }
   
int request = int.Parse(temp);
if (request < 0)
{
    Console.WriteLine("It is Freezing");
    }
else if (request > 0 && request < 20)
{
    Console.WriteLine("It is Cold");
}
else if (request > 20 && request < 30)
{
    Console.WriteLine("It's warm");
}
else if (request > 30)
{
    Console.WriteLine("It's hot");
}



else 
{ 
    Console.WriteLine("Please enter a valid number");
}
}