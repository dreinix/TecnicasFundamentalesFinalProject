namespace TecnicasFundamentalesProyectoFinal.Agregar
{
    partial class AgregarRegistroForm
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
            this.LBAlumn = new MaterialSkin.Controls.MaterialLabel();
            this.LBClave = new MaterialSkin.Controls.MaterialLabel();
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtVincular = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // LBAlumn
            // 
            this.LBAlumn.AutoSize = true;
            this.LBAlumn.Depth = 0;
            this.LBAlumn.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBAlumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBAlumn.Location = new System.Drawing.Point(12, 77);
            this.LBAlumn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBAlumn.Name = "LBAlumn";
            this.LBAlumn.Size = new System.Drawing.Size(79, 19);
            this.LBAlumn.TabIndex = 2;
            this.LBAlumn.Text = "ID Alumno";
            // 
            // LBClave
            // 
            this.LBClave.AutoSize = true;
            this.LBClave.Depth = 0;
            this.LBClave.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBClave.Location = new System.Drawing.Point(12, 137);
            this.LBClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBClave.Name = "LBClave";
            this.LBClave.Size = new System.Drawing.Size(101, 19);
            this.LBClave.TabIndex = 3;
            this.LBClave.Text = "Clave materia";
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(154, 144);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(91, 36);
            this.BtCancelar.TabIndex = 15;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtVincular
            // 
            this.BtVincular.AutoSize = true;
            this.BtVincular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtVincular.Depth = 0;
            this.BtVincular.Icon = null;
            this.BtVincular.Location = new System.Drawing.Point(154, 90);
            this.BtVincular.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtVincular.Name = "BtVincular";
            this.BtVincular.Primary = true;
            this.BtVincular.Size = new System.Drawing.Size(87, 36);
            this.BtVincular.TabIndex = 14;
            this.BtVincular.Text = "Vincular";
            this.BtVincular.UseVisualStyleBackColor = true;
            this.BtVincular.Click += new System.EventHandler(this.BtVincular_Click);
            // 
            // TxtID
            // 
            this.TxtID.Depth = 0;
            this.TxtID.Hint = "";
            this.TxtID.Location = new System.Drawing.Point(16, 102);
            this.TxtID.MaxLength = 32767;
            this.TxtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtID.Name = "TxtID";
            this.TxtID.PasswordChar = '\0';
            this.TxtID.SelectedText = "";
            this.TxtID.SelectionLength = 0;
            this.TxtID.SelectionStart = 0;
            this.TxtID.Size = new System.Drawing.Size(112, 23);
            this.TxtID.TabIndex = 16;
            this.TxtID.TabStop = false;
            this.TxtID.UseSystemPasswordChar = false;
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // TxtClave
            // 
            this.TxtClave.Depth = 0;
            this.TxtClave.Hint = "";
            this.TxtClave.Location = new System.Drawing.Point(16, 156);
            this.TxtClave.MaxLength = 32767;
            this.TxtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '\0';
            this.TxtClave.SelectedText = "";
            this.TxtClave.SelectionLength = 0;
            this.TxtClave.SelectionStart = 0;
            this.TxtClave.Size = new System.Drawing.Size(112, 23);
            this.TxtClave.TabIndex = 17;
            this.TxtClave.TabStop = false;
            this.TxtClave.UseSystemPasswordChar = false;
            // 
            // AgregarRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 213);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtVincular);
            this.Controls.Add(this.LBClave);
            this.Controls.Add(this.LBAlumn);
            this.Name = "AgregarRegistroForm";
            this.Text = "AgregarRegistro";
            this.Load += new System.EventHandler(this.AgregarRegistroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LBAlumn;
        private MaterialSkin.Controls.MaterialLabel LBClave;
        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton BtVincular;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtID;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtClave;
    }
}