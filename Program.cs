using ChallengeLeanTechJA.Context;
using ChallengeLeanTechJA.Modelo;
using System;
using System.Linq;

namespace ChallengeLeanTechJA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Challenge C# Junior Developer");
            Console.WriteLine("");
            Console.WriteLine("Select a option:");
            Console.WriteLine("");
            Console.WriteLine("1. Find Multiples of 3 of 5");
            Console.WriteLine("2. Find Power Number");
            Console.WriteLine("3. Make Matriz and sum diagonals");
            Console.WriteLine("4. Make Program to access database");
            Console.Write("Option: ");

            string option = string.Empty;
            option = Console.ReadLine();
            Console.WriteLine($"The option selected is: {option}");

            switch (option)
            {
                case "1":
                    Multiples();
                    break;
                case "2":
                    GetNumbersPower();
                    break;
                case "3":
                    MatrizDiagonals();
                    break;
                case "4":
                    GetProductos();
                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }

        private static void GetProductos()
        {

            Console.WriteLine("* * * Product List * * *");

            ContextDataAccess contextDataAccess = new ContextDataAccess();

            var productsList = contextDataAccess.Products.ToList();

            foreach (var item in productsList)
            {
                Console.WriteLine($"ProductId {item.ProductId}, Description {item.Description}, Reference {item.Reference}, Unit {item.Unit}, Status {item.Status}");
            }

        }

        private static void MatrizDiagonals()
        {
            Console.WriteLine("It was not implemented, please press any key to exit");
            Console.ReadLine();
        }

        static void Multiples()
        {
            Console.WriteLine("This method results in the sum of the multiples of 3 and 5 of a given number.");
            Console.Write("Enter the final number of the sequence: ");
            string numeroFinal = Console.ReadLine();
            int sumaMultiplo = 0;
            
            for (int i = 1; i < Convert.ToInt32(numeroFinal); i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"(Multiple of 3 -> {i})");
                    sumaMultiplo +=  i;
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine($"(Multiple of 5 -> {i})");
                        sumaMultiplo = sumaMultiplo + i;
                    }
                }
            }
            Console.WriteLine($"La suma de los multiplos de 3 o 5 es: {sumaMultiplo}");
            Console.ReadLine();
        }

        private static void GetNumbersPower()
        {

            int initialRange, finalRango, numberPower;

            Console.WriteLine("Enter starting range: ");
            initialRange = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter final range: ");
            finalRango = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter power number:");
            numberPower = int.Parse(Console.ReadLine());

            string numberString = string.Empty;
            double result = 0;
            bool foundNumber = false;

            for (int i = initialRange; i < finalRango; i++)
            {
                //dividir el numero es sus digitos
                numberString = i.ToString();
                result = 0;

                //Recorrer los digitos
                for (int j = 0; j < numberString.Length; j++)
                {
                    int digit = int.Parse(numberString[j].ToString());
                    //Realizar la operacion de exponenciacion y almacenar en variable que acumula 
                    result += Math.Pow(digit, numberPower);
                }

                //comparar la variable de acumulacion con el numero inicial 
                if (i == result)
                {
                    Console.WriteLine($"* * * The number {i} is the sum of its digits raised to the power {numberPower} * * *");
                    foundNumber = true;
                }
            }

            if (!foundNumber)
            {
                Console.WriteLine("No numbers were found in the range that matched the operation");
            }

        }


        private static void Inheritance()
        {

            Employee employee1 = new Employee { Id = 1, Name = "Jhonny A.", Address = "Street 5 avenue Lean", Age = 40, Salary = 2200 } ;
            Employee employee2 = new Employee { Id = 2, Name = "Jhonny A.", Address = "Street 5 avenue Lean", Age = 40, Salary = 2200 };
            Employee employee3 = new Employee { Id = 3, Name = "Jhonny A.", Address = "Street 5 avenue Lean", Age = 40, Salary = 2200 };

            Customer customer1 = new Customer { Id = 1, Name = "Jhonny A.", Address = "Street 5 avenue Lean", Age = 40, PricesListId = 1};
            Customer customer2 = new Customer { Id = 2, Name = "Jhonny A.", Address = "Street 5 avenue Lean", Age = 40, PricesListId = 1 };
            Customer customer3 = new Customer { Id = 3, Name = "Jhonny A.", Address = "Street 5 avenue Lean", Age = 40, PricesListId = 1 };

        }
    }
}
