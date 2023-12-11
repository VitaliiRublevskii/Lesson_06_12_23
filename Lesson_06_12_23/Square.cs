

namespace Lesson_06_12_23
{
    internal class Square : Figur
    {
        public int CountSide { get; set; }  
        public float Size { get; set; }

        public Square() : base() { }
        public Square(string Name, float Size) : base()
        {
            this.NameFigur = Name;
            this.CountSide = 4;
            this.Size = Size;
            this.Perim = this.Size * this.CountSide;
            this.Area = this.Size * this.Size;
        }

    }
    //   ????????????  ТОЛЬКО в этом классе!!!!
    public override double Perimetr()
    {
        return this.CountSide * this.Size;
    }

    public override double AreaFigur()
    {

        return this.Size * this.Size;
    }





}
