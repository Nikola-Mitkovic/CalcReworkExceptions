using System;

namespace work1
{
    public class WrongInputTypeException : Exception
    {
        public WrongInputTypeException(string z) : base(z)
        {
        }
    }
    public class ZeroDivisionException : Exception
    {
        public ZeroDivisionException(string o) : base(o)
        {
        }
    }
    public class NoInputParseException : Exception
    {
        public NoInputParseException(string n) : base(n)
        {
        }
    }
    public class Numbers
    {
        public static int X { get; set; }
        public static int Y { get; set; }
    }
    public class Program
    {
        public static void Add()
        {
            int add;
            int x = Numbers.X;
            int y = Numbers.Y;

            add = x + y;
            Console.WriteLine($"{x} + {y} = {add}");
        }
        public static void Subtract()
        {
            int sub;
            int x = Numbers.X;
            int y = Numbers.Y;

            sub = x - y;
            Console.WriteLine($"{x} - {y} = {sub}");
        }
        public static void Multiply()
        {
            int mult;
            int x = Numbers.X;
            int y = Numbers.Y;

            mult = x * y;
            Console.WriteLine($"{x} * {y} = {mult}");
        }
        public static void Divide()
        {
            double div;
            double x = Numbers.X;
            double y = Numbers.Y;

            if (y == 0)
            {
                throw (new ZeroDivisionException("Cannot divide by zero!!!"));
            }
            else
            {
                div = x / y;
                Console.WriteLine($"{x} / {y} = {div}");
            }
        }
        public static void ParseX()
        {
            string xs = Console.ReadLine();
            bool correct = int.TryParse(xs, out int x);
            bool nothing = String.IsNullOrEmpty(xs);
            if (correct)
            {
                Numbers.X = x;
                Console.WriteLine($"Your first chosen number is {x}, now please input the second number: ");
            }
            else if (nothing)
            {
                throw new NoInputParseException("Please input somethin!");
            }
            else
            {
                throw new WrongInputTypeException("That is not a number!");
            }
        }
        public static void ParseY()
        {
            string ys = Console.ReadLine();
            bool correct = int.TryParse(ys, out int y);
            bool nothing = String.IsNullOrEmpty(ys);
            if (correct)
            {
                Numbers.Y = y;
                Console.WriteLine($"Your second chosen number is {y}, begining operations: ");
            }
            else if (nothing)
            {
                throw new NoInputParseException("Please input somethin!");
            }
            else
            {
                throw new WrongInputTypeException("That is not a number!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! I will perform several mathematical operations on any 2 numbers of your choice! Please input the first number now: ");

            try
            {
                ParseX();
            }
            catch (WrongInputTypeException z)
            {
                Console.WriteLine("WrongInputTypeException: {0}", z.Message);
            }
            catch (ZeroDivisionException o)
            {
                Console.WriteLine("WrongInputTypeException: {0}", o.Message);
            }
            catch (NoInputParseException n)
            {
                Console.WriteLine("WrongInputTypeException: {0}", n.Message);
            }

            try
            {
                ParseY();
            }
            catch (WrongInputTypeException z)
            {
                Console.WriteLine("WrongInputTypeException: {0}", z.Message);
            }
            catch (ZeroDivisionException o)
            {
                Console.WriteLine("WrongInputTypeException: {0}", o.Message);
            }
            catch (NoInputParseException n)
            {
                Console.WriteLine("WrongInputTypeException: {0}", n.Message);
            }

            try
            {
                Add();
            }
            catch (WrongInputTypeException z)
            {
                Console.WriteLine("WrongInputTypeException: {0}", z.Message);
            }
            catch (ZeroDivisionException o)
            {
                Console.WriteLine("WrongInputTypeException: {0}", o.Message);
            }
            catch (NoInputParseException n)
            {
                Console.WriteLine("WrongInputTypeException: {0}", n.Message);
            }

            try
            {
                Subtract();
            }
            catch (WrongInputTypeException z)
            {
                Console.WriteLine("WrongInputTypeException: {0}", z.Message);
            }
            catch (ZeroDivisionException o)
            {
                Console.WriteLine("WrongInputTypeException: {0}", o.Message);
            }
            catch (NoInputParseException n)
            {
                Console.WriteLine("WrongInputTypeException: {0}", n.Message);
            }

            try
            {
                Multiply();
            }
            catch (WrongInputTypeException z)
            {
                Console.WriteLine("WrongInputTypeException: {0}", z.Message);
            }
            catch (ZeroDivisionException o)
            {
                Console.WriteLine("WrongInputTypeException: {0}", o.Message);
            }
            catch (NoInputParseException n)
            {
                Console.WriteLine("WrongInputTypeException: {0}", n.Message);
            }

            try
            {
                Divide();
            }
            catch (WrongInputTypeException z)
            {
                Console.WriteLine("WrongInputTypeException: {0}", z.Message);
            }
            catch (ZeroDivisionException o)
            {
                Console.WriteLine("WrongInputTypeException: {0}", o.Message);
            }
            catch (NoInputParseException n)
            {
                Console.WriteLine("WrongInputTypeException: {0}", n.Message);
            }
            Console.ReadLine();
        }
    }
}