namespace TecnicasFundamentalesProyectoFinal
{
    partial class AgregarAlumnoForm
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
            this.LbNombre = new MaterialSkin.Controls.MaterialLabel();
            this.LbApellido = new MaterialSkin.Controls.MaterialLabel();
            this.TxtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbEstado = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LbCarrera = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCarrera = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtIdentificadorNacial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.LbIdentificador = new MaterialSkin.Controls.MaterialLabel();
            this.BtGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Depth = 0;
            this.LbNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbNombre.Location = new System.Drawing.Point(12, 77);
            this.LbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(63, 19);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "Nombre";
            // 
            // LbApellido
            // 
            this.LbApellido.AutoSize = true;
            this.LbApellido.Depth = 0;
            this.LbApellido.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbApellido.Location = new System.Drawing.Point(260, 77);
            this.LbApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbApellido.Name = "LbApellido";
            this.LbApellido.Size = new System.Drawing.Size(64, 19);
            this.LbApellido.TabIndex = 1;
            this.LbApellido.Text = "Apellido";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Depth = 0;
            this.TxtApellido.Hint = "";
            this.TxtApellido.Location = new System.Drawing.Point(264, 122);
            this.TxtApellido.MaxLength = 32767;
            this.TxtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.PasswordChar = '\0';
            this.TxtApellido.SelectedText = "";
            this.TxtApellido.SelectionLength = 0;
            this.TxtApellido.SelectionStart = 0;
            this.TxtApellido.Size = new System.Drawing.Size(212, 23);
            this.TxtApellido.TabIndex = 1;
            this.TxtApellido.TabStop = false;
            this.TxtApellido.UseSystemPasswordChar = false;
            this.TxtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtApellido_KeyDown);
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Hint = "";
            this.TxtNombre.Location = new System.Drawing.Point(16, 122);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.Size = new System.Drawing.Size(186, 23);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.UseSystemPasswordChar = false;
            // 
            // LbEstado
            // 
            this.LbEstado.AutoSize = true;
            this.LbEstado.Depth = 0;
            this.LbEstado.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbEstado.Location = new System.Drawing.Point(260, 306);
            this.LbEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbEstado.Name = "LbEstado";
            this.LbEstado.Size = new System.Drawing.Size(100, 19);
            this.LbEstado.TabIndex = 4;
            this.LbEstado.Text = "Estado Inicial";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "APA",
            "Normal",
            "En proceso",
            "Retirado"});
            this.comboBox1.Location = new System.Drawing.Point(264, 345);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // LbCarrera
            // 
            this.LbCarrera.AutoSize = true;
            this.LbCarrera.Depth = 0;
            this.LbCarrera.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCarrera.Location = new System.Drawing.Point(264, 199);
            this.LbCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbCarrera.Name = "LbCarrera";
            this.LbCarrera.Size = new System.Drawing.Size(58, 19);
            this.LbCarrera.TabIndex = 6;
            this.LbCarrera.Text = "Carrera";
            // 
            // TxtCarrera
            // 
            this.TxtCarrera.Depth = 0;
            this.TxtCarrera.Hint = "";
            this.TxtCarrera.Location = new System.Drawing.Point(264, 233);
            this.TxtCarrera.MaxLength = 32767;
            this.TxtCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCarrera.Name = "TxtCarrera";
            this.TxtCarrera.PasswordChar = '\0';
            this.TxtCarrera.SelectedText = "";
            this.TxtCarrera.SelectionLength = 0;
            this.TxtCarrera.SelectionStart = 0;
            this.TxtCarrera.Size = new System.Drawing.Size(212, 23);
            this.TxtCarrera.TabIndex = 3;
            this.TxtCarrera.TabStop = false;
            this.TxtCarrera.UseSystemPasswordChar = false;
            this.TxtCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCarrera_KeyPress);
            // 
            // TxtIdentificadorNacial
            // 
            this.TxtIdentificadorNacial.Depth = 0;
            this.TxtIdentificadorNacial.Hint = "";
            this.TxtIdentificadorNacial.Location = new System.Drawing.Point(12, 345);
            this.TxtIdentificadorNacial.MaxLength = 32767;
            this.TxtIdentificadorNacial.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdentificadorNacial.Name = "TxtIdentificadorNacial";
            this.TxtIdentificadorNacial.PasswordChar = '\0';
            this.TxtIdentificadorNacial.SelectedText = "";
            this.TxtIdentificadorNacial.SelectionLength = 0;
            this.TxtIdentificadorNacial.SelectionStart = 0;
            this.TxtIdentificadorNacial.Size = new System.Drawing.Size(182, 23);
            this.TxtIdentificadorNacial.TabIndex = 4;
            this.TxtIdentificadorNacial.TabStop = false;
            this.TxtIdentificadorNacial.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 199);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Fecha de nacimiento";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(16, 236);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(149, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // LbIdentificador
            // 
            this.LbIdentificador.AutoSize = true;
            this.LbIdentificador.Depth = 0;
            this.LbIdentificador.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbIdentificador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbIdentificador.Location = new System.Drawing.Point(17, 306);
            this.LbIdentificador.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbIdentificador.Name = "LbIdentificador";
            this.LbIdentificador.Size = new System.Drawing.Size(154, 19);
            this.LbIdentificador.TabIndex = 11;
            this.LbIdentificador.Text = "Identificador nacional";
            this.LbIdentificador.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.AutoSize = true;
            this.BtGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtGuardar.Depth = 0;
            this.BtGuardar.Icon = null;
            this.BtGuardar.Location = new System.Drawing.Point(7, 433);
            this.BtGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Primary = true;
            this.BtGuardar.Size = new System.Drawing.Size(84, 36);
            this.BtGuardar.TabIndex = 12;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(136, 433);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(91, 36);
            this.BtCancelar.TabIndex = 13;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // CrearAlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 542);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.LbIdentificador);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtIdentificadorNacial);
            this.Controls.Add(this.TxtCarrera);
            this.Controls.Add(this.LbCarrera);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LbEstado);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LbApellido);
            this.Controls.Add(this.LbNombre);
            this.Name = "CrearAlumnoForm";
            this.Text = "CrearAlumnoForm";
            this.Load += new System.EventHandler(this.CrearAlumnoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LbNombre;
        private MaterialSkin.Controls.MaterialLabel LbApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombre;
        private MaterialSkin.Controls.MaterialLabel LbEstado;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel LbCarrera;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCarrera;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdentificadorNacial;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MaterialSkin.Controls.MaterialLabel LbIdentificador;
        private MaterialSkin.Controls.MaterialRaisedButton BtGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
    }
}