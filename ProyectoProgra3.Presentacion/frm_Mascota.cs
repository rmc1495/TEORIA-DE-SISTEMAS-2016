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
    public partial class frm_Mascota : Form
    {
        public frm_Mascota()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtrasCliente_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            frm_Expediente ex = new frm_Expediente();
            ex.ShowDialog();
        }
    }
}
