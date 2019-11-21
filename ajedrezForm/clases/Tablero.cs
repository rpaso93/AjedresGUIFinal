using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajedrezForm
{
    class Tablero
    {
        public Piezas[,] nuevaPieza = new Piezas[8, 8];

        public Tablero()
        {
            for (int c = 0 ; c < 8; c++)
            {
                nuevaPieza[ 1 , c ] = new Peon("B");
                nuevaPieza[ 6 , c ] = new Peon("N");  
            }

            for (int f = 2; f < 6; f++)
                for (int c = 0; c < 8; c++)
                {
                    nuevaPieza[f, c] = new Piezas("V");
                }

            nuevaPieza[0, 0] = new Torre("B");
            nuevaPieza[0, 7] = new Torre("B");
            nuevaPieza[7, 0] = new Torre("N");
            nuevaPieza[7, 7] = new Torre("N");

            nuevaPieza[0, 1] = new Caballo( "B");
            nuevaPieza[0, 6] = new Caballo( "B");
            nuevaPieza[7, 1] = new Caballo( "N");
            nuevaPieza[7, 6] = new Caballo( "N");

            nuevaPieza[0, 2] = new Alfil( "B");
            nuevaPieza[0, 5] = new Alfil( "B");
            nuevaPieza[7, 2] = new Alfil( "N");
            nuevaPieza[7, 5] = new Alfil( "N");

            nuevaPieza[0, 3] = new Rey( "B");
            nuevaPieza[7, 3] = new Rey( "N");

            nuevaPieza[0, 4] = new Reina( "B");
            nuevaPieza[7, 4] = new Reina( "N");

            
        }    
  }
}
