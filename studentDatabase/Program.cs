using System;
using System.Collections.Generic;

namespace studentDatabase
{
    internal class Program
    {
        public class studentDev
        {
            //This is the class for what student is
            //A student must have the three properties below
            public string name;

            public string homeTown;

            public string favoriteFood;
        }

        private static void Main()
        {
            //This is the one object in the students class list
            //You can add all the students with all three
            //Property factors (Name,howntown,favorite food)
            List<studentDev> classmates = new List<studentDev>();

            classmates.Insert(0, new studentDev
            {
                name = "Andy Berr",
                homeTown = "Berkley, MI",
                favoriteFood = "French Fries",
            });

            classmates.Insert(0, new studentDev
            {
                name = "Cassly Sullen",
                homeTown = "Detroit, MI",
                favoriteFood = "Steak",
            });

            foreach (var item in classmates)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.homeTown);
                Console.WriteLine(item.favoriteFood);
                Console.WriteLine("\n-----------------------------\n");
            }

            string[] students = new string[11];
            students[0] = " ";
            students[1] = "Andy Berr";
            students[2] = "Cassly Sullen";
            students[3] = "Phillip Conrad";
            students[4] = "Zachary Parr";
            students[5] = "Cortez Christian";
            students[6] = "Erin Walter";
            students[7] = "Richard Moss";
            students[8] = "James Mitchell";
            students[9] = "Rick Magdaleno";
            students[10] = "Calyn Greene";

            string[] homeTown = new string[11];
            homeTown[0] = " ";
            homeTown[1] = "Berkley, MI";
            homeTown[2] = "Detroit, MI";
            homeTown[3] = "Canton, MI";
            homeTown[4] = "Wyandotte, MI";
            homeTown[5] = "Detroit, MI";
            homeTown[6] = "Troy, MI";
            homeTown[7] = "Canton, MI";
            homeTown[8] = "Yap, FSM";
            homeTown[9] = "Gilbert, AZ";
            homeTown[10] = "Portage, MI";

            string[] favoriteFood = new string[11];
            favoriteFood[0] = " ";
            favoriteFood[1] = "French Fries";
            favoriteFood[2] = "Steak";
            favoriteFood[3] = "Fried Chicken";
            favoriteFood[4] = "Sushi";
            favoriteFood[5] = "Chicken Fettuccine Alfredo";
            favoriteFood[6] = "Tacos";
            favoriteFood[7] = "Sushi";
            favoriteFood[8] = "Katsu";
            favoriteFood[9] = "Hamburger";
            favoriteFood[10] = "Mac and Cheese";

            bool runOn = true;

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn about? (Enter a number between 1-10)");

            while (runOn)
            {
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer >= 1 && answer <= 10)
                {
                    bool pickOne = true;

                    Console.WriteLine($"\nStudent {answer} is {students[answer]}. What would you like to know about {students[answer]}?\nEnter hometown or favorite food: ");
                    while (pickOne)
                    {
                        string choice = Console.ReadLine().ToLower();

                        if (choice == "hometown")
                        {
                            Console.WriteLine($"{students[answer]} is from {homeTown[answer]}. Would you like to know their favorite food? (Enter yes or no:)");
                            string food = Console.ReadLine().ToLower();
                            if (food == "yes")
                            {
                                Console.WriteLine($"{students[answer]} favorite food is {favoriteFood[answer]}.");
                                Console.WriteLine("Thanks for stoping by!");
                                pickOne = false;
                            }
                            else if (food == "no")
                            {
                                Console.WriteLine("Thanks for stoping by!");
                                pickOne = false;
                            }
                            else
                            {
                                Console.WriteLine("Please only enter yes or no: ");
                            }
                        }
                        else if (choice == "favorite food")
                        {
                            bool pickTwo = true;
                            Console.WriteLine($"{students[answer]} favorite food is {favoriteFood[answer]}. Would you like to know their hometown? (Enter yes or no:)");
                            while (pickTwo)
                            {
                                string town = Console.ReadLine().ToLower();
                                if (town == "yes")
                                {
                                    Console.WriteLine($"{students[answer]} hometown is {homeTown[answer]}.");
                                    Console.WriteLine("Thanks for stoping by!");
                                    pickTwo = false;
                                }
                                else if (town == "no")
                                {
                                    Console.WriteLine("Thanks for stoping by!");
                                    pickTwo = false;
                                }
                                else
                                    Console.WriteLine("Please only enter yes or no: ");
                            }
                            pickOne = false;
                        }
                        else
                        {
                            Console.WriteLine("Please only enter hometown or favorite food: ");
                        }
                    }
                    runOn = false;
                }
                else if (answer <= 1 || answer >= 10)
                {
                    Console.WriteLine("Try again only 1 to 10 numbers: ");
                }
            }

            Console.WriteLine("Do you want to know about another student? (Enter yes or no)");
            bool againWeGo = true;
            while (againWeGo)
            {
                string thisOne = Console.ReadLine().ToLower();

                if (thisOne == "yes")
                {
                    Main();
                    againWeGo = false;
                }
                else if (thisOne == "no")
                {
                    Console.WriteLine("Enjoy your day!");
                    againWeGo = false;
                }
                else
                {
                    Console.WriteLine("Please only enter yes or no: ");
                }
            }
        }
    }
}