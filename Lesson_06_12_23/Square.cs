

namespace Lesson_06_12_23
{
    internal class Square : Figur
    {


        public Square() : base() { }
        public Square(string Name, int countSize, float SideSize) : base()
        {
            this.NameFigur = Name;
            this.CountSide = countSize;
            this.SideSize = SideSize;
            this.Perim = this.SideSize * this.CountSide;
            this.Area = this.SideSize * this.SideSize;
        }

    }
    


  



}
