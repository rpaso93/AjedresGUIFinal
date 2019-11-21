using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajedrezForm
{
    public partial class Historial : Form
    {
        Form1 f;
        public Historial(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            
           // dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
           
            
            
        }
         public void fijarTiempoBlancas(int t)
         {
             label1.Text = "Tiempo Blancas: " + (int)(t / 60) + ":";
             label1.Text += ((t % 60) == 0) ? "00" : (t % 60).ToString();
        }

        public void fijarTiempoNegras(int t)
        {
            label2.Text = "Tiempo Negras: " + (int)(t / 60) + ":";

            label2.Text += ((t % 60)==0)?"00": (t % 60).ToString();
        }

        public void agregarMovimiento(int n, int i, string s)
        {
            DBconnect.agregarJugada(n, i, s);
            DBconnect.cerrarConexion();
            dataGridView1.DataSource = DBconnect.obtenerJugadas(f.nump);
            DBconnect.cerrarConexion();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0];

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            f.cargarPosicion(dataGridView1.CurrentCell.RowIndex);
 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= dataGridView1.Rows.Count-1) return;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex+1].Cells[0];
            f.cargarPosicion(dataGridView1.CurrentCell.RowIndex);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex == 0) return;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex - 1].Cells[0];
            f.cargarPosicion(dataGridView1.CurrentCell.RowIndex);
        }


    }
}
