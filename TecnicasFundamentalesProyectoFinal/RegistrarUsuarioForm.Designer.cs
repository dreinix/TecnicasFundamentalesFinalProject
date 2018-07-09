namespace TecnicasFundamentalesProyectoFinal
{
    partial class RegistrarUsuarioForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LbUserName = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbPass = new MaterialSkin.Controls.MaterialLabel();
            this.BtRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LbCat = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.CBCat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 71);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 0;
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Depth = 0;
            this.LbUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbUserName.Location = new System.Drawing.Point(12, 71);
            this.LbUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(139, 19);
            this.LbUserName.TabIndex = 1;
            this.LbUserName.Text = "Nombre de Usuario";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Depth = 0;
            this.TxtUserName.Hint = "";
            this.TxtUserName.Location = new System.Drawing.Point(12, 106);
            this.TxtUserName.MaxLength = 32767;
            this.TxtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.SelectionLength = 0;
            this.TxtUserName.SelectionStart = 0;
            this.TxtUserName.Size = new System.Drawing.Size(202, 23);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.TabStop = false;
            this.TxtUserName.UseSystemPasswordChar = false;
            // 
            // TxtPass
            // 
            this.TxtPass.Depth = 0;
            this.TxtPass.Hint = "";
            this.TxtPass.Location = new System.Drawing.Point(13, 180);
            this.TxtPass.MaxLength = 32767;
            this.TxtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '\0';
            this.TxtPass.SelectedText = "";
            this.TxtPass.SelectionLength = 0;
            this.TxtPass.SelectionStart = 0;
            this.TxtPass.Size = new System.Drawing.Size(202, 23);
            this.TxtPass.TabIndex = 4;
            this.TxtPass.TabStop = false;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // LbPass
            // 
            this.LbPass.AutoSize = true;
            this.LbPass.Depth = 0;
            this.LbPass.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbPass.Location = new System.Drawing.Point(13, 145);
            this.LbPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbPass.Name = "LbPass";
            this.LbPass.Size = new System.Drawing.Size(86, 19);
            this.LbPass.TabIndex = 3;
            this.LbPass.Text = "Contraseña";
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.AutoSize = true;
            this.BtRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtRegistrar.Depth = 0;
            this.BtRegistrar.Icon = null;
            this.BtRegistrar.Location = new System.Drawing.Point(12, 233);
            this.BtRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Primary = true;
            this.BtRegistrar.Size = new System.Drawing.Size(109, 36);
            this.BtRegistrar.TabIndex = 5;
            this.BtRegistrar.Text = "Registrarse";
            this.BtRegistrar.UseVisualStyleBackColor = true;
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(146, 233);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(91, 36);
            this.BtCancelar.TabIndex = 6;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // LbCat
            // 
            this.LbCat.AutoSize = true;
            this.LbCat.Depth = 0;
            this.LbCat.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCat.Location = new System.Drawing.Point(253, 71);
            this.LbCat.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbCat.Name = "LbCat";
            this.LbCat.Size = new System.Drawing.Size(74, 19);
            this.LbCat.TabIndex = 8;
            this.LbCat.Text = "Categoria";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(254, 71);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 19);
            this.materialLabel3.TabIndex = 7;
            // 
            // CBCat
            // 
            this.CBCat.FormattingEnabled = true;
            this.CBCat.Items.AddRange(new object[] {
            "Adm",
            "Develop",
            "User"});
            this.CBCat.Location = new System.Drawing.Point(257, 106);
            this.CBCat.Name = "CBCat";
            this.CBCat.Size = new System.Drawing.Size(121, 21);
            this.CBCat.TabIndex = 9;
            this.CBCat.Text = "User";
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 313);
            this.ControlBox = false;
            this.Controls.Add(this.CBCat);
            this.Controls.Add(this.LbCat);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtRegistrar);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.LbPass);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LbUserName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "RegistrarUsuario";
            this.Sizable = false;
            this.Text = "RegistrarUsuario";
            this.Load += new System.EventHandler(this.MaterialLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LbUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPass;
        private MaterialSkin.Controls.MaterialLabel LbPass;
        private MaterialSkin.Controls.MaterialRaisedButton BtRegistrar;
        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
        private MaterialSkin.Controls.MaterialLabel LbCat;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox CBCat;
    }
}