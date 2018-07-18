namespace TecnicasFundamentalesProyectoFinal
{
    partial class BuscarMaestrosForm
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
            this.LbBuscar = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DGVMaestros = new System.Windows.Forms.DataGridView();
            this.BtSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaestros)).BeginInit();
            this.SuspendLayout();
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.Depth = 0;
            this.LbBuscar.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbBuscar.Location = new System.Drawing.Point(12, 78);
            this.LbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(134, 19);
            this.LbBuscar.TabIndex = 13;
            this.LbBuscar.Text = "Elemento a buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Depth = 0;
            this.TxtBuscar.Hint = "";
            this.TxtBuscar.Location = new System.Drawing.Point(12, 112);
            this.TxtBuscar.MaxLength = 32767;
            this.TxtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.Size = new System.Drawing.Size(203, 23);
            this.TxtBuscar.TabIndex = 12;
            this.TxtBuscar.TabStop = false;
            this.TxtBuscar.UseSystemPasswordChar = false;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // DGVMaestros
            // 
            this.DGVMaestros.AllowUserToAddRows = false;
            this.DGVMaestros.AllowUserToDeleteRows = false;
            this.DGVMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMaestros.Location = new System.Drawing.Point(12, 151);
            this.DGVMaestros.Name = "DGVMaestros";
            this.DGVMaestros.ReadOnly = true;
            this.DGVMaestros.Size = new System.Drawing.Size(1565, 507);
            this.DGVMaestros.TabIndex = 11;
            // 
            // BtSalir
            // 
            this.BtSalir.AutoSize = true;
            this.BtSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtSalir.Depth = 0;
            this.BtSalir.Icon = null;
            this.BtSalir.Location = new System.Drawing.Point(1519, 673);
            this.BtSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Primary = true;
            this.BtSalir.Size = new System.Drawing.Size(58, 36);
            this.BtSalir.TabIndex = 14;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BuscarMaestrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 721);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.LbBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DGVMaestros);
            this.Name = "BuscarMaestrosForm";
            this.Text = "BuscarMaestrosForm";
            this.Load += new System.EventHandler(this.BuscarMaestrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaestros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LbBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscar;
        private System.Windows.Forms.DataGridView DGVMaestros;
        private MaterialSkin.Controls.MaterialRaisedButton BtSalir;
    }
}