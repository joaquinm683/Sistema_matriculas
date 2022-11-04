using SisMat_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisMat_GUI
{
    public partial class CuotaMan : Form

        

    {
        CuotaBL objCuotaBL = new CuotaBL();
        DataView dtv;
        public CuotaMan()
        {
            InitializeComponent();
        }

        private void CuotaMan_Load(object sender, EventArgs e)
        {
            dtgCuotas.AutoGenerateColumns = false;
            dtgCuotas.DataSource = objCuotaBL.ListarCuota();


            lblCount.Text = dtgCuotas.Rows.Count.ToString();



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCuota agregarCuotaModal = new AgregarCuota();
            agregarCuotaModal.ShowDialog();

            dtgCuotas.DataSource = objCuotaBL.ListarCuota();
           

            txtFiltro.Text = "";
            lblCount.Text = dtgCuotas.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarCuota editarCuotaModal = new ActualizarCuota();
            editarCuotaModal.IdCuota = dtgCuotas.CurrentRow.Cells[0].Value.ToString();
            editarCuotaModal.ShowDialog();

            dtgCuotas.DataSource = objCuotaBL.ListarCuota();
            lblCount.Text = dtgCuotas.Rows.Count.ToString();


            txtFiltro.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ListarDatos(txtFiltro.Text.Trim());
        }

        private void ListarDatos(String keyword)
        {
            dtv = new DataView(objCuotaBL.ListarCuota());
            dtv.RowFilter = "NombreCompleto like  '%" + keyword + "%'";
            dtgCuotas.DataSource = dtv;


            lblCount.Text = dtgCuotas.Rows.Count.ToString();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
