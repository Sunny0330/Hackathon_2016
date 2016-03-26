using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestGame
{
    public class Tiles
    {
        // fields
        private bool _avalable;
        private List<Item> _entity;

        public Tiles()
        {
            _avalable = true;
            _entity = new List<Item>();
        }


        public bool Avalable
        {
            get { return _avalable; }
            set { _avalable = value; }
        }
    }
}
