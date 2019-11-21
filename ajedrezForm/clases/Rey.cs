using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ajedrezForm
{
    class Rey : Piezas
    {
        public Rey(string color)
            : base( color)
        {
            retornarPiezaColor(color);
        }

        public Bitmap retornarPiezaColor(String color)
        {
            if (color == "B")
            {
                return this.Img = Properties.Resources.ReyB;
            }
            else
            {
                return this.Img = Properties.Resources.ReyN;

            }

        }

        public override List<Point> Movimientos(Point pos)
        {
            List<Point> lp = new List<Point>();
            Point p;
            if (pos.X > 0)              //ARRIBA
            {
                p = new Point(pos.X - 1, pos.Y);
                lp.Add(p);
            }
            if(pos.X > 0 && pos.Y < 7)  //ARRIBA DERECHA
            {
                p = new Point(pos.X - 1, pos.Y + 1);
                lp.Add(p);
            }
            if (pos.X > 0 && pos.Y > 0) //ARRIBA IZQUIERDA
            {
                p = new Point(pos.X - 1, pos.Y - 1);
                lp.Add(p);
            }
            if (pos.Y < 7) //DERECHA
            {
                p = new Point(pos.X, pos.Y + 1);
                lp.Add(p);
            }
            if (pos.Y > 0) //IZQUIERDA
            {
                p = new Point(pos.X, pos.Y - 1);
                lp.Add(p);
            }
            if (pos.X < 7 && pos.Y > 0) //ABAJO IZQUIERDA
            {
                p = new Point(pos.X + 1, pos.Y - 1);
                lp.Add(p);
            }
            if (pos.X < 7 && pos.Y < 7) //ABAJO DERECHA
            {
                p = new Point(pos.X + 1, pos.Y + 1);
                lp.Add(p);
            }
            if (pos.X < 7)              //ARRIBA
            {
                p = new Point(pos.X + 1, pos.Y);
                lp.Add(p);
            }
            return lp;
        }
    }
}
