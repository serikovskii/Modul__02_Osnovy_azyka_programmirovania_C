﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            string numberOne = "5";
            string numberTwo = "10";
            string numberThree = "21";
            Console.WriteLine(numberOne + "  " + numberTwo + "  " + numberThree);
            Console.WriteLine();
            // 2.	Вывести на экран числа 5, 10 и 21 одно под другим. 
            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);
            Console.WriteLine();
            // 3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
            double centimeters;
            double metr;
            Console.WriteLine("Введите число в сантиметрах: ");
            centimeters = Int32.Parse(Console.ReadLine());
            metr = centimeters / 10;
            Console.WriteLine(metr + " метров");
            Console.WriteLine();
            // 4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            double week;
            week = 7;
            var day = 234;
            Console.WriteLine(day / week);
            Console.WriteLine();
            // 5.	Дано двузначное число. Найти:
            // a.	число десятков в нем;
            // b.	число единиц в нем;
            // c.	сумму его цифр;
            // d.	произведение его цифр
            int numberFour = 45;
            int decimalNum = 10;
            int oneNum = 1;
            Console.WriteLine("Десяток: " + (numberFour / decimalNum));
            Console.WriteLine("Единиц: " + (numberFour / oneNum));
            int sum = (numberFour / decimalNum) + (numberFour % decimalNum);
            Console.WriteLine("Сумма: " + sum);
            int multy = (numberFour / decimalNum) * (numberFour % decimalNum);
            Console.WriteLine("Произведение: " + multy);
            Console.WriteLine();
            // 6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            // a.	А или В; 
            // b.	А и В; 
            // c.	В или С.
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);
            Console.WriteLine();
            // 7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            int radius = 5;
            int length = 5;
            double squareСircle = Math.PI * radius * radius;
            double squareSquare = length * length;
            if (squareСircle > squareSquare)
            {
                Console.WriteLine("Круг больше");
            }
            else
            {
                Console.WriteLine("Квадрат больше");
            }
            // 8.	 Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?

            // 9.	 Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?

            // 10.	 Напечатать "столбиком": 
            // a.	все целые числа от 20 до 35;
            int numOne = 25;
            int numTwo = 35;
            for (int i = numOne; i <= numTwo; i++)
            {
                Console.WriteLine(i);
            }
            // b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            int numThree = 10;
            int numFour;

            Console.WriteLine("Введите число больше числа 10: ");
            numFour = Int32.Parse(Console.ReadLine());
            for (int i = numThree; i <= numFour; i++)
            {
                Console.WriteLine(i * i);
            }
            // c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
            int numFive;
            int numSix = 50;

            Console.WriteLine("Введите число меньше числа 50: ");
            numFive = Int32.Parse(Console.ReadLine());
            for (int i = numFive; i <= numSix; i++)
            {
                Console.WriteLine(i * i * i);
            }
            // d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
            int numSeven;
            int numNine;

            Console.WriteLine("Введите 2 числа через Enter: ");
            numSeven = Int32.Parse(Console.ReadLine());
            numNine = Int32.Parse(Console.ReadLine());
            for (int i = numSeven; i <= numNine; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
