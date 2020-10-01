using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleActivitiesLibrary
{
    static class ExtensionHelper
    {
        public static int GetRandomNumber(this int maximumLimit)
        {
            Random random = new Random();
            return random.Next(0, maximumLimit);
        }
    }
}
