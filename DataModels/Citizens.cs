using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Citizens : BaseClassPerson
    {
        //public List<string> Belongings = new List<string>();

        //public List<string> Belonging { get; set; }

        public Citizens()
        {

        }
        public Citizens(int xpos, int ypos, List<string> belongings, char name, int id, Direction direction) : base(xpos, ypos, belongings, name, id, direction)
        {
            //NumberOfCitizens = numberOfCitizens;
        }

    }

}
