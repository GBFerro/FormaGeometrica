using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    internal class Rectangle : Geometry
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public string ToString()
        {
            return this.Width + " " + this.Height;
        }

        /*
        public string CalculateArea(double height, double width)
        {
            return $"A área do {this.GetType().ToString().Split('.')[1]} é: {(height* width).ToString("F2")}";
        } 
        */
    }
}
