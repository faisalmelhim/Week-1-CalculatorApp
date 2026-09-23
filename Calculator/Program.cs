CalculatorApp();
void CalculatorApp()
{
    int choice = 0;
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;

    /* Inputting code for the calculator app */
    firstNumber = 15; /* take the existing firstNumber and give it new value 15 */
    secondNumber = 4; /* take the existing secondNumber and give it new value 4 */

    /* result = firstNumber + secondNumber; */
    /* Console.WriteLine("The result is {0}", result); */
    /* Console.ReadKey(); */

    /* Accepting user input */

    Console.WriteLine("Please enter your first number: ");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter your second number: ");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please select an option:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Multiply");
    Console.WriteLine("4 - Divide");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.Write($"{firstNumber} - {secondNumber} = {result}");

    }
    else if (choice == 3)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
    }
    else
    {
        Console.WriteLine("Please select a valid option between 1 and 4");
    }
}