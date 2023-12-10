

namespace Lesson_06_12_23
{
    internal class Triangle : Figur
    {
        public float SideA {  get; set; }
        public float SideB { get; set; }
        public float SideC { get; set; }
        
        public Triangle(): base() { }

        public Triangle(string Name, int countSize, float sideA, float sideB, float sideC) : base()
        {
            this.NameFigur = Name;
            this.CountSide = countSize;
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.Perim = this.SideA + this.SideB + this.SideC;
            this.Area = (((this.Perim) / 2) * (this.Perim / 2 - this.SideA) * (this.Perim / 2 - this.SideB) * (this.Perim / 2 - this.SideC));
        }

     
    }
}
