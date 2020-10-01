using PeopleActivitiesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TjuvOchPolisProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivityManager.InputNumberOFCharacters();
            ActivityManager.GiveDirectinToPerson();

            Console.ReadLine();
        }
    }
        
}