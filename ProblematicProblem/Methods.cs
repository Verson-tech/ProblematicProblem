using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace ProblematicProblem
{
    public class Methods
   {
       public static void chooseActivity(IEnumerable<string> activities)
        {
            bool seeList = Console.ReadLine().ToLower() == "sure" ? true : false;
            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList = (Console.ReadLine().ToLower() == "yes" ? true : false);
                //bool addToList = bool.Parse(Console.ReadLine());
                Console.WriteLine();
                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    addToList = Console.ReadLine().ToLower() == "yes" ? true : false;

                }
            }
            else if (!seeList)
            {
                Console.WriteLine("\n\nExcellent! Feel free to come back , when you change your mind.");
                bool cont = false;
            }
        }

        internal static void chooseActivity()
        {
            throw new NotImplementedException();
        }
    }
}
