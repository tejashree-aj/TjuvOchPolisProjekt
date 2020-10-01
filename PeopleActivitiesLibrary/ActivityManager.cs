using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PeopleActivitiesLibrary
{
    public static class ActivityManager
    {
        static int maximumLenghtX = 100;
        static int maximumLenghtY = 25;
        static int maximumDirection = 8;

        private static List<BaseClassPerson> Persons = new List<BaseClassPerson>();
        private static List<BaseClassPerson> ThievesCaught = new List<BaseClassPerson>();


        public static void InputNumberOFCharacters()
        {
            Console.Write("Lets play a fun game of Thief aad Police.\n Enter number of Citizens: ");
            int citizen = int.Parse(Console.ReadLine());
            AddCitizens(citizen);
            Console.Write("Enter number of Police: ");
            int police = int.Parse(Console.ReadLine());
            AddPolice(police);
            Console.Write("Enter number of Thieves: ");
            int thieves = int.Parse(Console.ReadLine());
            AddThief(thieves);
            Console.Clear();
        }

        private static List<string> GetDefaultInventory() //Inventory list for all C, T, P
        {
            List<string> inventories = new List<string>();
            inventories.Add("Mobile");
            inventories.Add("Money");
            inventories.Add("Clock");
            inventories.Add("Key");

            return inventories;
        }

        private static void AddCitizens(int citizenCount)
        {
            for (int i = 0; i < citizenCount; i++)
            {
                Citizens c = new Citizens();
                c.Name = 'C';
                c.ID = i + 1;
                c.XPos = maximumLenghtX.GetRandomNumber();
                c.YPos = maximumLenghtY.GetRandomNumber();
                c.Direction = (Direction)maximumDirection.GetRandomNumber();
                c.Inventory = GetDefaultInventory();
                Persons.Add(c);
            }
        }

        private static void AddPolice(int policeCount)
        {
            for (int i = 0; i < policeCount; i++)
            {
                Police p = new Police();
                p.Name = 'P';
                p.ID = i + 1;
                p.XPos = maximumLenghtX.GetRandomNumber();
                p.YPos = maximumLenghtY.GetRandomNumber();
                p.Direction = (Direction)maximumDirection.GetRandomNumber();
                p.Inventory = new List<string>();
                Persons.Add(p);
            }
        }

        private static void AddThief(int thiefCount)
        {
            for (int i = 0; i < thiefCount; i++)
            {
                Thief t = new Thief();
                t.Name = 'T';
                t.ID = i + 1;
                t.XPos = maximumLenghtX.GetRandomNumber();
                t.YPos = maximumLenghtY.GetRandomNumber();
                t.Direction = (Direction)maximumDirection.GetRandomNumber();
                t.Inventory = new List<string>();
                Persons.Add(t);
            }
        }


        public static void GiveDirectinToPerson() //Movement in 8 directions for C, T, P
        {
            while (true)
            {
                foreach (BaseClassPerson character in Persons)
                {
                    if (character.Name != 'T' || !ThievesCaught.Any(x => x.ID == character.ID && x.Name == x.Name))
                    {
                        PrintPosition(character.XPos, character.YPos, ' ');

                        switch (character.Direction)
                        {
                            case Direction.Right:
                                if (character.XPos == maximumLenghtX)
                                {
                                    character.XPos = 0;
                                }
                                else { character.XPos++; }
                                break;

                            case Direction.Left:
                                if (character.XPos == 0)
                                {
                                    character.XPos = maximumLenghtX;
                                }
                                else { character.XPos--; }
                                break;

                            case Direction.Up:
                                if (character.YPos == 0)
                                {
                                    character.YPos = maximumLenghtY;
                                }
                                else { character.YPos--; }
                                break;

                            case Direction.Down:
                                if (character.YPos == maximumLenghtY)
                                {
                                    character.YPos = 0;
                                }
                                else { character.YPos++; }
                                break;

                            case Direction.RightBottom:
                                if (character.XPos == maximumLenghtX || character.YPos == maximumLenghtY)
                                {
                                    if (character.XPos == maximumLenghtX)
                                    {
                                        character.XPos = 0;
                                    }
                                    else { character.YPos = 0; }
                                }
                                else
                                {
                                    character.XPos++;
                                    character.YPos++;
                                }
                                break;

                            case Direction.RightTop:
                                if (character.XPos == maximumLenghtX || character.YPos == 0)
                                {
                                    if (character.XPos == maximumLenghtX)
                                    {
                                        character.XPos = 0;
                                    }
                                    else { character.YPos = maximumLenghtY; }
                                }
                                else
                                {
                                    character.XPos++;
                                    character.YPos--;
                                }
                                break;

                            case Direction.LeftBottom:
                                if (character.XPos == 0 || character.YPos == maximumLenghtY)
                                {
                                    if (character.XPos == 0)
                                    {
                                        character.XPos = maximumLenghtX;
                                    }
                                    else { character.YPos = 0; }
                                }
                                else
                                {
                                    character.XPos--;
                                    character.YPos++;
                                }
                                break;

                            case Direction.LeftTop:
                                if (character.XPos == 0 || character.YPos == 0)
                                {
                                    if (character.XPos == 0)
                                    {
                                        character.XPos = maximumLenghtX;
                                    }
                                    else { character.YPos = maximumLenghtY; }
                                }
                                else
                                {
                                    character.XPos--;
                                    character.YPos--;
                                }
                                break;
                            default:
                                break;
                        }

                        PrintPosition(character.XPos, character.YPos, character.Name);

                        ActionOnPersonMeeting(character);
                    }
                    else
                    {

                    }
                }

                Thread.Sleep(1500);

            }

        }
        private static void PrintPosition(int x, int y, char name) 
        {

            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = (name) switch
            {
                'P' => ConsoleColor.Blue,
                'C' => ConsoleColor.White,
                'T' => ConsoleColor.Red,
                _ => ConsoleColor.Black
            };
            Console.WriteLine(name);
        }

        private static void PrintMessage(int x, int y, string message) //Method to print a message
        {

            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        /// <summary>
        /// inventory transfer - actions to be performed on meeting person.
        /// </summary>
        /// <param name="movingPerson"></param>
        private static void ActionOnPersonMeeting(BaseClassPerson movingPerson) 
        {
            IEnumerable<BaseClassPerson> people = from p in Persons
                                                  where p.XPos == movingPerson.XPos && p.YPos == movingPerson.YPos && p.Name != movingPerson.Name
                                                  select p;

            if (people != null && people.Count() > 0)
            {
                var newCharacter = people.First();

                if (newCharacter.Name == 'C')
                {
                    switch (movingPerson.Name)
                    {
                        case 'T':
                            InventoryMovement(newCharacter, movingPerson);

                                int ctz  = (from c in Persons
                                            where c.Name == 'C' && c.Inventory.Count == 0
                                            select c).Count();

                            PrintMessage(0, 29, $"Total number of citizens robbed: {ctz}");
                            break;
                        // invetory of c to t                               

                        case 'P':
                        //nothing

                        default:
                            break;
                    }
                }

                if (newCharacter.Name == 'P')
                {
                    switch (movingPerson.Name)
                    {
                        case 'T':
                            InventoryMovement(movingPerson, newCharacter);
                            //from t to p
                            ThievesCaught.Add(movingPerson);
                            PrintMessage(0, 28, $"Total number of thieves arrested: {ThievesCaught.Count}");
                            //Persons.Remove(movingPerson);
                            break;

                        case 'C':
                        //nothing

                        default:
                            break;
                    }
                }

                if (newCharacter.Name == 'T')
                {
                    switch (movingPerson.Name)
                    {
                        case 'C':
                            InventoryMovement(movingPerson, newCharacter);
                            //inventory of c to t
                            break;

                        case 'P':
                            InventoryMovement(newCharacter, movingPerson);
                            //inventory of t to p
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private static void InventoryMovement(BaseClassPerson fromPerson, BaseClassPerson toPerson)
        {
            if (fromPerson.Inventory != null && fromPerson.Inventory.Count > 0)
            {
                toPerson.Inventory = fromPerson.Inventory.ToList();
                fromPerson.Inventory.Clear();

                if (fromPerson.Name == 'C' && toPerson.Name == 'T')
                {
                    PrintMessage(0, 27, "Good stolen from citizen by thief");
                }
                if (fromPerson.Name is 'T' && toPerson.Name is 'P')
                {
                    PrintMessage(0, 27, "Thief cought by police and goods siezed.");
                }

                Thread.Sleep(1000);
                PrintMessage(0, 27, new string(' ', 100));
            }
        }

    }
}
