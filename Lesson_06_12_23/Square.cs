using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_12_23
{
    internal class Square : Figur
    {
        public  float SideSq {  get; set; }

        public Square() : base() { }

        public Square(string Name, float SideSq) : base()
        {
            this.NameFigur = Name;
            this.SideSq = SideSq;
            this.Perim = this.SideSq * 4;
            this.Area = this.SideSq * this.SideSq;
        }

        public override double Perimetr()
        {
            return this.SideSq * 4;
        }

        public override double AreaFigur()
        {
            return this.SideSq * this.SideSq;
        }

    }
}
