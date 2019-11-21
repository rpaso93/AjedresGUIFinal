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

    public class Piezas
    {
        private string nombre;
        private string color;

        private Bitmap img;
        

        public Piezas(string color)
        {
            this.Nombre = this.GetType().Name;
            this.color = color;            
        }

        public virtual List<Point> Movimientos(Point pos)
        {
            List<Point> pp = new List<Point>(); 
            return pp;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public Bitmap Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }




    }
}
