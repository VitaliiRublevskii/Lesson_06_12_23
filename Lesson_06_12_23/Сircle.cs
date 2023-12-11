

using System.Runtime.ConstrainedExecution;

namespace Lesson_06_12_23
{
    internal class Сircle : Figur
    {
        public double Radius { get; set; }

        public Сircle () : base() { }
        public Сircle (string name, float radius) : base()
        {
            this.NameFigur = name;
            this.Radius = radius;
            this.Area = 3.14 * radius * radius;
        }

        public override double Perimetr()
        {
            return 3.14 * this.Radius * this.Radius;
        }

        public override double AreaFigur()
        {
            
            return 3.14 * this.Radius * this.Radius;
        }

    }
}
