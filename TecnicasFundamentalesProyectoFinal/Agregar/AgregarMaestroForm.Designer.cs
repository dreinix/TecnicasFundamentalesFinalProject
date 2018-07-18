namespace TecnicasFundamentalesProyectoFinal.Agregar
{
    partial class AgregarMaestroForm
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
            this.LBID = new MaterialSkin.Controls.MaterialLabel();
            this.TxtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtExaminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PBImage = new System.Windows.Forms.PictureBox();
            LBNombre = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LBNombre
            // 
            LBNombre.AutoSize = true;
            LBNombre.Depth = 0;
            LBNombre.Font = new System.Drawing.Font("Roboto", 11F);
            LBNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            LBNombre.Location = new System.Drawing.Point(13, 145);
            LBNombre.MouseState = MaterialSkin.MouseState.HOVER;
            LBNombre.Name = "LBNombre";
            LBNombre.Size = new System.Drawing.Size(63, 19);
            LBNombre.TabIndex = 2;
            LBNombre.Text = "Nombre";
            // 
            // LBID
            // 
            this.LBID.AutoSize = true;
            this.LBID.Depth = 0;
            this.LBID.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBID.Location = new System.Drawing.Point(13, 70);
            this.LBID.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(83, 19);
            this.LBID.TabIndex = 0;
            this.LBID.Text = "ID Maestro";
            // 
            // TxtID
            // 
            this.TxtID.Depth = 0;
            this.TxtID.Hint = "";
            this.TxtID.Location = new System.Drawing.Point(17, 101);
            this.TxtID.MaxLength = 32767;
            this.TxtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtID.Name = "TxtID";
            this.TxtID.PasswordChar = '\0';
            this.TxtID.SelectedText = "";
            this.TxtID.SelectionLength = 0;
            this.TxtID.SelectionStart = 0;
            this.TxtID.Size = new System.Drawing.Size(205, 23);
            this.TxtID.TabIndex = 1;
            this.TxtID.TabStop = false;
            this.TxtID.UseSystemPasswordChar = false;
            this.TxtID.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Hint = "";
            this.TxtNombre.Location = new System.Drawing.Point(17, 176);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.Size = new System.Drawing.Size(205, 23);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.UseSystemPasswordChar = false;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            this.TxtNombre.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // BtGuardar
            // 
            this.BtGuardar.AutoSize = true;
            this.BtGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtGuardar.Depth = 0;
            this.BtGuardar.Icon = null;
            this.BtGuardar.Location = new System.Drawing.Point(12, 214);
            this.BtGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Primary = true;
            this.BtGuardar.Size = new System.Drawing.Size(84, 36);
            this.BtGuardar.TabIndex = 5;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(131, 214);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(91, 36);
            this.BtCancelar.TabIndex = 6;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtExaminar
            // 
            this.BtExaminar.AutoSize = true;
            this.BtExaminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtExaminar.Depth = 0;
            this.BtExaminar.Icon = null;
            this.BtExaminar.Location = new System.Drawing.Point(388, 201);
            this.BtExaminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtExaminar.Name = "BtExaminar";
            this.BtExaminar.Primary = true;
            this.BtExaminar.Size = new System.Drawing.Size(90, 36);
            this.BtExaminar.TabIndex = 7;
            this.BtExaminar.Text = "Examinar";
            this.BtExaminar.UseVisualStyleBackColor = true;
            this.BtExaminar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // PBImage
            // 
            this.PBImage.BackgroundImage = global::TecnicasFundamentalesProyectoFinal.Properties.Resources.intec;
            this.PBImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBImage.Image = global::TecnicasFundamentalesProyectoFinal.Properties.Resources.intec;
            this.PBImage.Location = new System.Drawing.Point(279, 70);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(199, 125);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 4;
            this.PBImage.TabStop = false;
            this.PBImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AgregarMaestroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 293);
            this.Controls.Add(this.BtExaminar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.PBImage);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(LBNombre);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LBID);
            this.Name = "AgregarMaestroForm";
            this.Text = "AgregarMateriasForm";
            this.Load += new System.EventHandler(this.AgregarMateriasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LBID;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtID;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombre;
        private System.Windows.Forms.PictureBox PBImage;
        private MaterialSkin.Controls.MaterialRaisedButton BtGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton BtExaminar;
    }
}