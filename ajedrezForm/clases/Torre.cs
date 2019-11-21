using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ajedrezForm.clases;


namespace ajedrezForm
{
    class Torre  : Piezas
    {
        public Torre(string color)
            :base(color)
        {
            retornarPiezaColor(color);
            this.Nombre = this.GetType().Name;
        }

        public Bitmap retornarPiezaColor(String color)
        {
            if (color == "B")
            {
                return this.Img = Properties.Resources.TorreB;
            }
            else
            {
                return this.Img = Properties.Resources.TorreN;
            }
        }


        public override List<Point> Movimientos(Point pos)
        {
            List<Point> lp = new List<Point>();
            Point p;
            for (int c = pos.Y; c < 8; c++)/// Posiciones mas a la derecha sobre misma fila
            {
                p = new Point(pos.X,c);
                if(p != pos)
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
            return lp;
        }
    }
}
