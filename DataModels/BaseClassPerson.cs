using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        LeftTop,
        LeftBottom,
        RightTop,
        RightBottom
    }

    public class BaseClassPerson
    {
        public int XPos { get; set; }
        public Direction Direction { get; set; }
        public int YPos { get; set; }
        public List<string> Inventory { get; set; }
        public char Name { get; set; }

        public int ID { get; set; }
        public BaseClassPerson()
        {
        }
        public BaseClassPerson(int xPos, int yPos, List<string> inventory, char name, int id, Direction direction)
        {
            XPos = xPos;
            YPos = yPos;
            Inventory = inventory;
            Name = name;
            ID = id;
            Direction = direction;
        }
    }

}
