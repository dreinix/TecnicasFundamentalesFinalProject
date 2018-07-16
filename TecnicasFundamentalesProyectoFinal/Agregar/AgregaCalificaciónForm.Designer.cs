namespace TecnicasFundamentalesProyectoFinal.Agregar
{
    partial class AgregaCalificaciónForm
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
            this.DGVREgistro = new System.Windows.Forms.DataGridView();
            this.LbBuscar = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.DGVREgistro)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVREgistro
            // 
            this.DGVREgistro.AllowUserToAddRows = false;
            this.DGVREgistro.AllowUserToDeleteRows = false;
            this.DGVREgistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVREgistro.Location = new System.Drawing.Point(13, 131);
            this.DGVREgistro.Name = "DGVREgistro";
            this.DGVREgistro.Size = new System.Drawing.Size(1355, 503);
            this.DGVREgistro.TabIndex = 0;
            this.DGVREgistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVREgistro_CellContentClick);
            this.DGVREgistro.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVREgistro_CellEndEdit);
            this.DGVREgistro.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVREgistro_CellEnter);
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.Depth = 0;
            this.LbBuscar.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbBuscar.Location = new System.Drawing.Point(12, 70);
            this.LbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(98, 19);
            this.LbBuscar.TabIndex = 15;
            this.LbBuscar.Text = "ID Estudiante";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Depth = 0;
            this.TxtBuscar.Hint = "";
            this.TxtBuscar.Location = new System.Drawing.Point(12, 104);
            this.TxtBuscar.MaxLength = 32767;
            this.TxtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.Size = new System.Drawing.Size(203, 23);
            this.TxtBuscar.TabIndex = 14;
            this.TxtBuscar.TabStop = false;
            this.TxtBuscar.UseSystemPasswordChar = false;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // AgregaCalificaciónForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 646);
            this.Controls.Add(this.LbBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DGVREgistro);
            this.Name = "AgregaCalificaciónForm";
            this.Text = "AgregaCalificaciónForm";
            this.Load += new System.EventHandler(this.AgregaCalificaciónForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVREgistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVREgistro;
        private MaterialSkin.Controls.MaterialLabel LbBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscar;
    }
}