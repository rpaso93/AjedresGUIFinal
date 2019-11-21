using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ajedrezForm
{
    class Peon : Piezas
    {
        public Peon(string color)
            :base(color)
        {
            retornarPiezaColor(color);

        }

        public Bitmap retornarPiezaColor(String color)
        {
            if (color == "B")
            {
                return this.Img = Properties.Resources.PeonB;
            }
            else
            {
                return this.Img = Properties.Resources.PeonN;

            }
        }

        public override List<Point> Movimientos(Point pos)
        {
            List<Point> lp = new List<Point>();
            Point p;
            if(Color == "B")
            {
                if(pos.X < 7)
                {
                    p = new Point(pos.X + 1, pos.Y);
                    lp.Add(p);
                }                
                if(pos.X == 1)
                {
                    p = new Point(pos.X + 2, pos.Y);
                    lp.Add(p);
                }
                if(pos.Y > 0 && pos.X < 7)
                {
                    p = new Point(pos.X + 1, pos.Y - 1);
                    lp.Add(p);
                }
                if (pos.Y < 7 && pos.X < 7)
                {
                    p = new Point(pos.X + 1, pos.Y + 1);
                    lp.Add(p);
                }
            }
            else if (Color == "N")
            {
                if (pos.X < 8)
                {
                    p = new Point(pos.X - 1, pos.Y);
                    lp.Add(p);
                }
                if (pos.X == 6)
                {
                    p = new Point(pos.X - 2, pos.Y);
                    lp.Add(p);
                }
                if (pos.Y > 0)
                {
                    p = new Point(pos.X - 1, pos.Y - 1);
                    lp.Add(p);
                }
                if (pos.Y < 7)
                {
                    p = new Point(pos.X - 1, pos.Y + 1);
                    lp.Add(p);
                }
            }
            return lp;
        }

        public void mover(int posicionX, int posicionY)
        {

        }

        public void pisicionInicial()
        {

        }
    }
}
