namespace TecnicasFundamentalesProyectoFinal
{
    partial class VerMaestrosForm
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
            this.DGVMaetro = new System.Windows.Forms.DataGridView();
            this.BtSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BTDetallar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaetro)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMaetro
            // 
            this.DGVMaetro.AllowUserToAddRows = false;
            this.DGVMaetro.AllowUserToDeleteRows = false;
            this.DGVMaetro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMaetro.Location = new System.Drawing.Point(12, 70);
            this.DGVMaetro.Name = "DGVMaetro";
            this.DGVMaetro.ReadOnly = true;
            this.DGVMaetro.Size = new System.Drawing.Size(1565, 507);
            this.DGVMaetro.TabIndex = 3;
            // 
            // BtSalir
            // 
            this.BtSalir.AutoSize = true;
            this.BtSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtSalir.Depth = 0;
            this.BtSalir.Icon = null;
            this.BtSalir.Location = new System.Drawing.Point(1519, 586);
            this.BtSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Primary = true;
            this.BtSalir.Size = new System.Drawing.Size(58, 36);
            this.BtSalir.TabIndex = 4;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BTDetallar
            // 
            this.BTDetallar.AutoSize = true;
            this.BTDetallar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTDetallar.Depth = 0;
            this.BTDetallar.Icon = null;
            this.BTDetallar.Location = new System.Drawing.Point(1583, 70);
            this.BTDetallar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTDetallar.Name = "BTDetallar";
            this.BTDetallar.Primary = true;
            this.BTDetallar.Size = new System.Drawing.Size(88, 36);
            this.BTDetallar.TabIndex = 5;
            this.BTDetallar.Text = "Detallar";
            this.BTDetallar.UseVisualStyleBackColor = true;
            this.BTDetallar.Click += new System.EventHandler(this.BTDetallar_Click);
            // 
            // VerMaestrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 634);
            this.Controls.Add(this.BTDetallar);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.DGVMaetro);
            this.Name = "VerMaestrosForm";
            this.Text = "VerMaestrosForm";
            this.Load += new System.EventHandler(this.VerMaestrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaetro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMaetro;
        private MaterialSkin.Controls.MaterialRaisedButton BtSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BTDetallar;
    }
}