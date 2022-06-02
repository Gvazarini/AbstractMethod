using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities
{
     abstract class Shapes
    {
        public Color Color { get; set; }
       
        public Shapes(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
