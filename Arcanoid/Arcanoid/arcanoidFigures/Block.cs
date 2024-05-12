using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid.arcanoidFigures
{
    internal class Block(double positionX, double positionY, double height, double width)
    {
        public bool isBroken {  get; set; }

        public Brush blockColor { get; set; } = Brushes.White;
    }
}
