using System;

namespace HomeworkBaseLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вывода на экран в одну строку трех любых чисел.

            int firstNumber, secondNumber, thirdNumber;

            Console.WriteLine("Введите три целых числа:");

            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());
            thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber}  {secondNumber}  {thirdNumber}");
            Console.WriteLine();

            // Вывести на экран числа 5, 10 и 21 одно под другим.

            int firstValue = 5;
            int secondValue = 10;
            int thirdValue = 21;

            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(thirdValue);
            Console.WriteLine();
            // Дано расстояние в сантиметрах. Найти число полных метров в нем.

            double distanceCm;
            double distanceMetre;

            Console.WriteLine("Введите растояние (см):");

            distanceCm = double.Parse(Console.ReadLine());

            distanceMetre = distanceCm / 100;


            Console.Write("Растояние в метрах (м) = ");
            Console.WriteLine(distanceMetre);
            Console.WriteLine();
            // С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период ?

            Console.WriteLine("Введите номер дня недели:");
            Console.WriteLine("1- Понедельник");
            Console.WriteLine("2- Вторник");
            Console.WriteLine("3- Среда");
            Console.WriteLine("4- Четверг");
            Console.WriteLine("5- Пятница");
            Console.WriteLine("6- Суббота");
            Console.WriteLine("7- Воскресение ");

            int numberDayOfWeek;
            int quantityWeek = 0;
            numberDayOfWeek = int.Parse(Console.ReadLine());

            if (numberDayOfWeek > 0 && numberDayOfWeek <= 7)
            {
                switch (numberDayOfWeek)
                {
                    case 1:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 2:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 3:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 4:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 5:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 6:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 7:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                }
                Console.WriteLine($"За период 234 дня прошло {quantityWeek} недели.");
            }
            else
            {
                Console.WriteLine("Не корректный ввод данных!");
            }
            Console.WriteLine();

            /*
               Дано двузначное число. Найти:
                   a.	число десятков в нем;
                   b.	число единиц в нем;
                   c.	сумму его цифр;
                   d.	произведение его цифр;            
            */

            int twoDigitNamber;

            Console.WriteLine("Введите двузначное число");
            twoDigitNamber = int.Parse(Console.ReadLine());

            Console.WriteLine("Число десяток = {0}", twoDigitNamber / 10);
            Console.WriteLine("Число единиц = {0}", twoDigitNamber % 10);
            Console.WriteLine("Сумма цифр = {0}", twoDigitNamber % 10 + twoDigitNamber / 10);
            Console.WriteLine("Произведение цифр = {0}", (twoDigitNamber / 10) * (twoDigitNamber % 10));
            Console.WriteLine();

            // Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            // a.А или В;
            // b.А и В;
            // c.В или С.

            bool A = true;
            bool B = false;
            bool C = false;

            bool resultA, resultB, resultC;
            resultA = A || B;
            resultB = A && B;
            resultC = B || C;

            Console.WriteLine($"Результаты: {resultA}, {resultB}, {resultC}");
            Console.WriteLine();

            // Даны радиус круга и сторона квадрата.У какой фигуры площадь больше?

            Console.WriteLine("Введите радиус круга (см): ");
            double circleRadius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата (см): ");
            double sideSquare = double.Parse(Console.ReadLine());

            double circleS, squareS;
            squareS = circleRadius * circleRadius;
            circleS = 3.14 * (circleRadius * circleRadius);

            if (squareS < circleS)
            {
                Console.WriteLine("Площадь круга больше чем площадь квадрата.");
            }
            else if (squareS == circleS)
            {
                Console.WriteLine("Площадь круга и квадрата равны.");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше чем площадь круга.");
            }
            Console.WriteLine();

            // Даны объемы и массы двух тел из разных материалов.Материал какого из тел имеет большую плотность?

            double firstMaterialWeight, secondMaterialWeight;

            Console.WriteLine("Введите массу первого материала (кг):");
            firstMaterialWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу второго материала (кг):");
            secondMaterialWeight = double.Parse(Console.ReadLine());

            double firstMaterialValume, secondMaterialValume;

            Console.WriteLine("Введите объем первого материала (М3):");
            firstMaterialValume = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем второго материала (М3):");
            secondMaterialValume = double.Parse(Console.ReadLine());

            if (firstMaterialWeight / firstMaterialValume < secondMaterialWeight / secondMaterialValume)
            {
                Console.WriteLine("Плотность второго материала больше первого.");
            }
            else if (firstMaterialWeight / firstMaterialValume == secondMaterialWeight / secondMaterialValume)
            {
                Console.WriteLine("Плотность материалов равны.");
            }
            else
            {
                Console.WriteLine("Плотность первого материала больше второго");
            }
            Console.WriteLine();

            // Известны сопротивления двух несоединенных друг с другом участков электрической
            // цепи и напряжение на каждом из них. По какому участку протекает меньший ток?

            Console.WriteLine("Введите сопротивление и напряжение в сети первого участка:");

            Console.WriteLine("Сопротивление (Ом):");
            double firstR = double.Parse(Console.ReadLine());

            Console.WriteLine("Напряжение (В):");
            double firstU = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сопротивление и напряжение в сети первого участка:");

            Console.WriteLine("Сопротивление (Ом):");
            double secondR = double.Parse(Console.ReadLine());

            Console.WriteLine("Напряжение (В):");
            double secondU = double.Parse(Console.ReadLine());

            if (firstU / firstR < secondU / secondR)
            {
                Console.WriteLine("Сила тока первого участка меньше второго.");
            }
            else if (firstU / firstR == secondU / secondR)
            {
                Console.WriteLine("Сила тока на обеих участков раны.");
            }

            else
            {
                Console.WriteLine("Сила тока второго участка меньше первого.");
            }
            Console.WriteLine();

            // Напечатать "столбиком": 
            // a.все целые числа от 20 до 35;
            // b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
            // c.третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);
            // d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).

            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }


            int valueB;            
            bool flagB = true;
            while (flagB)
            {
                Console.WriteLine("Введите число больше 10:");
                valueB = int.Parse(Console.ReadLine());
                if (valueB > 10)
                {
                    for (int i = 11; i <= valueB; i++)
                    {
                        Console.WriteLine(i * i);
                    }
                    flagB = false;
                }
                else
                {
                    Console.WriteLine("Не верный ввод!");
                    continue;
                }
            }
            Console.WriteLine();

            int valueA;
            bool flagA = true;
            
            while (flagA)
            {
                Console.WriteLine("Введите число меньше 50:");
                valueA = int.Parse(Console.ReadLine());

                if (valueA < 50)
                {
                    for (int i = valueA; i < 50; i++)
                    {
                        Console.WriteLine(i * i * i);
                    }
                    flagA = false;
                }
                else
                {
                    Console.WriteLine("Не верный ввод!");
                    continue;
                }
            }

            int numberA, numberB;
            bool flagAB = true;
           
            while (flagAB)
            {
                Console.WriteLine("Введите первое целое число :");
                numberA = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе целое число :");
                numberB = int.Parse(Console.ReadLine());

                if (numberB > numberA)
                {
                    for (int i = numberA; i <= numberB; i++)
                    {
                        Console.WriteLine(i);
                    }
                    flagAB = false;
                }
                else
                {
                    Console.WriteLine("Второе число должно быть больше первого.");
                    continue;
                }
            }

            Console.ReadLine();
        }
    }
}
