using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    internal abstract class Geometry
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public string CalculateArea()
        {
            return $"A área do {this.GetType().ToString().Split('.')[1]} é: {(Height * Width).ToString("F2")}";
        }
    }
}
