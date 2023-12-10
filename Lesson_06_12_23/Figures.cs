using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_12_23
{
    internal class Figures : Figur
    {
        public Figur[] SetFigurs { get; set; }
        public int CountFigurs {  set; get; }


        public Figures () { }
        public Figures (int Count)
        {
            this.CountFigurs = Count;
            SetFigurs = new Figur[this.CountFigurs]; 
        }


        public override void AddFigurs(Figur figur)
        {
            Figur[] newFigur = new Figur[this.CountFigurs + 1];
            for (int i = 0; i < CountFigurs; i++)
            {
                if (CountFigurs == 0) { SetFigurs[0] = figur; }
                else
                {
                    newFigur[i] = SetFigurs[i];
                }
            }
            SetFigurs[CountFigurs] = figur;
            SetFigurs = newFigur;
            CountFigurs++;





        }

        public void PrintFigurS ()
        {
            for (int i = 0; i < CountFigurs; i++)
            {
                SetFigurs[i].PrintFigur();
            }
        }

    }
}
