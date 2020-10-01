using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Police : BaseClassPerson
    {
        //public List<string> SeizedGoods = new List<string>();

        // public List<string> SeizedGood { get; set; }

        public Police()
        {

        }

        public Police(int xpos, int ypos, List<string> seizedGoods, char name, int id, Direction direction) : base(xpos, ypos, seizedGoods, name, id, direction)
        {
            //NumberOfPolice = numberOfPolice;
        }


    }
}
