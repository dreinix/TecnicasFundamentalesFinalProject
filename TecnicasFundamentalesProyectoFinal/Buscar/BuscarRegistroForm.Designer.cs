namespace TecnicasFundamentalesProyectoFinal.Buscar
{
    partial class BuscarRegistroForm
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
            this.BtSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LbBuscar = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DGVAlumnos = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LBIndice = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSalir
            // 
            this.BtSalir.AutoSize = true;
            this.BtSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtSalir.Depth = 0;
            this.BtSalir.Icon = null;
            this.BtSalir.Location = new System.Drawing.Point(1519, 669);
            this.BtSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Primary = true;
            this.BtSalir.Size = new System.Drawing.Size(58, 36);
            this.BtSalir.TabIndex = 18;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.Depth = 0;
            this.LbBuscar.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbBuscar.Location = new System.Drawing.Point(12, 72);
            this.LbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(122, 19);
            this.LbBuscar.TabIndex = 17;
            this.LbBuscar.Text = "Alumno a buscar";
            this.LbBuscar.TextChanged += new System.EventHandler(this.LbBuscar_TextChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Depth = 0;
            this.TxtBuscar.Hint = "";
            this.TxtBuscar.Location = new System.Drawing.Point(12, 106);
            this.TxtBuscar.MaxLength = 32767;
            this.TxtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.Size = new System.Drawing.Size(203, 23);
            this.TxtBuscar.TabIndex = 16;
            this.TxtBuscar.TabStop = false;
            this.TxtBuscar.UseSystemPasswordChar = false;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // DGVAlumnos
            // 
            this.DGVAlumnos.AllowUserToAddRows = false;
            this.DGVAlumnos.AllowUserToDeleteRows = false;
            this.DGVAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlumnos.Location = new System.Drawing.Point(12, 145);
            this.DGVAlumnos.Name = "DGVAlumnos";
            this.DGVAlumnos.ReadOnly = true;
            this.DGVAlumnos.Size = new System.Drawing.Size(1565, 507);
            this.DGVAlumnos.TabIndex = 15;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1455, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Indice";
            // 
            // LBIndice
            // 
            this.LBIndice.AutoSize = true;
            this.LBIndice.Depth = 0;
            this.LBIndice.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBIndice.Location = new System.Drawing.Point(1469, 106);
            this.LBIndice.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBIndice.Name = "LBIndice";
            this.LBIndice.Size = new System.Drawing.Size(17, 19);
            this.LBIndice.TabIndex = 20;
            this.LBIndice.Text = "0";
            // 
            // BuscarRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 730);
            this.Controls.Add(this.LBIndice);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.LbBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DGVAlumnos);
            this.Name = "BuscarRegistroForm";
            this.Text = "BuscarRegistroForm";
            this.Load += new System.EventHandler(this.BuscarRegistroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtSalir;
        private MaterialSkin.Controls.MaterialLabel LbBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscar;
        private System.Windows.Forms.DataGridView DGVAlumnos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LBIndice;
    }
}