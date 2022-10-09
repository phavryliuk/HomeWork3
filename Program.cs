using System;

//буду старатися надалі використовувати англійську мову для коментарів та юзер інтерфейсу
//англійська у мене крива, складні думки будуть українською
//Exercise#1 
void maxValue ()
{
    var validInput = false;
    /*через цю змінну вибудував логіку, яка буде виводити на консоль помилку при непр. введенні
     цикл буде повторюватися до введення цифри.
     Проблему з нулем не вирішив, треба покопатися з if - else та
     додати умову на випадок введення нуля, щоб нуль не перевірявся діленням самого на себе*/
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

//Exercise#2
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

//Exercise#3
// не до кінця розумію, чи правильно зрозумів суть завдання... При непарній сумі метод має повертати true, та навпаки + вивести на екран цю суму???????????
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

//Exercise#4
void maxValue2 ()
{
    var validInput = false;
    int firstValue = 0;
    int secondValue = 0;
    int thirdValue = 0;
    int fourthValue = 0;
    



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

    validInput = false;
    while (!validInput)
    {
        Console.WriteLine("Enter third value");
        validInput = int.TryParse(Console.ReadLine(), out thirdValue);
        if (!validInput || thirdValue % thirdValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }

    validInput = false;
    while (!validInput)
    {
        Console.WriteLine("Enter fourth value");
        validInput = int.TryParse(Console.ReadLine(), out fourthValue);
        if (!validInput || fourthValue % fourthValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }



    if
      (firstValue > secondValue && firstValue > thirdValue && firstValue > fourthValue)

    {
        Console.WriteLine("Bigger is first value ===> " + firstValue);
    }

    if
      (secondValue > firstValue && secondValue > thirdValue && secondValue > fourthValue)

    {
        Console.WriteLine("Bigger is second value ===> " + secondValue);
    }

    if
      (thirdValue > firstValue && thirdValue > secondValue && thirdValue > fourthValue)

    {
        Console.WriteLine("Bigger is third value ===> " + thirdValue);
    }

    if
      (fourthValue > firstValue && fourthValue > secondValue && fourthValue > thirdValue)

    {
        Console.WriteLine("Bigger is fourth value ===> " + fourthValue);
    }

    else
    {
        Console.WriteLine("Values is equal");
    }
}

//Exercise#5
void minValue2()
{
    var validInput = false;
    int firstValue = 0;
    int secondValue = 0;
    int thirdValue = 0;
    int fourthValue = 0;




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

    validInput = false;
    while (!validInput)
    {
        Console.WriteLine("Enter third value");
        validInput = int.TryParse(Console.ReadLine(), out thirdValue);
        if (!validInput || thirdValue % thirdValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }

    validInput = false;
    while (!validInput)
    {
        Console.WriteLine("Enter fourth value");
        validInput = int.TryParse(Console.ReadLine(), out fourthValue);
        if (!validInput || fourthValue % fourthValue != 0)
        {
            Console.WriteLine("Value is invalid. Please, enter integer");
        }
    }



    if
      (firstValue < secondValue && firstValue < thirdValue && firstValue < fourthValue)

    {
        Console.WriteLine("Smaller is first value ===> " + firstValue);
    }

    if
      (secondValue < firstValue && secondValue < thirdValue && secondValue < fourthValue)

    {
        Console.WriteLine("Smaller is second value ===> " + secondValue);
    }

    if
      (thirdValue < firstValue && thirdValue < secondValue && thirdValue < fourthValue)

    {
        Console.WriteLine("Smaller is third value ===> " + thirdValue);
    }

    if
      (fourthValue < firstValue && fourthValue < secondValue && fourthValue < thirdValue)

    {
        Console.WriteLine("Smaller is fourth value ===> " + fourthValue);
    }

    else
    {
        Console.WriteLine("Values is equal");
    }
}






//Output

    Console.WriteLine("Exercise #1");
maxValue();
    Console.WriteLine("Exercise #2");
minValue();
    Console.WriteLine("Exercise #3");
TrySumIfOdd();
    Console.WriteLine("Exercise #4");
maxValue2();
    Console.WriteLine("Exercise #5");
minValue2();

Console.ReadLine();



















