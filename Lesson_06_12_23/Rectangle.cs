using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_12_23
{
    internal class Rectangle : Figur
    {
        public float SideA {  get; set; }
        public float SideB { get; set; }

        public Rectangle() : base() { }

        public Rectangle(string Name, float SideA, float SideB) : base()
        {
            this.NameFigur = Name;
            this.SideA = SideA;
            this.SideB = SideB;
            this.Perim = this.SideA * 2 + this.SideB * 2;
            this.Area = this.SideA * this.SideB;
        }

        public override double Perimetr()
        {
            return this.SideA * 2 + this.SideB * 2;
        }

        public override double AreaFigur()
        {
            return this.SideA * this.SideB;
        }
    }
}
