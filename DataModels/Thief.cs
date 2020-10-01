using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
     public class Thief : BaseClassPerson
    {
        //List<string> StolenGoods = new List<string>();

        //public List<string> StolenGood { get; set; }

        public Thief()
        {

        }
        public Thief (int xpos, int ypos, List<string> stolenGoods, char name, int id, Direction direction) : base(xpos, ypos, stolenGoods, name, id, direction)
        {
            //NumberOfThieves = numberOfThieves;
        }

    }
}
