using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Денис";
            string lastName = "Карпеев";
            byte age = 24;
            string email = "denio4141@gmail.com";
            object ballProgramm = "6,1";
            object ballMat = "4,2";
            object ballFiz = "5,3";

            string newPattern = "Имя: {0} \nФамилия: {1} \nДата рождения: {2} \nПочта: {3} \nБаллы по программированию: {4} \nБаллы по математики: {5} \nБаллы по физике: {6}";
            Console.WriteLine(newPattern,
                firstName,
                lastName,
                age,
                email,
                ballProgramm,
                ballMat,
                ballFiz);
            Console.ReadKey();

            double valueA = 6.1; double valueB = 4.2; double valueC = 5.3;
            double valueD = valueA + valueB + valueC;
            double valueS = 15.6; int valueQ = 3;
            double valueL = valueS / valueQ;


            Console.WriteLine("Колличество баллов:" + valueD);
            Console.WriteLine("Средний балл:" + valueL);
            Console.ReadKey();

        }
    }
}
