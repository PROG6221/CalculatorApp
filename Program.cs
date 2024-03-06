//declare variables 
double num1;
double num2;
double output= 0;
int userInput;

//display message
Console.WriteLine("Please enter a number");
//get user input
num1 = Convert.ToInt32(Console.ReadLine());

//display message
Console.WriteLine("Please enter a number");
//get user input
num2 = Convert.ToInt32(Console.ReadLine());

//display message
Console.WriteLine("Please select one of the following options\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
//get user input
userInput = Convert.ToInt32(Console.ReadLine());

//checks user input and does appropriate calculation 
if(userInput == 1)
{
    output = num1 + num2;
}
if(userInput == 2)
{
    output = num1 - num2;   
}
if(userInput == 3)
{
    output= num1 * num2;
}
if(userInput== 4)
{ 
    output= num1 / num2; 
}

//displays output rounded off to 2 decimals places
Console.WriteLine("Your output is " + Math.Round(output,2));

output= 0;
switch (userInput)
{
    case 1:
        output=num1+num2;
        break;
    case 2:
        output=num1 - num2; 
        break;
    case 3:
        output=num1 * num2;
        break;
    case 4:
        output = num1 / num2;
        break;
}
Console.WriteLine("Your output is " + output);



