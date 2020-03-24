using System;

namespace BreakExercises
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.Flip the boolean 🙃

            Console.WriteLine("I like to ask you something, you answer only with true or false. Type YES if you're ready!");
            string answering = Console.ReadLine().ToUpper();

            bool yes = true;
            bool no = false;
    


            if (answering == "YES")
            {
                Console.WriteLine("Go ahead...");
            }
            else if (answering != "YES")
            {
                Console.WriteLine("Than stay cool...");
            }


            Console.WriteLine("Have you ever watched the Glow movie?");
            string yesOrNo = Console.ReadLine().ToUpper();

            if (yesOrNo == "TRUE")
            {
                Console.WriteLine(no);
            }
            else if (yesOrNo == "FALSE")
            {
                Console.WriteLine(yes);
            }
            else
            {
                Console.WriteLine("Error, incorrect value. Write TRUE or FALSE only!!!");
            }















            //2.Multiple of 100 ✖️

            Console.WriteLine("ENTER A NUMBER");
            int user;
            bool check;

            do
            {
                check = Int32.TryParse(Console.ReadLine(), out user);
                Console.WriteLine("You entered: " + user);
                if (!check) Console.WriteLine("Can't you read? Enter a number, not anything else!");
                else break;
            } while (true);

            if (user % 100 == 0)
            {
                Console.WriteLine("You have entered a cool number!");
            }
            else
            {
                Console.WriteLine("The number you've enterd is not cool at all!");
            }









            //3. Return name of month 🗓️

            Console.WriteLine("Enter a number from 1-12");
            int userType = int.Parse(Console.ReadLine());

            switch (userType)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Error, incorrect value");
                    break;
            }






            //4.Profitable Gamble 🎰

            Console.WriteLine("Enter a prob");
            int inputProb = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a prize");
            int inputPrize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a pay");
            int inputPay = int.Parse(Console.ReadLine());

            if (inputProb * inputPrize > inputPay)
            {
                Console.WriteLine("Yoy won!");
            }
            else
            {
                Console.WriteLine("false");
            }













            //5.The Farm Problem 🐔

            //Console.WriteLine("Farmer wants to know the total number of legs of his animals");


            Console.WriteLine("Chicken legs:");
            int chickens = int.Parse(Console.ReadLine());
            int countChickens = chickens * 2;
            Console.WriteLine("Cows legs:");
            int cows = int.Parse(Console.ReadLine());
            int countCows = cows * 4;
            Console.WriteLine("Pigs legs:");
            int pigs = int.Parse(Console.ReadLine());
            int countPigs = pigs * 4;

            int count = countChickens + countCows + countPigs;

            Console.WriteLine("Chicken Legs: " + countChickens);
            Console.WriteLine("Cows Legs: " + countCows);
            Console.WriteLine("Pigs Legs: " + countPigs);
            Console.WriteLine("Total Legs: " + count);







            //6.Word count 🖖

            Console.WriteLine("Write a sentence");

            string sentence = Console.ReadLine();
            string checkIn;

            checkIn = "Character count: " + sentence.Length.ToString();

            Console.WriteLine(checkIn);








            //For the bravest!
            //7.Liquor store 🥂

            Console.WriteLine("Welcome");
            Console.WriteLine("Your ID CARD please!");
            string firstName = "Hristijan";
            string lastName = "Petrovski";
            bool validation;
            int customer;
            string drinkName;
            int age = 18;

            Console.WriteLine("What kind of drink you want?");
            drinkName = Console.ReadLine();


            Console.WriteLine("Are you an adult?  (Type how old is he/she)");

            do
            {
                validation = int.TryParse(Console.ReadLine(), out customer);
                if (validation) Console.WriteLine("Customer has: " + customer + " " + "years old");
                else if (customer != age) Console.WriteLine("Please enter a valid input!");
                if (customer >= age) Console.WriteLine($"Dear {firstName} {lastName} here's your {drinkName}, have a nice day!");
                else if (customer < 18) Console.WriteLine($"Dear {firstName} {lastName}, I am sorry but you are not allowed to buy alchocol!");

                else break;
            } while (true);







            //8.Coffe machine ☕


            Console.WriteLine($"1.Espresso...........2$\n" +
                $"2.Macchiato........3.5$\n" +
                $"3.Latte..............4$\n" +
                $"4.Cappuccino.........6$\n" +
                $"5.Tea..............1.5$");

            double espresso = 2;
            double macchiato = 3.5;
            double latte = 4;
            double cappuccino = 6;
            double tea = 1.5;
            bool validate;
            int money;
            int coffe;




            Console.WriteLine("Welcome dear customer. Please select a drink");

            while (true)
            {
                bool drink = int.TryParse(Console.ReadLine(), out coffe);
                if (!drink) Console.WriteLine("Please select a drink!");
                else break;
            }


            switch (coffe)
            {
                case 1:
                    Console.WriteLine("You choose espresso!");
                    break;
                case 2:
                    Console.WriteLine("You choose macchiato!");
                    break;
                case 3:
                    Console.WriteLine("You choose latte!");
                    break;
                case 4:
                    Console.WriteLine("You choose cappuccino!");
                    break;
                case 5:
                    Console.WriteLine("You choose tea!");
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }


            Console.WriteLine("Sweetness level 1-5");
            int sugar = int.Parse(Console.ReadLine());

            if (sugar <= 5)
            {
                Console.WriteLine("Added sugar");
            }
            else
            {
                Console.WriteLine("ERROR!");
            }





            Console.WriteLine("Put money");

            do
            {
                validate = int.TryParse(Console.ReadLine(), out money);
                if (!validate) Console.WriteLine("Enter Again");
                else break;
            } while (true);


            switch (coffe)
            {
                case 1:
                    if (money < espresso)
                    {
                        Console.WriteLine($"The espresso costs {espresso}$, you are missing {espresso - money}$ to buy it!");
                    }
                    else
                    {
                        Console.WriteLine("Enjoy your drink!");
                    }
                    break;
                case 2:
                    if (money < macchiato)
                    {
                        Console.WriteLine($"The espresso costs {macchiato}$, you are missing {macchiato - money}$ to buy it!");
                    }
                    else
                    {
                        Console.WriteLine("Enjoy your drink!");
                    }
                    break;
                case 3:
                    if (money < latte)
                    {
                        Console.WriteLine($"The latte costs {latte}$, you are missing {latte - money}$ to buy it!");
                    }
                    else
                    {
                        Console.WriteLine("Enjoy your drink!");
                    }
                    break;
                case 4:
                    if (money < cappuccino)
                    {
                        Console.WriteLine($"The cappuccino costs {cappuccino}$, you are missing {cappuccino - money}$ to buy it!");
                    }
                    else
                    {
                        Console.WriteLine("Enjoy your drink!");
                    }
                    break;
                case 5:
                    if (money < tea)
                    {
                        Console.WriteLine($"The tea costs {tea}$, you are missing {tea - money}$ to buy it!");
                    }
                    else
                    {
                        Console.WriteLine("Enjoy your drink!");
                    }
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }










            //9.Future prediction 🔮

            int randomNumber;

            Random stringsDisplaying = new Random();

            string[] randomStrings = { "You got a jackpot 1.000.000EUR", "You will lost weights", "Your boyfriend will break up with you!", "Your cousine will buy you a dog!", "You will leave 100 years!" };

            randomNumber = stringsDisplaying.Next(0, 4);

            Console.WriteLine("Your future is: " + randomStrings[randomNumber]);









            //10.Farenheit to Celsius conversion🌡️


            Console.WriteLine("Convert from celsius degrees to Kelvin and Fahrenheit");
            double celsius = int.Parse(Console.ReadLine());
            double kelvin = celsius + 273;
            double fahrenheit = (celsius * 1.8) + 32;


            Console.WriteLine($" - Celsius degrees to Kelvin is: {kelvin} \n - Celsius degrees to Fahrenheit is: {fahrenheit}");







            Console.ReadLine();
        }
    }
}
