using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoProgra3.Ventas
{
    public partial class frm_Ventas_Pago : Form
    {
        Ventas.CN_Ventas CN = new Ventas.CN_Ventas();

        public frm_Ventas_Pago()
        {
            InitializeComponent();
            if (CN.Metodo_de_Pago.Trim() == "Efectivo")
            {
                txtNumeroTarjeta.Enabled = false;
                cmbEmisorTarjeta.Enabled = false;
                txtCodigoTarjeta.Enabled = false;
                txtFechaTarjeta.Enabled = false;
                groupBox2.Enabled = false;
                txtPagaEfectivo.Enabled = true;

            }
            else{}
            if (CN.Metodo_de_Pago.Trim() == "Tarjeta Credito" || CN.Metodo_de_Pago.Trim() == "Tarjeta Debito")
            {
                txtNumeroTarjeta.Enabled = true;
                cmbEmisorTarjeta.Enabled = true;
                txtCodigoTarjeta.Enabled = true;
                txtFechaTarjeta.Enabled = true;
                groupBox2.Enabled = true;
                txtPagaEfectivo.Enabled = false;
            }
            else{}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Manda al Banco los datos

            

            //Aqui Agregar inseert a la base de datos y rellenar datos en blancos

            frm_Ventas frmPadre = new frm_Ventas();
            frmPadre.limpiartabla();
        }
    }
}
