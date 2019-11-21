using System;

public class Class1
{
	public Class1()
	{
        private string nombre;
        private string color;
        private int posicionX;
        private int posicionY;

        public PiezasTablero(string nombre, string color, int posicionX, int posicionY)
        {
            this.nombre = nombre;
            this.color = color;
            this.posicionX = posicionX;
            this.posicionY = posicionY;
        }
}
