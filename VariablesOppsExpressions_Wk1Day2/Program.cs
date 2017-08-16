using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOppsExpressions_Wk1Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Amy";
            //Console.WriteLine(name);

            name = "Dave";
            //Console.WriteLine(name);
            string Name = "Amy";
            string birthMonth = "March";
            //Console.WriteLine(birthMonth);
            //integers
            int birthMonthNumber = 3;
            int age = 65;
            int population = 100000;
            //floating type variables
            //float number = 2.164403304897294383961032f;
            //double someNumber = 2.164403304897294383961032d;
            //decimal partialNumber = 2.164403304897294383961032m;

            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);




            //Boolean
            bool isPresent = true;
            bool seatTaken = false;
            //Character
            char lastLetter = 'j';

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge > samAge);

            //Practice problems turning english  into c#
            int mikePaid = 13;
            Console.WriteLine(mikePaid * 4);

            int totalCups = 7;
            Console.WriteLine(totalCups - 2);

            int totalMoney = 40;
            int package = 8;
            Console.WriteLine(totalMoney / package);

            int allMoney = 41;
            int weekendMoney = 29;
            Console.WriteLine(allMoney - weekendMoney);

            int juliaMiles = 47;
            int previousMiles = 30;
            int pravasMiles = juliaMiles - previousMiles;
            Console.WriteLine(pravasMiles);

            int envelopeMoney = 12;
            int box = 3;
            int envelopes = envelopeMoney / box;
            Console.WriteLine(envelopes);

            float noraMoney = 27.10f;
            float salad = 5.12f;
            Console.WriteLine(noraMoney + salad);


         


        }
    }
}
