namespace TecnicasFundamentalesProyectoFinal.Ver
{
    partial class VerDetallesMaestro
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
            MaterialSkin.Controls.MaterialLabel LBNombre;
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.TxtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LBID = new MaterialSkin.Controls.MaterialLabel();
            LBNombre = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(386, 256);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(58, 36);
            this.BtCancelar.TabIndex = 14;
            this.BtCancelar.Text = "Salir";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // PBImage
            // 
            this.PBImage.BackgroundImage = global::TecnicasFundamentalesProyectoFinal.Properties.Resources.intec;
            this.PBImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBImage.Image = global::TecnicasFundamentalesProyectoFinal.Properties.Resources.intec;
            this.PBImage.Location = new System.Drawing.Point(278, 81);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(199, 125);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 12;
            this.PBImage.TabStop = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Hint = "";
            this.TxtNombre.Location = new System.Drawing.Point(16, 187);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.Size = new System.Drawing.Size(205, 23);
            this.TxtNombre.TabIndex = 11;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.UseSystemPasswordChar = false;
            // 
            // LBNombre
            // 
            LBNombre.AutoSize = true;
            LBNombre.Depth = 0;
            LBNombre.Font = new System.Drawing.Font("Roboto", 11F);
            LBNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            LBNombre.Location = new System.Drawing.Point(12, 156);
            LBNombre.MouseState = MaterialSkin.MouseState.HOVER;
            LBNombre.Name = "LBNombre";
            LBNombre.Size = new System.Drawing.Size(63, 19);
            LBNombre.TabIndex = 10;
            LBNombre.Text = "Nombre";
            // 
            // TxtID
            // 
            this.TxtID.Depth = 0;
            this.TxtID.Enabled = false;
            this.TxtID.Hint = "";
            this.TxtID.Location = new System.Drawing.Point(16, 112);
            this.TxtID.MaxLength = 32767;
            this.TxtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtID.Name = "TxtID";
            this.TxtID.PasswordChar = '\0';
            this.TxtID.SelectedText = "";
            this.TxtID.SelectionLength = 0;
            this.TxtID.SelectionStart = 0;
            this.TxtID.Size = new System.Drawing.Size(205, 23);
            this.TxtID.TabIndex = 9;
            this.TxtID.TabStop = false;
            this.TxtID.UseSystemPasswordChar = false;
            // 
            // LBID
            // 
            this.LBID.AutoSize = true;
            this.LBID.Depth = 0;
            this.LBID.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBID.Location = new System.Drawing.Point(12, 81);
            this.LBID.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(83, 19);
            this.LBID.TabIndex = 8;
            this.LBID.Text = "ID Maestro";
            // 
            // VerDetallesMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 304);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.PBImage);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(LBNombre);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LBID);
            this.Name = "VerDetallesMaestro";
            this.Text = "VerDetallesMaestro";
            this.Load += new System.EventHandler(this.VerDetallesMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
        private System.Windows.Forms.PictureBox PBImage;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtID;
        private MaterialSkin.Controls.MaterialLabel LBID;
    }
}