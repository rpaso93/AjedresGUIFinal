using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ajedrezForm
{
    class Reina : Piezas
    {
        public Reina(string color)
            : base(color)
        {
            retornarPiezaColor(color);

        }
        public Bitmap retornarPiezaColor(String color)
        {
            if (color == "B")
            {
                return this.Img = Properties.Resources.ReinaB;
            }
            else
            {
                return this.Img = Properties.Resources.ReinaN;

            }
        }

        public override List<Point> Movimientos(Point pos)
        {
            List<Point> lp = new List<Point>();
            Point p;
            for (int c = pos.Y; c < 8; c++)/// Posiciones mas a la derecha sobre misma fila
            {
                p = new Point(pos.X, c);
                if (p != pos)
                    lp.Add(p);
            }
            for (int c = pos.Y; c >= 0; c--)/// Posiciones mas a la izquierda sobre misma fila
            {
                p = new Point(pos.X, c);
                if (p != pos)
                    lp.Add(p);
            }
            for (int f = pos.X; f < 8; f++)/// Posiciones mas abajo sobre misma columna
            {
                p = new Point(f, pos.Y);
                if (p != pos)
                    lp.Add(p);
            }
            for (int f = pos.X; f >= 0; f--)/// Posiciones mas arriba sobre misma columna
            {
                p = new Point(f, pos.Y);
                if (p != pos)
                    lp.Add(p);
            }
            p = pos;
            while (p.X > 0 && p.Y < 7)  //Hacia la esquina superior derecha
            {
                p.X--; p.Y++;
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
