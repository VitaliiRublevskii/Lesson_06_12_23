using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_06_12_23
{
    internal class Figur
    {
        public string NameFigur {  get; set; }
        public int CountSide { get; set; }
        public float SideSize {  get; set; }
        
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public double Area { get; set; }

        public float Perim {  get; set; }

        public Figur() 
        {
            this.NameFigur = "";
            this.CountSide = 0;
            this.SideSize = 0;
            this.CoordX = 0;
            this.CoordY = 0;
            this.Area = 0;
            this.Perim = 0;

        }
        public Figur(string NameFigur, int CountSide, float SideSize, int coordX, int coordY)
        {
            this.NameFigur = NameFigur;
            this.CountSide = CountSide;
            this.SideSize = SideSize;
            this.CoordX = coordX;
            this.CoordY = coordY;

        }

        public void PrintFigur()
        {
            Console.WriteLine($" Фигура {NameFigur} имеет {CountSide} сторон, периметр {Perim} и площадь {Area} ");
            
        }


        public void ComparisonFigur (Figur figur1, Figur figur2)
        {
            if (figur1.CoordX == figur2.CoordX && figur1.CoordY == figur2.CoordY)
            {
                Console.WriteLine("Фигуры находятся в одной точке");
            }
            else { Console.WriteLine("Фигуры не находятся в одной точке"); }

            if (figur1.Area > figur2.Area) { Console.WriteLine("Первая фигура большей площади"); }
            else if (figur1.Area < figur2.Area) { Console.WriteLine("Вторая фигура большей площади"); }
            else { Console.WriteLine("Фигуры равной площади"); }
        }

        public virtual void AddFigurs(Figur figur) { }


    }
}
