namespace TecnicasFundamentalesProyectoFinal.Modificar
{
    partial class BTActualizar
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
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.Depth = 0;
            this.LbBuscar.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbBuscar.Location = new System.Drawing.Point(12, 76);
            this.LbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(61, 19);
            this.LbBuscar.TabIndex = 21;
            this.LbBuscar.Text = "Usuario";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Depth = 0;
            this.TxtBuscar.Hint = "";
            this.TxtBuscar.Location = new System.Drawing.Point(12, 98);
            this.TxtBuscar.MaxLength = 32767;
            this.TxtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.Size = new System.Drawing.Size(203, 23);
            this.TxtBuscar.TabIndex = 20;
            this.TxtBuscar.TabStop = false;
            this.TxtBuscar.UseSystemPasswordChar = false;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AllowUserToAddRows = false;
            this.DGVUsuarios.AllowUserToDeleteRows = false;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Location = new System.Drawing.Point(12, 127);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.Size = new System.Drawing.Size(700, 254);
            this.DGVUsuarios.TabIndex = 19;
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(621, 402);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(91, 36);
            this.BtCancelar.TabIndex = 22;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.AutoSize = true;
            this.BtUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtUpdate.Depth = 0;
            this.BtUpdate.Icon = null;
            this.BtUpdate.Location = new System.Drawing.Point(718, 127);
            this.BtUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Primary = true;
            this.BtUpdate.Size = new System.Drawing.Size(103, 36);
            this.BtUpdate.TabIndex = 23;
            this.BtUpdate.Text = "Actualizar";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // BTActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.LbBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DGVUsuarios);
            this.Name = "BTActualizar";
            this.Text = "ModificarUsuariosForm";
            this.Load += new System.EventHandler(this.ModificarUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LbBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscar;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton BtUpdate;
    }
}