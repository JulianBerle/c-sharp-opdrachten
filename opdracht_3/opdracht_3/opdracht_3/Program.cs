namespace Opdracht3

{

    class Program

    {

        static void Main(string[] args)

        {

            if (args != null && args.Length > 2)

            {

                

                decimal numberOne = Convert.ToDecimal(args[0]);
                decimal numberTwo = Convert.ToDecimal(args[2]);
                decimal[] array1 = { numberOne, numberTwo };

                switch (args[1])
                {
                    case "+":
                        Console.WriteLine($"{args[0].ToString()} {args[1].ToString()} {args[2].ToString()} is: {array1.Sum()}");
                        break;
                    case "*":
                        Console.WriteLine($"{args[0].ToString()} {args[1].ToString()} {args[2].ToString()} is: {numberOne * numberTwo}");
                        break;
                    case "/":
                        Console.WriteLine($"{args[0].ToString()} {args[1].ToString()} {args[2].ToString()} is: {numberOne % numberTwo}");
                        break;
                    case "-":
                        Console.WriteLine($"{args[0].ToString()} {args[1].ToString()} {args[2].ToString()} is: {numberOne - numberTwo}");
                        break;
                }

            }
            else

            {

                Console.WriteLine("Geef 2 cijfers en een operator mee om een som mee te berekenen");

            }
        }

    }

}