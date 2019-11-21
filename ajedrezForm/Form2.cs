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
    public partial class Form2 : Form
    {
        public Form2(int SX, int SY, int LX, int LY, char c)
        {
            InitializeComponent();
            
            this.Size = new Size(SX * 2 + 15, SY * 8);
            if(c == '-')
                this.Location = new Point(LX - SX * 2, LY);
            else
                this.Location = new Point(LX + SX * 8 + 10, LY);

            for (int i = 0; i < 16; i++)
            {
                PictureBox p = new PictureBox();
                p.Size = new Size(this.Size.Width/2 - 10, this.Size.Height/9);
                p.Location = new Point((i%2) * p.Size.Width, (i/2) * p.Size.Height);
                this.Controls.Add(p);
            }
        }

        public void Eliminar_Pieza(Image img)
        {
            foreach (PictureBox pb in this.Controls)
            {
                if(pb.BackgroundImage == null)
                {
                    pb.BackgroundImage = img;
                    pb.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
