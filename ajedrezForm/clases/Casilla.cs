using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajedrezForm.clases
{
    public class Casilla : Button
    {
        Piezas pieza;
        Point pos = new Point();
        Color clr;

        public Piezas Pieza
        {
            get
            {
                return pieza;
            }

            set
            {
                pieza = value;
            }
        }

        public Color Clr
        {
            get
            {
                return clr;
            }

            set
            {
                clr = value;
            }
        }

        public Point Pos
        {
            get
            {
                return pos;
            }

            set
            {
                pos = value;
            }
        }
    }
}

