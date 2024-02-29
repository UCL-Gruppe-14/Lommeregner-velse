namespace Opgave_uge_9
{
    public class Calculator
    {
        public void Add(int x, int y)
        {
            int Res = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, Res);
        }

        public void Subtract(int x, int y)
        {
            int Res = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, Res);
        }

        public void Multiply(int x, int y)
        {
            int Res = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, Res);
        }

        public void Divide(int x, int y)
        {
            double Res = (double)x / (double)y;
            Console.WriteLine("{0} / {1} = {2}", x, y, Res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int valg;
            bool Continue = true;
            bool forsøg;
            do
            {
                do
                {
                    Console.Write("Indtast første nummer: ");
                    forsøg = false;
                    try
                    {
                        x = int.Parse(Console.ReadLine());

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Forkert input");
                        forsøg = true;
                    }
                } while (forsøg == true);

                do
                {
                    Console.Write("Indtast andet nummer: ");
                    forsøg = false;
                    try
                    {
                        y = int.Parse(Console.ReadLine());

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Forkert input");
                        forsøg = true;
                    }
                } while (forsøg == true);

                Calculator Lommeregner = new Calculator();

                

                do
                {
                    Console.Write("Hvilken regneoperation ønskes? \n 1. Addition \n 2. Subtraktion \n 3. Multiplikation \n 4. Division \nVælg 1-4: ");
                    valg = int.Parse(Console.ReadLine());
                    forsøg = false;
                    switch (valg)
                    {
                        case 1:
                            Lommeregner.Add(x, y);
                            break;
                        case 2:
                            Lommeregner.Subtract(x, y);
                            break;
                        case 3:
                            Lommeregner.Multiply(x, y);
                            break;
                        case 4:
                            Lommeregner.Divide(x, y);
                            break;
                        default:
                            Console.WriteLine("Ugyldig");
                            forsøg = true;
                            break;
                    }
                    Console.WriteLine("Vil du regne yderligere: \n1: ja\n2: Nej \nSvar: ");
                    valg = 0;
                    valg = int.Parse(Console.ReadLine());
                    if (valg == 2)
                    {
                        Console.WriteLine("Farvel");
                        Continue = false;
                    }
                       
                } while (forsøg == true);
                
            }while (Continue == true);
            
        }
    }
}
