using System; // first three exercises is done

void maxValue ()
{
    var validInput = false;
    int firstValue = 0;
    int secondValue = 0;

    while (!validInput)
    {
        Console.WriteLine("Enter first Value");
        validInput = int.TryParse(Console.ReadLine(), out firstValue);
        if (!validInput || firstValue % firstValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }

    validInput = false;
    while (!validInput)
    {
        Console.WriteLine("Enter second Value");
        validInput = int.TryParse(Console.ReadLine(), out secondValue);
        if (!validInput || secondValue % secondValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }

    if
        (firstValue > secondValue)
    {
        Console.WriteLine("Bigger is first value ===> " + firstValue);
    }
    else if (secondValue > firstValue)
    {
        Console.WriteLine("Bigger is second value ===> " + secondValue);
    }
    else 
    { 
      Console.WriteLine("Values is equal"); 
    }



}
void minValue ()
{
    var validInput = false;
    int firstValue = 0;
    int secondValue = 0;

    while (!validInput)
    {
        Console.WriteLine("Enter first Value");
        validInput = int.TryParse(Console.ReadLine(), out firstValue);
        if (!validInput || firstValue % firstValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }

    validInput = false;
    while (!validInput)
    {
        Console.WriteLine("Enter second Value");
        validInput = int.TryParse(Console.ReadLine(), out secondValue);
        if (!validInput || secondValue % secondValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }

    if
       (firstValue < secondValue)
    {
        Console.WriteLine("Smaller is first value ===> " + firstValue);
    }
    else if (secondValue < firstValue)
    {
        Console.WriteLine("Smaller is second value ===> " + secondValue);
    }
    else
    {
        Console.WriteLine("Values is equal");
    }



}


// не до кінця розумію, чи правильно зрозумів... При непарній сумі метод має повертати true, та навпаки + вивести на екран цю суму???????????
bool TrySumIfOdd ()
{
    var validInput = false;
    int firstValue = 0;
    int secondValue = 0;

    while (!validInput)
    {
        Console.WriteLine("Enter first Value");
        validInput = int.TryParse(Console.ReadLine(), out firstValue);
        if (!validInput || firstValue % firstValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }

    validInput = false;
    while (!validInput)
    {
        Console.WriteLine("Enter second Value");
        validInput = int.TryParse(Console.ReadLine(), out secondValue);
        if (!validInput || secondValue % secondValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }

    int div = (firstValue + secondValue) %2;

    if (div == 0) 
    {
        Console.WriteLine("Summ of entered values is even ===> " + (firstValue + secondValue) + " Return false");
        return false;
    }
    else
    {
        Console.WriteLine("Summ of entered values is odd=> " + (firstValue + secondValue) + " Return true");
        return true;
    }
}








    Console.WriteLine("Exercise #1");
maxValue();
    Console.WriteLine("Exercise #2");
minValue();
    Console.WriteLine("Exercise #3");
TrySumIfOdd();


    Console.ReadLine();



















