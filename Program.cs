string option="";

do { 
Console.WriteLine("choose two numbers, choose first number now");

double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("choose second number now");

double num2 = Convert.ToDouble(Console.ReadLine());



Console.WriteLine("Choose the operator (+, -, * or / )");
string op = Console.ReadLine();
    
    // Check that it is a valid operator and if it is with division check that it can not divide with zero

while (op != "+" && op != "-" && op != "*" && (op != "/" && num1 ==0 || num2 == 0))
{           
        // check input to give the right error message
        if(num1 ==0 || num2 ==0 && op == "/")
        {
            Console.WriteLine("Invalid operator!, can not use divide with zero Chose a operator (+, -, * or / ) ");
        }
        else Console.WriteLine("Invalid operator!Chose a operator (+, -, * or / ) ");

        op = Console.ReadLine();
}

Console.WriteLine("You chose the  " + op + " operator");
    

switch (op)

{
    case "+":
        Console.WriteLine("the sum of the two numbers are " + (num1+ num2));
        break;
    case "-":
        Console.WriteLine("the substraction of the two numbers are " + (num1- num2));
        break;

    case "*":
        Console.WriteLine("the multiplication of the two numbers are " + (num1* num2));
        break;
    case "/":
        Console.WriteLine("the division of the two numbers are " + (num1/ num2));
        break;

    }
    
    Console.WriteLine();

    Console.WriteLine("      1. Would you like to exit? Press q");
    Console.WriteLine();
    Console.WriteLine("      2. otherwise to continue press any key.");
    option = Console.ReadLine();


} while (option != "q");

