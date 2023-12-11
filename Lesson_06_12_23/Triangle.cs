

namespace Lesson_06_12_23
{
    internal class Triangle : Figur
    {
        public float SideA {  get; set; }
        public float SideB { get; set; }
        public float SideC { get; set; }
        
        public Triangle(): base() { }

        public Triangle(string Name, float sideA, float sideB, float sideC) : base()
        {
            this.NameFigur = Name;
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.Perim = this.SideA + this.SideB + this.SideC;
            this.Area = (((this.Perim) / 2) * (this.Perim / 2 - this.SideA) * (this.Perim / 2 - this.SideB) * (this.Perim / 2 - this.SideC));
        }
        
        public override double Perimetr()
        {
            return this.SideA + this.SideB + this.SideC;
        }

        public override double AreaFigur()
        {
            double p = this.Perimetr();
            return ((p / 2) * (p / 2 - this.SideA) * (p / 2 - this.SideB) * (p / 2 - this.SideC));
        }

    }
}
