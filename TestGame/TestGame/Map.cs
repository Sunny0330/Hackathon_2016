using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    public class Map
    {
        private Tiles[,] _titles;

        public Map()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    _titles[i, j] = new Tiles();
                }
            }
        }
    }
}
