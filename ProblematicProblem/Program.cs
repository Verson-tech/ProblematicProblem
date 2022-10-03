using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;


namespace ProblematicProblem
{
    class Program 
    {
        static bool cont = true;       
        //static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static List<string> activities = new List<string>() { "Wine Tasting" };
        static void Main(string[] args)
        {
            Random rng = new Random();
                bool cont = false;
                do
                {
                    Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            
                    var contREsponse = Console.ReadLine().ToLower();           
                    //{
                    if (contREsponse == "yes")
                    {
                        cont = true;
                    }
                    else if (contREsponse == "no")
                    {
                        Console.WriteLine("\n\nExcellent! Feel free to come back , when you change your mind.");
                        cont = false;
                   //Environment.Exit(0);
                    }
                    //else
                    //{
                    //    cont = false;
                    //}

                } while(cont == false);
                    //Console.WriteLine();
                    Console.Write("We are going to need your information first! What is your name? ");
                    string userName = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("What is your age? ");
                    int userAge = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
          
                Methods.chooseActivity();
            //public static void chooseActivity()
            //    {   
            //        bool seeList = Console.ReadLine().ToLower() == "sure" ? true : false;
            //            if (seeList)
            //            {
            //                foreach (string activity in activities)
            //                {
            //                    Console.Write($"{activity} ");
            //                    Thread.Sleep(250);
            //                }
            //                Console.WriteLine();
            //                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            //                bool addToList = (Console.ReadLine().ToLower() == "yes" ? true : false);
            //                //bool addToList = bool.Parse(Console.ReadLine());
            //                Console.WriteLine();
            //                while (addToList)
            //                {
            //                    Console.Write("What would you like to add? ");
            //                    string userAddition = Console.ReadLine();
            //                    activities.Add(userAddition);
            //                    foreach (string activity in activities)
            //                    {
            //                        Console.Write($"{activity} ");
            //                        Thread.Sleep(250);
            //                    }
            //                    Console.WriteLine();
            //                    Console.WriteLine("Would you like to add more? yes/no: ");
            //                    addToList = Console.ReadLine().ToLower() == "yes" ? true : false;

                //                }
                //            }
                //            else if(!seeList){
                //                Console.WriteLine("\n\nExcellent! Feel free to come back , when you change your mind.");
                //                cont = false;
                //            }
                //    }
                while (cont)
                    {
                        Console.Write("Connecting to the database");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(100);
                        }
                        Console.WriteLine();
                        Console.Write("Choosing your random activity");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(100);
                        }
                        Console.WriteLine();
                        int randomNumber = rng.Next(activities.Count);
                        string randomActivity = activities[randomNumber];
                        if (userAge < 21 && randomActivity == "Wine Tasting")
                        {
                             Console.WriteLine($"Oh no! Looks like you are too young to do the {randomActivity}.");
                             Console.WriteLine("Pick something else!");                  
                        activities.Remove(randomActivity);                  
                        randomNumber = rng.Next(activities.Count);
                        randomActivity = activities[randomNumber];
                         Console.WriteLine($"{randomActivity}");
                        }
                        Console.Write($"Ah, got it! {userName}, your random activity is {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                        var respInput = Console.ReadLine().ToLower();
                    //Console.WriteLine();
                    //cont = Console.ReadLine().ToLower() == "redo" ? true :  false;
                    if (respInput == "redo")
                    {                 
                        cont = true;
                    }
                    else
                    {
                        Console.WriteLine($"Excellent, {userName}!!! Enjoy your {randomActivity}!!! ");
                        cont = false;
                    }
                }
           // } while (cont);
        }
    }
}