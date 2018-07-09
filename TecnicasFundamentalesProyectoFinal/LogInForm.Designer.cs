namespace TecnicasFundamentalesProyectoFinal
{
    partial class LogInForm
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
            this.BtInisiarSesion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbPassword = new MaterialSkin.Controls.MaterialLabel();
            this.BtRegistrarUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // BtInisiarSesion
            // 
            this.BtInisiarSesion.AutoSize = true;
            this.BtInisiarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtInisiarSesion.Depth = 0;
            this.BtInisiarSesion.Icon = null;
            this.BtInisiarSesion.Location = new System.Drawing.Point(12, 235);
            this.BtInisiarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtInisiarSesion.Name = "BtInisiarSesion";
            this.BtInisiarSesion.Primary = true;
            this.BtInisiarSesion.Size = new System.Drawing.Size(120, 36);
            this.BtInisiarSesion.TabIndex = 0;
            this.BtInisiarSesion.Text = "Iniciar sesión";
            this.BtInisiarSesion.UseVisualStyleBackColor = true;
            this.BtInisiarSesion.Click += new System.EventHandler(this.BtInisiarSesion_Click);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Depth = 0;
            this.TxtUserName.Hint = "";
            this.TxtUserName.Location = new System.Drawing.Point(12, 119);
            this.TxtUserName.MaxLength = 32767;
            this.TxtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.SelectionLength = 0;
            this.TxtUserName.SelectionStart = 0;
            this.TxtUserName.Size = new System.Drawing.Size(206, 23);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.TabStop = false;
            this.TxtUserName.UseSystemPasswordChar = false;
            this.TxtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserName_KeyPress);
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Depth = 0;
            this.LbUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbUsuario.Location = new System.Drawing.Point(12, 88);
            this.LbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(61, 19);
            this.LbUsuario.TabIndex = 3;
            this.LbUsuario.Text = "Usuario";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "";
            this.TxtPassword.Location = new System.Drawing.Point(12, 190);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(206, 23);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Depth = 0;
            this.LbPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbPassword.Location = new System.Drawing.Point(12, 158);
            this.LbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(86, 19);
            this.LbPassword.TabIndex = 5;
            this.LbPassword.Text = "Contraseña";
            // 
            // BtRegistrarUsuario
            // 
            this.BtRegistrarUsuario.AutoSize = true;
            this.BtRegistrarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtRegistrarUsuario.Depth = 0;
            this.BtRegistrarUsuario.Icon = null;
            this.BtRegistrarUsuario.Location = new System.Drawing.Point(160, 235);
            this.BtRegistrarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtRegistrarUsuario.Name = "BtRegistrarUsuario";
            this.BtRegistrarUsuario.Primary = true;
            this.BtRegistrarUsuario.Size = new System.Drawing.Size(109, 36);
            this.BtRegistrarUsuario.TabIndex = 6;
            this.BtRegistrarUsuario.Text = "Registrarse";
            this.BtRegistrarUsuario.UseVisualStyleBackColor = true;
            this.BtRegistrarUsuario.Click += new System.EventHandler(this.BtRegistrarUsuario_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(340, 298);
            this.Controls.Add(this.BtRegistrarUsuario);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.BtInisiarSesion);
            this.Name = "LogIn";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtInisiarSesion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUserName;
        private MaterialSkin.Controls.MaterialLabel LbUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton BtRegistrarUsuario;
        private MaterialSkin.Controls.MaterialLabel LbPassword;
    }
}

