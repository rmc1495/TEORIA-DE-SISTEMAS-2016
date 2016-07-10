using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoProgra3
{
    public partial class frm_Ventas : Form
    {
        public frm_Ventas()
        {
            InitializeComponent();
        }

        private void lblNombrecli_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Productos p = new frm_Productos();
            this.Close();
            p.ShowDialog();
        }

        private void lblIDCliente_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
