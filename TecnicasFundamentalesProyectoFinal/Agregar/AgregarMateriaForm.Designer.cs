namespace TecnicasFundamentalesProyectoFinal.Agregar
{
    partial class AgregarMateriaForm
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
            this.LbClave = new MaterialSkin.Controls.MaterialLabel();
            this.TxtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbNombre = new MaterialSkin.Controls.MaterialLabel();
            this.LbCredito = new MaterialSkin.Controls.MaterialLabel();
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CBCredito = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LbClave
            // 
            this.LbClave.AutoSize = true;
            this.LbClave.Depth = 0;
            this.LbClave.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbClave.Location = new System.Drawing.Point(13, 86);
            this.LbClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbClave.Name = "LbClave";
            this.LbClave.Size = new System.Drawing.Size(46, 19);
            this.LbClave.TabIndex = 0;
            this.LbClave.Text = "Clave";
            // 
            // TxtClave
            // 
            this.TxtClave.Depth = 0;
            this.TxtClave.Hint = "";
            this.TxtClave.Location = new System.Drawing.Point(17, 118);
            this.TxtClave.MaxLength = 32767;
            this.TxtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '\0';
            this.TxtClave.SelectedText = "";
            this.TxtClave.SelectionLength = 0;
            this.TxtClave.SelectionStart = 0;
            this.TxtClave.Size = new System.Drawing.Size(195, 23);
            this.TxtClave.TabIndex = 1;
            this.TxtClave.TabStop = false;
            this.TxtClave.UseSystemPasswordChar = false;
            this.TxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClave_KeyPress);
            this.TxtClave.TextChanged += new System.EventHandler(this.TxtClave_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Hint = "";
            this.TxtNombre.Location = new System.Drawing.Point(240, 118);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.Size = new System.Drawing.Size(195, 23);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.UseSystemPasswordChar = false;
            this.TxtNombre.Click += new System.EventHandler(this.TxtNombre_Click);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialSingleLineTextField2_KeyPress);
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Depth = 0;
            this.LbNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbNombre.Location = new System.Drawing.Point(236, 86);
            this.LbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(63, 19);
            this.LbNombre.TabIndex = 2;
            this.LbNombre.Text = "Nombre";
            // 
            // LbCredito
            // 
            this.LbCredito.AutoSize = true;
            this.LbCredito.Depth = 0;
            this.LbCredito.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCredito.Location = new System.Drawing.Point(13, 169);
            this.LbCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbCredito.Name = "LbCredito";
            this.LbCredito.Size = new System.Drawing.Size(121, 19);
            this.LbCredito.TabIndex = 4;
            this.LbCredito.Text = "Cantidad Credito";
            this.LbCredito.TextChanged += new System.EventHandler(this.materialLabel3_TextChanged);
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(136, 241);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(91, 36);
            this.BtCancelar.TabIndex = 8;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.AutoSize = true;
            this.BtGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtGuardar.Depth = 0;
            this.BtGuardar.Icon = null;
            this.BtGuardar.Location = new System.Drawing.Point(17, 241);
            this.BtGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Primary = true;
            this.BtGuardar.Size = new System.Drawing.Size(84, 36);
            this.BtGuardar.TabIndex = 7;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // CBCredito
            // 
            this.CBCredito.FormattingEnabled = true;
            this.CBCredito.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBCredito.Location = new System.Drawing.Point(17, 204);
            this.CBCredito.Name = "CBCredito";
            this.CBCredito.Size = new System.Drawing.Size(195, 21);
            this.CBCredito.TabIndex = 9;
            this.CBCredito.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // AgregarMateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 325);
            this.Controls.Add(this.CBCredito);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.LbCredito);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.LbClave);
            this.Name = "AgregarMateriaForm";
            this.Text = "AgregarMateriaForm";
            this.Load += new System.EventHandler(this.AgregarMateriaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LbClave;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtClave;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombre;
        private MaterialSkin.Controls.MaterialLabel LbNombre;
        private MaterialSkin.Controls.MaterialLabel LbCredito;
        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton BtGuardar;
        private System.Windows.Forms.ComboBox CBCredito;
    }
}