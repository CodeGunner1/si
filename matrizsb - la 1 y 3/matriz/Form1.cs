using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz
{

    public partial class Form1 : Form
    {
        Matriz m1, m2;
        Arreglo3D Y1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matriz();
            m2 = new Matriz();
            Y1 = new Arreglo3D();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = m1.descargar();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = m1.descargar();
        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Ejercicio11p1();
            textBox6.Text = m1.descargar();
        }

        private void pregunta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //3
            Y1.OrdenarPorColumnasDeCadaProfundidad();
            textBox6.Text = Y1.Descargar();
        }

        private void cARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int mf, mc, mp, ra, rb;
            mf = int.Parse(textBox1.Text);
            mc = int.Parse(textBox2.Text);
            mp = int.Parse(textBox3.Text);
            ra = int.Parse(textBox4.Text);
            rb = int.Parse(textBox7.Text);

            Y1.Cargar(mf, mc, mp, ra, rb);
        }

        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = Y1.Descargar();
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
