namespace Opdracht2

{

    class Program

    {

        static void Main(string[] args)

        {

            if (args != null && args.Length > 1)

            {
                decimal numberOne = Convert.ToDecimal(args[0]);
                decimal numberTwo = Convert.ToDecimal(args[1]);
                decimal[] array1 = { numberOne, numberTwo};

                Console.WriteLine($"De som met {args[0].ToString()} en {args[1].ToString()} is: {array1.Sum()}");

            }
            else

            {

                Console.WriteLine("Geef je 2 cijfers mee om een som mee te berekenen");

            }
        }

    }

}