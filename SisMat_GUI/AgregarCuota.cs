using SisMat_BE;
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
    public partial class AgregarCuota : Form
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        CuotaBE objCuotaBE = new CuotaBE();
        CuotaBL objCuotaBL = new CuotaBL();


        public AgregarCuota()
        {
            InitializeComponent();
        }

        private void AgregarCuota_Load(object sender, EventArgs e)
        {

            try
            {

           

            DataTable dt = new DataTable();

            //LLenamos el combo de Tipo


            dt.Columns.Add(new DataColumn("Index", typeof(int)));
            dt.Columns.Add(new DataColumn("Des_Tipo", typeof(String)));


            DataRow dr = dt.NewRow();

            dr["Index"] = 0;
            dr["Des_Tipo"] = "--Seleccione";
            dt.Rows.Add(dr);


            dr = dt.NewRow();
            dr["Index"] = 1;
            dr["Des_Tipo"] = "Matricula";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Index"] = 2;
            dr["Des_Tipo"] = "Mensualidad";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Index"] = 3;
            dr["Des_Tipo"] = "Otros";
            dt.Rows.Add(dr);

            cmbTipo.DataSource = dt;
            cmbTipo.DisplayMember = "Des_Tipo";
            cmbTipo.ValueMember = "Index";

            //LLenamos el combo de Estado

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Index", typeof(int)));
            dt.Columns.Add(new DataColumn("Des_Estado", typeof(String)));

            dr = dt.NewRow();

            dr["Index"] = 0;
            dr["Des_Estado"] = "--Seleccione";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Index"] = 1;
            dr["Des_Estado"] = "Pendiente";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Index"] = 2;
            dr["Des_Estado"] = "Pagado";
            dt.Rows.Add(dr);

            cmbEstado.DataSource = dt;
            cmbEstado.DisplayMember = "Des_Estado";
            cmbEstado.ValueMember = "Index";

            //LLenamos el combo de alumno

            dt = objAlumnoBL.ListarAlumno();
            dr = dt.NewRow();

            dr["Id_alum"] = 0;
            dr["Nom_alum"] = "--Seleccione";
            dr["Ape_alum"] = "";
            dt.Rows.InsertAt(dr, 0);

            dt.Columns.Add("NomApe", typeof(String), "Nom_alum + ' ' + Ape_alum");
          
            cmbAlumnos.DataSource = dt;
            cmbAlumnos.DisplayMember = "NomApe";
            cmbAlumnos.ValueMember = "Id_alum";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCuota_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtCuota.Text.Trim()==String.Empty) { throw new Exception("Debe Ingresar un Numero de cuota"); }
                //if(mskPrecio.MaskFull != true) { throw new Exception("Precio de cuota invalido"); }
                if(cmbAlumnos.SelectedIndex == 0 || cmbEstado.SelectedIndex == 0 || cmbTipo.SelectedIndex == 0) { throw new Exception("Falta seleccionar datos"); }

                //Falta validar Fechas



                objCuotaBE.Ndoc_cuota = txtCuota.Text.Trim();
                objCuotaBE.Precio_cuota = float.Parse(mskPrecio.Text);
                objCuotaBE.Id_alum = Convert.ToInt16(cmbAlumnos.SelectedValue);
                objCuotaBE.Est_cuota = Convert.ToInt16(cmbEstado.SelectedValue);
                objCuotaBE.Tip_cuota = Convert.ToInt16(cmbTipo.SelectedValue);
                //objCuotaBE.Vencimiento = Convert.ToDateTime(mskVencimiento);
                //objCuotaBE.Fec_pago = Convert.ToDateTime(mskFechaPago);

                objCuotaBE.Vencimiento = dtpVencimiento.Value.Date;

                if (dtpFechaPago.Enabled) { objCuotaBE.Fec_pago = dtpFechaPago.Value.Date; } 
                {
                    objCuotaBE.Fec_pago = DateTime.MaxValue;
                }



                if (objCuotaBL.InsertarCuota(objCuotaBE) == true)
                {
                    this.Close();
                }
                else { throw new Exception("No se pudo insertar la cuota"); }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al insertar:" + ex.Message);
            }

           
        }

        private void dtpVencimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex <=1) { dtpFechaPago.Enabled = false; }
            else { dtpFechaPago.Enabled = true; }
        }
    }
}
