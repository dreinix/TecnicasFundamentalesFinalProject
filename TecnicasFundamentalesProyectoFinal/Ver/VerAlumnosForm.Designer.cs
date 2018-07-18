namespace TecnicasFundamentalesProyectoFinal
{
    partial class VerAlumnosForm
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
            this.DGVAlumno = new System.Windows.Forms.DataGridView();
            this.BTDetallar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSalir
            // 
            this.BtSalir.AutoSize = true;
            this.BtSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtSalir.Depth = 0;
            this.BtSalir.Icon = null;
            this.BtSalir.Location = new System.Drawing.Point(1497, 598);
            this.BtSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Primary = true;
            this.BtSalir.Size = new System.Drawing.Size(58, 36);
            this.BtSalir.TabIndex = 1;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // DGVAlumno
            // 
            this.DGVAlumno.AllowUserToAddRows = false;
            this.DGVAlumno.AllowUserToDeleteRows = false;
            this.DGVAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlumno.Location = new System.Drawing.Point(12, 85);
            this.DGVAlumno.Name = "DGVAlumno";
            this.DGVAlumno.ReadOnly = true;
            this.DGVAlumno.Size = new System.Drawing.Size(1543, 507);
            this.DGVAlumno.TabIndex = 2;
            // 
            // BTDetallar
            // 
            this.BTDetallar.AutoSize = true;
            this.BTDetallar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTDetallar.Depth = 0;
            this.BTDetallar.Icon = null;
            this.BTDetallar.Location = new System.Drawing.Point(1561, 85);
            this.BTDetallar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTDetallar.Name = "BTDetallar";
            this.BTDetallar.Primary = true;
            this.BTDetallar.Size = new System.Drawing.Size(88, 36);
            this.BTDetallar.TabIndex = 3;
            this.BTDetallar.Text = "Detallar";
            this.BTDetallar.UseVisualStyleBackColor = true;
            this.BTDetallar.Click += new System.EventHandler(this.BTDetallar_Click);
            // 
            // VerAlumnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 641);
            this.Controls.Add(this.BTDetallar);
            this.Controls.Add(this.DGVAlumno);
            this.Controls.Add(this.BtSalir);
            this.Name = "VerAlumnosForm";
            this.Sizable = false;
            this.Text = "VerAlumnosForm";
            this.Activated += new System.EventHandler(this.VerAlumnosForm_Activated);
            this.Load += new System.EventHandler(this.VerAlumnosForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton BtSalir;
        private System.Windows.Forms.DataGridView DGVAlumno;
        private MaterialSkin.Controls.MaterialRaisedButton BTDetallar;
    }
}