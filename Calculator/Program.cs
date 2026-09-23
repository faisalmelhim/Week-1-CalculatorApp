/* Inputting code for the calculator app */
int firstNumber = 15;
int secondNumber = 4;

int result = firstNumber + secondNumber;
Console.WriteLine("The result is {0}", result);
Console.ReadKey();

/* Accepting user input */

Console.WriteLine("Please enter your first number: ");
int firstNumber_ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second number: ");
int SecondNumber_ = Convert.ToInt32(Console.ReadLine());

int result_ = firstNumber_ + SecondNumber_;
Console.WriteLine("The result is {0}", result_);