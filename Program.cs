
// Перегрузка операторов

using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Figure1.V(12.2));
            Console.WriteLine(Figure1.V(12.22, 34.11, 99.6));

            Console.WriteLine("\n");

            Console.WriteLine(Number1.PrintMax(12, 10));

            Console.WriteLine("\n");

            Console.WriteLine(Number2.Multiply(-12, -10));
            Console.WriteLine(Number2.Multiply(12.99, 10.11));
            Console.WriteLine(Number2.Multiply(121212121212, 90));
            Console.WriteLine(Number2.Multiply(0, 10));

            Console.WriteLine("\n");

            Student bob = new Student("Bob Peter Andersen", 3.5, 5, "15.07.2024");
            Student sue = new Student("Sue Augustina Lorenzzo", 5, 3, "21.07.2024");
            Student victor = new Student("Victor Petrovich Diakonov", 5, 5, "30.07.2024");

            Console.WriteLine("Bob better Sue? " + (bob > sue));
            Console.WriteLine("Victor better Sue? " + (victor > sue));
            Console.WriteLine("Bob better Victor? " + (bob > victor));

            Console.WriteLine("Bob has passed? " + (Admission.IsPass(bob)));
            Console.WriteLine("Victor has passed? " + (Admission.IsPass(victor)));
            Console.WriteLine("Sue has passed? " + (Admission.IsPass(sue)));

            Console.WriteLine("\n");

            Console.WriteLine(Figure2.Volume(12));
            Console.WriteLine(Figure2.Volume(1, 5));

            Console.WriteLine("\n");

            Console.WriteLine(Figure3.S(9));
            Console.WriteLine(Figure3.S(11, 33, 22));

            Console.WriteLine("\n");

            Console.WriteLine(Figure4.Square(7));
            Console.WriteLine(Figure4.Square(5, 2));

            Console.WriteLine("\n");

            Console.WriteLine(Figure5.Sq(7));
            Console.WriteLine(Figure5.Sq(5.2, 2.44));
            Console.WriteLine(Figure5.Sq(4, 3));
            Console.WriteLine(Figure5.Sq(9, 1, 7));

            Console.WriteLine("\n");

            Console.WriteLine(Figure6.P(7));
            Console.WriteLine(Figure6.P(5.2, 2.44));
            Console.WriteLine(Figure6.P(4.5, 3, 6));
            Console.WriteLine(Figure6.P(9, 1, 7));

            Console.WriteLine("\n");

            int[] arr = { 34, 4, 1, 12, 10 };
            Console.WriteLine(Array1.AverageNum(arr));

            double[] arr2 = { 12.88, 9.9, 0.88, 77.11 };
            Console.WriteLine(Array1.AverageNum(arr2));

            Console.WriteLine("\n");

            Console.WriteLine(Array2.MaxNum(arr));
            Console.WriteLine(Array2.MaxNum(arr2));

            Console.WriteLine("\n");

            Deposit deposit = new Deposit("Georgy Smith Sedric", 1000);
            Console.WriteLine($"Sum before = {deposit.GetSum()}");
            deposit++;
            Console.WriteLine($"Sum after = {deposit.GetSum()}");

            Console.WriteLine("\n");

            Credit credit1 = new Credit("Georgy Smith Sedric", 1000);
            Credit credit2 = new Credit("Sally Goodman Smith", 500);
            Console.WriteLine($"Sum before = {credit1.GetSum()}");
            Console.WriteLine($"Payment = {credit1.GetPercent()}");

            Console.WriteLine($"Difference between sum and payment = {credit1.GetSum() - credit1.GetPercent()}");

            Console.WriteLine("\n");

            College c = new College("Top", 500, 20, 30);
            College c2 = new College("Toppp", 700, 40, 50);
            Console.WriteLine(c < c2);
            Console.WriteLine(Standart.isFits(c));

            Console.WriteLine("\n");

            Cat barsik = new Cat("Barsik", "siam", "12.02.2020", 3);
            Cat Tolik = new Cat("Tolik", "siam", "30.10.2017", 5);
            Console.WriteLine(barsik > Tolik);
            Console.WriteLine(barsik * Tolik);
            Console.WriteLine(CatWeight.WhatShape(Tolik));

            Console.WriteLine("\n");

            Human kolan = new Human("Коля Петров Николаевич", "male", 16, "голубые");
            Human anya = new Human("Анна Сергеевна Йомае", "female", 25, "карие");

            Console.WriteLine(kolan + anya);
            Console.WriteLine(Efficiency.IsEfficiency(kolan));
            Console.WriteLine(Efficiency.IsEfficiency(anya));

            Console.WriteLine("\n");

            Game game = new Game("Skater 2", 2000, 10000, 8.6, 9.0, 2.4);
            game++;
            Console.WriteLine(PopularGame.IsGamePopular(game));

        }
    }
}
