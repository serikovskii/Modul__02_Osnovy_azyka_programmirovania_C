﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            var firstNumber = 7;
            var secondNumber = 3;
            var thirdNumber = 4;
            int x = 1;
            double y;

            y = firstNumber * Math.Pow(x, 2) - secondNumber * x + thirdNumber;
            Console.WriteLine(y);
            Console.WriteLine();

            //#2
            var radius = 6;
            double lenght;
            double square;
            var numberLenght = 2;
            square = Math.PI * Math.Pow(radius, 2);
            lenght = numberLenght * Math.PI * radius;
            Console.WriteLine("Площадь = " + square);
            Console.WriteLine("Окружность = " + lenght);
            Console.WriteLine();

            //#3
            var centimeterNumber = 24554;
            var metr = 100.0;
            double metrNumber = centimeterNumber / metr;
            Console.WriteLine(metrNumber + " метров");
            Console.WriteLine();

            //#4
            var day = 234;
            double oneWeek = 7;
            double week = day / oneWeek;

            Console.WriteLine(week + " недель");
            Console.WriteLine();

            //#5
            int number = 25;
            int numberTen = 10;
            int numberOne = 1;
            Console.WriteLine(number / numberTen + " десяток");
            Console.WriteLine(number / numberOne + " единиц");
            int sumNumber = 0;
            int tmp;

            tmp = number % 10;
            sumNumber = tmp + number / numberTen;

            Console.WriteLine("Сумма его цифр = " + sumNumber);
            long compositionNumber;

            tmp = number % 10;
            compositionNumber = tmp * (number / numberTen);
            Console.WriteLine("Произведение его цифр = " + compositionNumber);
            Console.WriteLine();

            //#6
            int numberFour = 6549;
            int numberTmp;
            int sumFour = 0;
            int multiFour = 1;
            while (numberFour > 0)
            {
                numberTmp = numberFour % 10;
                numberFour /= 10;
                sumFour += numberTmp;
                multiFour *= numberTmp;

            }
            Console.WriteLine("Сумма чисел: " + sumFour);
            Console.WriteLine("Произведение чисел: " + multiFour);

            Console.ReadLine();
        }
    }
}
