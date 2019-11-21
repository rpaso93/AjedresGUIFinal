using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ajedrezForm
{
    class Alfil : Piezas
    {
        public Alfil(string color)
            :base(color)
        {
            retornarPiezaColor(color);
        }

        public Bitmap retornarPiezaColor(String color)
        {
            if (color == "B")
                return this.Img = Properties.Resources.AlfilB;
            else
                return this.Img = Properties.Resources.AlfilN;
        }

        public override List<Point> Movimientos(Point pos)
        {
            List<Point> lp = new List<Point>();
            Point p = pos;
            while(p.X > 0 && p.Y < 7)  //Hacia la esquina superior derecha
            {
                p.X--;p.Y++;
                lp.Add(p);
            }
            p = pos;
            while (p.X < 7 && p.Y < 7)  //Hacia la esquina inferior derecha
            {
                p.X++; p.Y++;
                lp.Add(p);
            }
            p = pos;
            while (p.X < 7 && p.Y > 0)  //Hacia la esquina inferior izquierda
            {
                p.X++; p.Y--;
                lp.Add(p);
            }
            p = pos;
            while (p.X > 0 && p.Y > 0)  //Hacia la esquina superior izquierda
            {
                p.X--; p.Y--;
                lp.Add(p);
            }
            return lp;
        }
      

    }
}
