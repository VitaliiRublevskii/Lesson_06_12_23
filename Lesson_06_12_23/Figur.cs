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
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public double Area { get; set; }
        public double Perim {  get; set; }

        public Figur() 
        {
            this.NameFigur = "";
            this.CoordX = 0;
            this.CoordY = 0;
            this.Area = 0;
            this.Perim = 0;

        }
        public Figur(string NameFigur, int coordX, int coordY)
        {
            this.NameFigur = NameFigur;
            this.CoordX = coordX;
            this.CoordY = coordY;

        }

        public void PrintFigur()
        {
            Console.WriteLine($" Фигура {NameFigur} имеет координаты х = {CoordX} y = {CoordY} периметр {Perim} и площадь {Area} ");
            
        }
         public virtual double Perimetr() {
            return 0;
        }

        public virtual double AreaFigur()
        {
            return 0;
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

        public virtual void PrintFigurS() { }


    }
}
