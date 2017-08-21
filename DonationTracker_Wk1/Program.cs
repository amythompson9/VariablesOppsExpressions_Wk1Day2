using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationTracker_Wk1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for donating to our organization.");

            Console.WriteLine("What is your first name and last name?");
            string firsLasttName = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();

            Console.WriteLine("What is your street address, city, state, and zip code?");
            string streetAddress = Console.ReadLine();

            //Console.WriteLine("What city do you live in?");
            //string city = Console.ReadLine();

            //Console.WriteLine("What state do you live in?");
            //string state = Console.ReadLine();

            //Console.WriteLine("What is your zipcode?");
            //string zipcode = Console.ReadLine();

            Console.WriteLine("What is your email address?");
            string emailAddress = Console.ReadLine();

            Console.WriteLine("What year are you making this donation?");
            string year = Console.ReadLine();

            Console.WriteLine("How many quarters are you donating? Please enter a numerical value");
            int quarterNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(quarterNumber * .25);

            Console.WriteLine("How many dollar bills are you donating? Please enter a numerical value");
            int dollarNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(dollarNumber * 1);

            Console.WriteLine("How many five dollar bills are you donating? Please enter a numerical value");
            int fiveNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(fiveNumber * 5);

            Console.WriteLine("How many ten dollar bills are you donating? Please enter a numerical value");
            int tenNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(tenNumber *10);

            Console.WriteLine("How many fifty dollar bills are you donating? Please enter a numerical value");
            int fiftyNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(fiftyNumber * 50);

            Console.WriteLine("How many one hundred dollar bills are you donating? Please enter a numerical value");
            int hundredNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(hundredNumber * 100);

            Console.WriteLine("Thank you for your donation.  Here is your total donation.");
            Console.WriteLine((quarterNumber * .25) + (dollarNumber * 1) + (fiveNumber * 5) + (tenNumber * 10) + (fiftyNumber * 50) + (hundredNumber * 100));

            Console.WriteLine("Thank you again for your donation.  Here is a copy of your receipt.");
                
            Console.WriteLine("Full Name");
            Console.WriteLine(firsLasttName);
            Console.WriteLine("Full Address");
            Console.WriteLine(streetAddress);
            Console.WriteLine("Year");
            Console.WriteLine(year);
            Console.WriteLine("Email Address");
            Console.WriteLine(emailAddress);
            Console.WriteLine("Quarters");
            Console.WriteLine(quarterNumber * .25);
            Console.WriteLine("Dollars");
            Console.WriteLine(dollarNumber * 1);
            Console.WriteLine("Five Dollars");
            Console.WriteLine(fiveNumber * 5);
            Console.WriteLine("Ten Dollars");
            Console.WriteLine(tenNumber * 10);
            Console.WriteLine("Fifty Dollars");
            Console.WriteLine(fiftyNumber * 50);
            Console.WriteLine("One Hundred Dollars");
            Console.WriteLine(hundredNumber * 100);
            Console.WriteLine("Total Donation");
            Console.WriteLine((quarterNumber * .25) + (dollarNumber * 1) + (fiveNumber * 5) + (tenNumber * 10) + (fiftyNumber * 50) + (hundredNumber * 100));










        }
    }
}
