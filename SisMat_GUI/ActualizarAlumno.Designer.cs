namespace SisMat_GUI
{
    partial class ActualizarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.mskFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.cmbUbigeo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizarAlumno = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // mskFechaNacimiento
            // 
            this.mskFechaNacimiento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mskFechaNacimiento.Location = new System.Drawing.Point(240, 446);
            this.mskFechaNacimiento.Mask = "0000/00/00";
            this.mskFechaNacimiento.Name = "mskFechaNacimiento";
            this.mskFechaNacimiento.Size = new System.Drawing.Size(100, 23);
            this.mskFechaNacimiento.TabIndex = 57;
            this.mskFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // cmbUbigeo
            // 
            this.cmbUbigeo.FormattingEnabled = true;
            this.cmbUbigeo.Location = new System.Drawing.Point(186, 394);
            this.cmbUbigeo.Name = "cmbUbigeo";
            this.cmbUbigeo.Size = new System.Drawing.Size(210, 23);
            this.cmbUbigeo.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 55;
            this.label7.Text = "Ubigeo";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(469, 140);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(107, 23);
            this.btnCargarFoto.TabIndex = 54;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            // 
            // pctFoto
            // 
            this.pctFoto.Location = new System.Drawing.Point(469, 180);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(210, 186);
            this.pctFoto.TabIndex = 53;
            this.pctFoto.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(63, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 52;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizarAlumno
            // 
            this.btnActualizarAlumno.BackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarAlumno.Location = new System.Drawing.Point(621, 568);
            this.btnActualizarAlumno.Name = "btnActualizarAlumno";
            this.btnActualizarAlumno.Size = new System.Drawing.Size(131, 34);
            this.btnActualizarAlumno.TabIndex = 51;
            this.btnActualizarAlumno.Text = "Confirmar";
            this.btnActualizarAlumno.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Telefono:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 343);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 45;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(186, 293);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(210, 23);
            this.txtTelefono.TabIndex = 44;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(186, 240);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(210, 23);
            this.txtDNI.TabIndex = 43;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(186, 189);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(210, 23);
            this.txtApellido.TabIndex = 42;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "Editar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 59;
            this.label9.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(172, 498);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(131, 23);
            this.cmbEstado.TabIndex = 60;
            // 
            // ActualizarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 647);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskFechaNacimiento);
            this.Controls.Add(this.cmbUbigeo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.pctFoto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnActualizarAlumno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private MaskedTextBox mskFechaNacimiento;
        private ComboBox cmbUbigeo;
        private Label label7;
        private Button btnCargarFoto;
        private PictureBox pctFoto;
        private Button button2;
        private Button btnActualizarAlumno;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label1;
        private Label label9;
        private ComboBox cmbEstado;
    }
}