namespace TecnicasFundamentalesProyectoFinal
{
    partial class VerCalificacionesForm
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
            this.DGVCalificacion = new System.Windows.Forms.DataGridView();
            this.LBUser = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSalir
            // 
            this.BtSalir.AutoSize = true;
            this.BtSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtSalir.Depth = 0;
            this.BtSalir.Icon = null;
            this.BtSalir.Location = new System.Drawing.Point(1519, 658);
            this.BtSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Primary = true;
            this.BtSalir.Size = new System.Drawing.Size(58, 36);
            this.BtSalir.TabIndex = 8;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // DGVCalificacion
            // 
            this.DGVCalificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCalificacion.Location = new System.Drawing.Point(12, 142);
            this.DGVCalificacion.Name = "DGVCalificacion";
            this.DGVCalificacion.Size = new System.Drawing.Size(1565, 507);
            this.DGVCalificacion.TabIndex = 7;
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.Depth = 0;
            this.LBUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBUser.Location = new System.Drawing.Point(8, 98);
            this.LBUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(108, 19);
            this.LBUser.TabIndex = 9;
            this.LBUser.Text = "materialLabel1";
            // 
            // VerCalificacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 700);
            this.Controls.Add(this.LBUser);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.DGVCalificacion);
            this.Name = "VerCalificacionesForm";
            this.Text = "VerCalificacionesForm";
            this.Load += new System.EventHandler(this.VerCalificacionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtSalir;
        private System.Windows.Forms.DataGridView DGVCalificacion;
        private MaterialSkin.Controls.MaterialLabel LBUser;
    }
}