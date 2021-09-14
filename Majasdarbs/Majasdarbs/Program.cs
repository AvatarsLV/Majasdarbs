using System;

namespace Majasdarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā tevi sauc?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Sveiks, {userName}");

            // --------------------------------------------------------------------



            Console.WriteLine("Kās ir tavs vecums?");
            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);

            int ageNextYear = age + 1;
            bool isAdult = age >= 18;

            Console.WriteLine($"Nākamgad tev paliks {ageNextYear}, Tu esi pilngadīgs: {isAdult}");

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Ievadi pirmo skailti");
            string UserNumber1 = Console.ReadLine();
            int Number1 = int.Parse(UserNumber1);
            Console.WriteLine("Ievadi otro skailti");
            string UserNumber2 = Console.ReadLine();
            int Number2 = int.Parse(UserNumber2);

            int LargerNumber = Math.Max(Number1, Number2);
            Console.WriteLine($"No abiem skaitliem : {LargerNumber} ir lielakais skaitlis");


            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Ievadi pirmo skailti");
            string UserNumber3 = Console.ReadLine();
            int Number3 = int.Parse(UserNumber1);
            Console.WriteLine("Ievadi otro skailti");

            string UserNumber4 = Console.ReadLine();
            int Number4 = int.Parse(UserNumber2);

            int SmallestNumber = Math.Min(Number3, Number4);
            Console.WriteLine($"No abiem skaitliem: {SmallestNumber} ir mazakais skaitlis");

            Console.WriteLine("---------------------------------------------------------------------------");


            Console.WriteLine("Ievadi pirmo skaitli A matematiskai darbibai B % A = atlikums");
            string UserNumber5 = Console.ReadLine();
            int Number5 = int.Parse(UserNumber5);

            Console.WriteLine("Ievadi otro skaitli B matematiskai darbibai B % A = atlikums");
            string UserNumber6 = Console.ReadLine();
            int Number6 = int.Parse(UserNumber6);


            int Dalijums = Number6 % Number5;
            Console.WriteLine($"{Number6} dalot ar {Number5} atlikums ir : {Dalijums}");
        }
    }
}
