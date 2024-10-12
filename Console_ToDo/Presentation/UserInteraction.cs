using Console_ToDo.BusinessLogic;
using System;
namespace Console_ToDo.Presentation
{
    internal class UserInteraction
    {
        private static UserInteraction instance;

        private static Controller conInstance;
        private UserInteraction()
        {
           conInstance = Controller.GetInstance();
        }


        private int InitPrompt()
        {
            Console.WriteLine("Welcome to ToDo list\n\n");
            int choice = -1;

            while (true)
            {

                Console.WriteLine("Enter a choice...\n");
                Console.WriteLine("1. Register User");
                Console.WriteLine("2. Create a Task");
                Console.WriteLine("3. Update an Existing Task");
                Console.WriteLine("4. Show all Tasks");
                Console.WriteLine("5. Delete a Task\n\n");
                //Console.WriteLine("5. Exit\n\n");

                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine($"{ex.Message}");
                    continue;
                }
                if (choice >= 1 && choice <= 5)
                    break;
                    //return choice;
                else
                {
                    Console.WriteLine("Please Enter a value from 1-5");
                    continue;
                }
            }

            return choice;
        }


        private static void UserRegPrompt()
        {
            Console.WriteLine("Enter Your Name");


            string name = Console.ReadLine();



            // check if user exists already
            // save user

            conInstance.RegisterUser(name);

        }
        public static UserInteraction GetInstance()
        {
            if (instance == null)
            {
                return new UserInteraction();
            }
            else
            {
                return instance;
            }
        }

        public void Start()
        {
            int choice = InitPrompt();

            switch (choice) {

                case 1:
                    //Create User
                    UserRegPrompt();
                    break;
                case 2:
                    //Create Data

                    break;
                case 3:
                    //Update Data
                case 4:
                    //Show Data
                case 5:
                    //Delete Data
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

                
            }
        }



    }
}
