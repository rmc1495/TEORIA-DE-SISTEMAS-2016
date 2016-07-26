using System;
using System.Windows.Forms;

namespace ProyectoProgra3.Mantenimineto.Inventario_y_Proveedores
{
    public partial class frm_Marcas : Form
    {
        public frm_Marcas()
        {
            InitializeComponent();
            FormatoGrid();
        }

        private void FormatoGrid()
        {
            dgvMarca.ColumnCount = 1;
            dgvMarca.Columns[0].Name = "Marca";
        }


        private void Limpiar()
        {
            txtNombreMarca.Clear();
         }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (txtNombreMarca.Text == "")
                {
                    MessageBox.Show("Se requieren todos los espacios completos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    ProyectoCN.Mantenimiento.Inventario_y_Proveedor.CN_Marca marca = new ProyectoCN.Mantenimiento.Inventario_y_Proveedor.CN_Marca();
                    marca.Marca = txtNombreMarca.Text;

                  

                    DialogResult dialogResult = MessageBox.Show("Esta seguro que desea guardar la marca: "+ txtNombreMarca.Text.ToUpper(), "Registro de Marcas", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        marca.GuardarMarca(marca);
                        MessageBox.Show("Datos registrados correctamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string[] row = { txtNombreMarca.Text };
                        dgvMarca.Rows.Add(row);
                        Limpiar();

                    }
                                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea buscar todos los usuarios: \n" + "Esto podria tardar varios segundos".ToUpper(), "Registro de Marcas", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                dgvtodos.Visible= true;
                dgvtodos.Enabled = true;
           

            }
        }

        private void frm_Marcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_TSistemasDataSet.sp_ConsultarMarca' table. You can move, or remove it, as needed.
            this.sp_ConsultarMarcaTableAdapter.Fill(this.dB_TSistemasDataSet.sp_ConsultarMarca);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
