using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    internal class Triangle : Geometry
    {
        public Triangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public string CalculateArea(double height, double width)
        {
            return $"A área do {this.GetType().ToString().Split('.')[1]} é: {(height * width/2).ToString("F2")}";
        }
    }
}
