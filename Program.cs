using System;


    class Program
    {
        public static double myCalculator(double n1, double n2, string sw)
        {
            double res = double.NaN; 

          switch (sw)
            {
                case "1":
                    res = n1 + n2;
                break;

                case "2":
                res = n1 - n2;
                    break;

                case "3":

                    res = n1 * n2;
                    break;

                case "4":

                    if (n2 != 0)
                    {
                        res = n1 / n2;
                    }

                    break;
                
                default:
                    break;
            }
            return res;
        }
    }

    class Kalkylator
    {
        static void Main(string[] args)
        {
            bool quitProg = false;

        Console.WriteLine("Basic calculator\r");


            Console.WriteLine("--------------\n");

            while (!quitProg)
            {
                
                string nm1 = "";

                string nm2 = "";

                double res = 0;

                
                Console.Write("Select a number ");


               nm1 = Console.ReadLine();

                double newNum1 = 0;


                while (!double.TryParse(nm1, out newNum1))
                {
                    Console.Write("Invalid input ");


                    nm1 = Console.ReadLine();
                }

                
                Console.Write("Select another number ");


                nm2 = Console.ReadLine();

                double newNum2 = 0;

                while (!double.TryParse(nm2, out newNum2))
                {
                    Console.Write("Invalid input ");

                    nm2 = Console.ReadLine();
                }

               
                Console.WriteLine("Choose an option");

                Console.WriteLine("\t1 - Add");
                Console.WriteLine("\t2 - Subtract");
                Console.WriteLine("\t3 - Multiply");
                Console.WriteLine("\t4 - Divide");

                Console.Write("Your choice? ");

                string sw = Console.ReadLine();

                try

                {
                    res = Program.myCalculator(newNum1, newNum2, sw);

                    if (double.IsNaN(res))
                    {
                        Console.WriteLine("This operation will result in a error.\n");
                    }

                    else Console.WriteLine("Your result: {0:0.##}\n", res);
                }

                catch (Exception e)

                {

                    Console.WriteLine("Oh no! An exception occurred.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

              
                Console.Write("Press 'q' and Enter to close the app, or press any other key and Enter to continue: ");


                if (Console.ReadLine() == "q") quitProg = true;


                Console.WriteLine("\n"); 
            }
            return;
        }
    }
