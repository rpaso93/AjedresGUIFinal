using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajedrezForm
{
    
    class Caballo : Piezas
    {
       

        public Caballo(string color)
            :base (color)
         {
            retornarPiezaColor(color);
         }


        public Bitmap retornarPiezaColor(String color)
        {
            if(color == "B")
            {
                return this.Img = Properties.Resources.CaballoB;
            }
            else
            {
                return this.Img = Properties.Resources.CaballoN;

            }
        }

        public override List<Point> Movimientos(Point pos)
        {
            List<Point> lp = new List<Point>();
            Point p = new Point(pos.X - 2, pos.Y + 1);
            if (p.X < 8 && p.X >= 0 && p.Y < 8 && p.Y >= 0)
                lp.Add(p);
            p = new Point(pos.X - 2, pos.Y - 1);
            if (p.X < 8 && p.X >= 0 && p.Y < 8 && p.Y >= 0)
                lp.Add(p);
            p = new Point(pos.X + 2, pos.Y + 1);
            if (p.X < 8 && p.X >= 0 && p.Y < 8 && p.Y >= 0)
                lp.Add(p);
            p = new Point(pos.X + 2, pos.Y - 1);
            if (p.X < 8 && p.X >= 0 && p.Y < 8 && p.Y >= 0)
                lp.Add(p);
            p = new Point(pos.X + 1, pos.Y + 2);
            if (p.X < 8 && p.X >= 0 && p.Y < 8 && p.Y >= 0)
                lp.Add(p);
            p = new Point(pos.X - 1, pos.Y + 2);
            if (p.X < 8 && p.X >= 0 && p.Y < 8 && p.Y >= 0)
                lp.Add(p);
            p = new Point(pos.X + 1, pos.Y - 2);
            if (p.X < 8 && p.X >= 0 && p.Y < 8 && p.Y >= 0)
                lp.Add(p);
            p = new Point(pos.X - 1, pos.Y - 2);
            if (p.X < 8 && p.X >= 0 && p.Y < 8 && p.Y >= 0)
                lp.Add(p);
            return lp;
        }        
    }
}
