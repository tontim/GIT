/* 

Valde att göra en liknande meny jag lärde mig göra under testveckorna. 
Uppgift 1: 
I programmet behövs bara min class jag valt namnge "Program" som innehåller funktionerna.

Upggift 2:

Metoderna jag valde att använda är:

myMenu för att visa en simpel meny via true/false statements efter varje metod körs,
addPerson för att lägga till personer med hjälp av register-arrayen
showRegister för att skriva ut personer som lagts till i arrayen. 

Programmet är framtidssäkrat till 100 personer pga begränsningen i hur arrayer fungerar, 
har inte lärt mig använda List<string> för dynamiska arrayer än. :)

 */

namespace GIT
{
    internal class Program
    {
        private static string[] register = new string[100];
        private static int registerCount = 0;
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = myMenu();
            }
        }
            static bool myMenu()
            {
                Console.WriteLine("Skriv nummer för att välja:");
                Console.WriteLine("[1] - Lägg till person i register.");
                Console.WriteLine("[2] - Printa register.");
                Console.WriteLine("[3] - Avsluta.");
                string choice = Console.ReadLine();

            if (choice == "1")
            {
                    addPerson();
                return true;
            }
            
            else if (choice  == "2")
            {
                showRegister();
                return true;
            }
            else if (choice == "3")
            {
                Console.WriteLine("Hejdå!");
                return false;
            }
            else
            {
                return true;
            }

            static void addPerson()
            {
                if (registerCount < register.Length)
                {
                    Console.WriteLine("Ange namn:");
                    string name = Console.ReadLine();
                    
                    Console.WriteLine("Ange lön:");
                    string salary = Console.ReadLine();

                    register[registerCount] = $"{name}, Lön: {salary}";
                    registerCount++;
                }
                else
                {
                    Console.WriteLine("Full lista!");
                }
                
            }

            static void showRegister()
            {
                for (int i = 0; i < registerCount; i++)
                {
                    Console.WriteLine(register[i]);
                }
                
            }


        }
    }
}
