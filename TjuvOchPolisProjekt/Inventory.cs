using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvOchPolisProjekt
{
    class Inventory
    {

        public List<string> Items { get; set; }

        public Inventory(List<string> items)
        {
            Items = items;

        }
    }
}
