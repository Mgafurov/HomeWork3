//Вводятся 4 целых числа, вывести количество отрицательных чисел.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 4 целых числа: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());

        int negetiveCount = 0;
        if (number1 < 0)
        {
            negetiveCount++;
        }
        if (number2 < 0)
        {
            negetiveCount++;
        }
        if (number3 < 0)
        {
            negetiveCount++;
        }
        if (number4 < 0)
        {
            negetiveCount++;
        }
        Console.WriteLine("Количество отрицательных чисел: " + negetiveCount);
        Console.ReadLine();
    }
}*/

//Вводятся 4 целых числа, вывести количество положительных чисел.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 4 целых числа: ");

        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());

        int positiveCount = 0;
        if (number1 > 0)
        {
            positiveCount++;
        }
        if (number2 > 0)
        {
            positiveCount++;
        }
        if (number3 > 0)
        {
            positiveCount++;
        }
        if (number4 > 0)
        {
            positiveCount++;
        }
        Console.WriteLine("Количество положительных чисел: " + positiveCount);
        Console.ReadLine();
    }
}*/
//Вводятся 4 целых числа, вывести количество одинаковых чисел.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 4 целых числа: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());

        int sameCount = 0;
        if (number1 == number2)
        {
            sameCount++;
        }
        else if (number1 == number3)
        {
            sameCount++;
        }
        else if (number1 == number4)
        {
            sameCount++;
        }
        else
        {
            Console.WriteLine("Одинаковых чисел нет!");
        }
        Console.WriteLine("Количество одинаковых чисел: " + sameCount);
        Console.ReadLine();
    }
}*/
//Вводятся 4 целых числа, вывести количество чисел, которые делятся на 5 без остатка.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 4 целых числа");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int count = 0;

        if (number1 % 5 == 0)
        {
            count++;
        }
        if (number2 % 5 == 0)
        {
            count++;
        }
        if (number3 % 5 == 0)
        {
            count++;
        }
        if (number4  % 5 == 0)
        {
            count++;
        }
        Console.WriteLine("Количество чисел без остатка: " + count);
        Console.ReadLine();
    }
}*/

//Вводятся 4 целых числа, вывести количество чисел, которые делятся на 7 без остатка.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 4 целых числа");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int count = 0;

        if (number1 % 7 == 0)
        {
            count++;
        }
        if (number2 % 7 == 0)
        {
            count++;
        }
        if (number3 % 7 == 0)
        {
            count++;
        }
        if (number4 % 7 == 0)
        {
            count++;
        }
        Console.WriteLine("Количество чисел без остатка: " + count);
        Console.ReadLine();
    }
}*/

//Вводится сумма товара, необходимо вычислить стоимость покупки с учётом скидки: при покупке товара на сумму больше 850 рублей предоставляется скидка 25%. Обложить сумму налогом 13%. Вывести итоговую сумму товара.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму товара: ");
        double sum = double.Parse(Console.ReadLine());
        double sumDiscount = 0;
        double sumFinal = 0;
        if(sum > 850)
        {
            sumDiscount = sum - (sum * 0.25);
        }
        else
        {
            sumDiscount = sum;
        }
        sumFinal = sumDiscount + (sumDiscount * 0.13);
        Console.WriteLine("Итоговая сумма " + sumFinal + "рублей: ");
        Console.ReadKey();
    }
}*/

//Вводится сумма товара, необходимо вычислить стоимость покупки с учётом скидки: при покупке товара на сумму больше 250 рублей предоставляется скидка 5%. Обложить сумму налогом 13%. Вывести итоговую сумму товара

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму товара: ");
        double sum = double.Parse(Console.ReadLine());
        double sumDiscount = 0;
        double sumFinal = 0;
        if (sum > 250)
        {
            sumDiscount = sum - (sum * 0.05);
        }
        else
        {
            sumDiscount = sum;
        }
        sumFinal = sumDiscount + (sumDiscount * 0.13);
        Console.WriteLine("Итоговая сумма " + sumFinal + "рублей: ");
        Console.ReadKey();
    }
}*/
//Вводится сумма товара, необходимо вычислить стоимость покупки с учётом скидки: при покупке товара на сумму больше 3000 рублей предоставляется скидка 30%. Обложить сумму налогом 13%. Вывести итоговую сумму товара.

/*using System;

class Prgram
{
    static void Main()
    {
        Console.WriteLine("Введите сумму товара: ");
        double sum = double.Parse(Console.ReadLine());
        double sumDiscount = 0;
        double sumFinal = 0;
        if (sum > 3000)
        {
            sumDiscount = sum - (sum * 0.30);
        }
        else
        {
            sumDiscount = sum;
        }
        sumFinal = sumDiscount + (sumDiscount * 0.13);
        Console.WriteLine("Итоговая сумма " + sumFinal + "рублей: ");
        Console.ReadKey();
    }
}*/
//Вводится сумма товара, необходимо вычислить стоимость покупки с учётом скидки: при покупке товара на сумму больше 6000 рублей предоставляется скидка 50%. Обложить сумму налогом 13%. Вывести итоговую сумму товара.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму товара: ");
        double sum = double.Parse(Console.ReadLine());
        double sumDiscount = 0;
        double sumFinal = 0;
        if (sum > 6000)
        {
            sumDiscount = sum - (sum * 0.5);
        }
        else
        {
            sumDiscount = sum;
        }
        sumFinal = sumDiscount + (sumDiscount * 0.13);
        Console.WriteLine("Итоговая сумма " + sumFinal + " рублей ");
        Console.ReadKey();
    }
}*/
//Вводится сумма товара, необходимо вычислить стоимость покупки с учётом скидки: при покупке товара на сумму больше 1000 рублей предоставляется скидка 15%. Обложить сумму налогом 13%. Вывести итоговую сумму товара.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму товара: ");
        double sum = double.Parse(Console.ReadLine());
        double sumDiscount = 0;
        double sumFinal = 0;
        if (sum > 1000)
        {
            sumDiscount = sum - (sum * 0.15);
        }
        else
        {
            sumDiscount = sum;
        }
        sumFinal = sumDiscount + (sumDiscount * 0.13);
        Console.WriteLine("Итоговая сумма " + sumFinal + " рублей ");
        Console.ReadKey();
    }
}