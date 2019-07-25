using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                List<string> studentNames = new List<string>
            {
                "Jake", "Jess", "Chris", "Paula", "Levi"

            };

                List<string> hometown = new List<string>
            {
                "Ortonville", "Ferndale", "Novi", "Livonia", "Levi"

            };

                List<string> favoriteFood = new List<string>
            {
                "Pizza", "Pasta", "Lobster", "Hamburger", "Burrito"

            };

                List<string> favoriteMovie = new List<string>
            {
                "Lord of the Rings", "The Lion King", "Star Wars", "Wall-E", "The Matrix"

            };


                AddUserInput(studentNames, hometown, favoriteFood, favoriteMovie);
                PrintStudentNumber(studentNames);
                int validate = ValidateUserChoice("validate",studentNames);
                DisplayInfo(validate, studentNames, hometown, favoriteFood, favoriteMovie);
                AskForOtherStudent();
            } 
        }

        public static void AddUserInput(List<string> names, List<string> hometown, List<string> favoriteFood, List<string> movie)
        {
            Console.WriteLine("Would you like to add a student to the database");
            string yesorno = Console.ReadLine();

            if (yesorno == "yes")
            {

                string username = GetUserInput("Give me their first name");
                string userHometown = GetUserInput("Give me their hometown");
                string userFavoriteFood = GetUserInput("Give me their favorite food");
                string userFavoriteMovie = GetUserInput("Give me their favorite movie");


                names = AddToList(username, names);
                hometown = AddToList(userHometown, hometown);
                favoriteFood = AddToList(userFavoriteFood, favoriteFood);
                movie = AddToList(userFavoriteFood, movie);

                string addorInfo = AddorGetInfo();
                if (addorInfo == "add")
                {
                    AddUserInput(names, hometown, favoriteFood, movie);

                }

                else if (addorInfo == "info")
                {

                }

                else
                {
                    Console.WriteLine("Invalid input");
                    AddorGetInfo();
                }

            }

            else if (yesorno == "no")
            {

            }

            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static List<string> AddToList(string input, List<string> list)
        {
            list.Add(input);
            return list;

        }

        public static string AddorGetInfo()
        {
            Console.WriteLine("Would you like to add another student or find info about students\n(type:add or info)");
            string addOrInfoResponse = Console.ReadLine();
            return addOrInfoResponse;
        }

        public static void PrintStudentNumber(List<string> studentNames)
        {
            for (int i = 0; i < studentNames.Count; i++)
            {

                Console.WriteLine(i + 1 + " " + studentNames[i]);
            }

            
        }

        public static string AskUserForStudent(List<string> studentNames)
        {
            Console.WriteLine("Which student would you like to know more about? (enter corresponding number)");
            string userChoiceForStudent = Console.ReadLine();
            return userChoiceForStudent;
        }

        public static int ValidateUserChoice(string message, List<string> names)
        {
            string input = AskUserForStudent(names);
            int userChoice;
            if (int.TryParse(input, out userChoice) && (userChoice > 0 && userChoice <= names.Count))
            {
                return userChoice - 1;
            }

            else
            {
                return ValidateUserChoice("test", names);
            }
        }

        public static string GetStudentInfo(string userChoice)
        {
            Console.WriteLine("What info would you like to know about the student?\n(hometown, favorite food, favorite movie, or nothing)");
            string infoChosen = Console.ReadLine().ToLower();
            return infoChosen;
        }

        public static void DisplayInfo(int nameInput, List<string> names, List<string> hometown ,List<string> favoriteFood, List<string> movie)
        {
            bool askInfoLoop = true;

            while (askInfoLoop)
            {

                string moreInfo = GetStudentInfo("test");
                Console.WriteLine();

                switch (moreInfo)
                {
                    case "hometown":

                        Console.WriteLine("\n" + names[nameInput] + "'s hometown is " + hometown[nameInput]+"\n");
                        break;

                    case "favorite food":
                        Console.WriteLine("\n" + names[nameInput] + "'s favorite food is " + favoriteFood[nameInput]+"\n");
                        break;

                    case "favorite movie":
                        Console.WriteLine("\n" + names[nameInput] + "'s favorite movie is " + movie[nameInput]+"\n");
                        break;

                    case "nothing":
                        AskForOtherStudent();
                        break;

                    default:
                        Console.WriteLine("\nThat wasn't a valid option");
                        askInfoLoop = true;
                        break;
                        
                }

            }
        }

        public static void AskForOtherStudent()
        {

            List<string> studentNames = new List<string>
            {
                "Jake", "Jess", "Chris", "Paula", "Levi"

            };

            List<string> hometown = new List<string>
            {
                "Ortonville", "Ferndale", "Novi", "Livonia", "Levi"

            };

            List<string> favoriteFood = new List<string>
            {
                "Pizza", "Pasta", "Lobster", "Hamburger", "Burrito"

            };

            List<string> favoriteMovie = new List<string>
            {
                "Lord of the Rings", "The Lion King", "Star Wars", "Wall-E", "The Matrix"

            };



            Console.WriteLine("Would you like to look up another student? (yes or no)");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "yes")
            {
                PrintStudentNumber(studentNames);
                int validate = ValidateUserChoice("validate", studentNames);
                DisplayInfo(validate, studentNames, hometown, favoriteFood, favoriteMovie);
                AskForOtherStudent();

            }

            else if (userAnswer == "no")
            {
                Console.WriteLine("Have a good day");
                System.Environment.Exit(1);
            }

            else
            {
                Console.WriteLine("Invalid input");
                AskForOtherStudent();

            }

        }
       

    }
}
