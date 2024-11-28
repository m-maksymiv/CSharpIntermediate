﻿#region Methods
/// Signature of a Method
/// -> Name
/// -> Number and Type of parameters
/// Overloading Methods
/// -> Having a method with the same name but different signatures
#endregion

namespace Classes;

public static class Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        //public void Move(Point newLocation)
        //{
        //    X = newLocation.X;
        //    Y = newLocation.Y;
        //}

        public void Move(Point newLocation)
        {
            if (newLocation is null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }

    static void UsePoints()
    {
        try
        {
            var point = new Point(10, 20);

            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

            point.Move(null);
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occured.");
        }
    }

    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
                sum += number;

            return sum;
        }
    }

    static void UseParams()
    {
        var calculator = new Calculator();

        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 3));
        Console.WriteLine(calculator.Add(1, 2, 3, 4));
        Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
    }

    public static void MethodsProgram()
    {
        Console.WriteLine("Start -> Methods");

        //var number = int.Parse("abc");
        int number;
        var result = int.TryParse("abc", out number);
        if (result)
            Console.WriteLine(number);
        else
            Console.WriteLine("Conversion feiled.");

        Console.WriteLine("Finish -> Methods");
    }
}
