namespace TecnicasFundamentalesProyectoFinal.Ver
{
    partial class VerDetallesAlumnoForm
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
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LbIdentificador = new MaterialSkin.Controls.MaterialLabel();
            this.MTBFecha = new System.Windows.Forms.MaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtIdentificadorNacial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCarrera = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbCarrera = new MaterialSkin.Controls.MaterialLabel();
            this.LbEstado = new MaterialSkin.Controls.MaterialLabel();
            this.TxtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbApellido = new MaterialSkin.Controls.MaterialLabel();
            this.LbNombre = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImage
            // 
            this.PBImage.BackgroundImage = global::TecnicasFundamentalesProyectoFinal.Properties.Resources.intec;
            this.PBImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBImage.Image = global::TecnicasFundamentalesProyectoFinal.Properties.Resources.intec;
            this.PBImage.Location = new System.Drawing.Point(537, 70);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(199, 125);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 30;
            this.PBImage.TabStop = false;
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(678, 435);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(58, 36);
            this.BtCancelar.TabIndex = 29;
            this.BtCancelar.Text = "Salir";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // LbIdentificador
            // 
            this.LbIdentificador.AutoSize = true;
            this.LbIdentificador.Depth = 0;
            this.LbIdentificador.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbIdentificador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbIdentificador.Location = new System.Drawing.Point(27, 299);
            this.LbIdentificador.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbIdentificador.Name = "LbIdentificador";
            this.LbIdentificador.Size = new System.Drawing.Size(154, 19);
            this.LbIdentificador.TabIndex = 27;
            this.LbIdentificador.Text = "Identificador nacional";
            // 
            // MTBFecha
            // 
            this.MTBFecha.Enabled = false;
            this.MTBFecha.Location = new System.Drawing.Point(26, 229);
            this.MTBFecha.Mask = "00/00/0000";
            this.MTBFecha.Name = "MTBFecha";
            this.MTBFecha.Size = new System.Drawing.Size(149, 20);
            this.MTBFecha.TabIndex = 20;
            this.MTBFecha.ValidatingType = typeof(System.DateTime);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 192);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Fecha de nacimiento";
            // 
            // TxtIdentificadorNacial
            // 
            this.TxtIdentificadorNacial.Depth = 0;
            this.TxtIdentificadorNacial.Enabled = false;
            this.TxtIdentificadorNacial.Hint = "";
            this.TxtIdentificadorNacial.Location = new System.Drawing.Point(22, 338);
            this.TxtIdentificadorNacial.MaxLength = 32767;
            this.TxtIdentificadorNacial.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdentificadorNacial.Name = "TxtIdentificadorNacial";
            this.TxtIdentificadorNacial.PasswordChar = '\0';
            this.TxtIdentificadorNacial.SelectedText = "";
            this.TxtIdentificadorNacial.SelectionLength = 0;
            this.TxtIdentificadorNacial.SelectionStart = 0;
            this.TxtIdentificadorNacial.Size = new System.Drawing.Size(182, 23);
            this.TxtIdentificadorNacial.TabIndex = 22;
            this.TxtIdentificadorNacial.TabStop = false;
            this.TxtIdentificadorNacial.UseSystemPasswordChar = false;
            // 
            // TxtCarrera
            // 
            this.TxtCarrera.Depth = 0;
            this.TxtCarrera.Enabled = false;
            this.TxtCarrera.Hint = "";
            this.TxtCarrera.Location = new System.Drawing.Point(274, 226);
            this.TxtCarrera.MaxLength = 32767;
            this.TxtCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCarrera.Name = "TxtCarrera";
            this.TxtCarrera.PasswordChar = '\0';
            this.TxtCarrera.SelectedText = "";
            this.TxtCarrera.SelectionLength = 0;
            this.TxtCarrera.SelectionStart = 0;
            this.TxtCarrera.Size = new System.Drawing.Size(212, 23);
            this.TxtCarrera.TabIndex = 21;
            this.TxtCarrera.TabStop = false;
            this.TxtCarrera.UseSystemPasswordChar = false;
            // 
            // LbCarrera
            // 
            this.LbCarrera.AutoSize = true;
            this.LbCarrera.Depth = 0;
            this.LbCarrera.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCarrera.Location = new System.Drawing.Point(274, 192);
            this.LbCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbCarrera.Name = "LbCarrera";
            this.LbCarrera.Size = new System.Drawing.Size(58, 19);
            this.LbCarrera.TabIndex = 25;
            this.LbCarrera.Text = "Carrera";
            // 
            // LbEstado
            // 
            this.LbEstado.AutoSize = true;
            this.LbEstado.Depth = 0;
            this.LbEstado.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbEstado.Location = new System.Drawing.Point(270, 299);
            this.LbEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbEstado.Name = "LbEstado";
            this.LbEstado.Size = new System.Drawing.Size(100, 19);
            this.LbEstado.TabIndex = 23;
            this.LbEstado.Text = "Estado Inicial";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Hint = "";
            this.TxtNombre.Location = new System.Drawing.Point(26, 115);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.Size = new System.Drawing.Size(186, 23);
            this.TxtNombre.TabIndex = 16;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.UseSystemPasswordChar = false;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Depth = 0;
            this.TxtApellido.Enabled = false;
            this.TxtApellido.Hint = "";
            this.TxtApellido.Location = new System.Drawing.Point(274, 115);
            this.TxtApellido.MaxLength = 32767;
            this.TxtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.PasswordChar = '\0';
            this.TxtApellido.SelectedText = "";
            this.TxtApellido.SelectionLength = 0;
            this.TxtApellido.SelectionStart = 0;
            this.TxtApellido.Size = new System.Drawing.Size(212, 23);
            this.TxtApellido.TabIndex = 18;
            this.TxtApellido.TabStop = false;
            this.TxtApellido.UseSystemPasswordChar = false;
            // 
            // LbApellido
            // 
            this.LbApellido.AutoSize = true;
            this.LbApellido.Depth = 0;
            this.LbApellido.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbApellido.Location = new System.Drawing.Point(270, 70);
            this.LbApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbApellido.Name = "LbApellido";
            this.LbApellido.Size = new System.Drawing.Size(64, 19);
            this.LbApellido.TabIndex = 19;
            this.LbApellido.Text = "Apellido";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Depth = 0;
            this.LbNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbNombre.Location = new System.Drawing.Point(22, 70);
            this.LbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(63, 19);
            this.LbNombre.TabIndex = 17;
            this.LbNombre.Text = "Nombre";
            // 
            // TxtEstado
            // 
            this.TxtEstado.Depth = 0;
            this.TxtEstado.Enabled = false;
            this.TxtEstado.Hint = "";
            this.TxtEstado.Location = new System.Drawing.Point(274, 338);
            this.TxtEstado.MaxLength = 32767;
            this.TxtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.PasswordChar = '\0';
            this.TxtEstado.SelectedText = "";
            this.TxtEstado.SelectionLength = 0;
            this.TxtEstado.SelectionStart = 0;
            this.TxtEstado.Size = new System.Drawing.Size(212, 23);
            this.TxtEstado.TabIndex = 32;
            this.TxtEstado.TabStop = false;
            this.TxtEstado.UseSystemPasswordChar = false;
            // 
            // VerDetallesAlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 483);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.PBImage);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.LbIdentificador);
            this.Controls.Add(this.MTBFecha);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtIdentificadorNacial);
            this.Controls.Add(this.TxtCarrera);
            this.Controls.Add(this.LbCarrera);
            this.Controls.Add(this.LbEstado);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LbApellido);
            this.Controls.Add(this.LbNombre);
            this.Name = "VerDetallesAlumnoForm";
            this.Text = "VerDetallesAlumnoForm";
            this.Load += new System.EventHandler(this.VerDetallesAlumnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImage;
        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
        private MaterialSkin.Controls.MaterialLabel LbIdentificador;
        private System.Windows.Forms.MaskedTextBox MTBFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdentificadorNacial;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCarrera;
        private MaterialSkin.Controls.MaterialLabel LbCarrera;
        private MaterialSkin.Controls.MaterialLabel LbEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtApellido;
        private MaterialSkin.Controls.MaterialLabel LbApellido;
        private MaterialSkin.Controls.MaterialLabel LbNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEstado;
    }
}