namespace TecnicasFundamentalesProyectoFinal.Eliminar
{
    partial class EliminarRegistroForm
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
            this.BtCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LVUsuarios = new System.Windows.Forms.ListView();
            this.LbUserFounds = new MaterialSkin.Controls.MaterialLabel();
            this.BtEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbUserName = new MaterialSkin.Controls.MaterialLabel();
            this.TxtMateria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSize = true;
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(127, 239);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Primary = true;
            this.BtCancelar.Size = new System.Drawing.Size(91, 36);
            this.BtCancelar.TabIndex = 24;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // LVUsuarios
            // 
            this.LVUsuarios.Location = new System.Drawing.Point(11, 195);
            this.LVUsuarios.Name = "LVUsuarios";
            this.LVUsuarios.Size = new System.Drawing.Size(99, 232);
            this.LVUsuarios.TabIndex = 23;
            this.LVUsuarios.UseCompatibleStateImageBehavior = false;
            // 
            // LbUserFounds
            // 
            this.LbUserFounds.AutoSize = true;
            this.LbUserFounds.Depth = 0;
            this.LbUserFounds.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbUserFounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbUserFounds.Location = new System.Drawing.Point(12, 162);
            this.LbUserFounds.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbUserFounds.Name = "LbUserFounds";
            this.LbUserFounds.Size = new System.Drawing.Size(162, 19);
            this.LbUserFounds.TabIndex = 22;
            this.LbUserFounds.Text = "Registros Encontrados";
            // 
            // BtEliminar
            // 
            this.BtEliminar.AutoSize = true;
            this.BtEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtEliminar.Depth = 0;
            this.BtEliminar.Icon = null;
            this.BtEliminar.Location = new System.Drawing.Point(127, 195);
            this.BtEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Primary = true;
            this.BtEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtEliminar.TabIndex = 21;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Depth = 0;
            this.TxtUserName.Hint = "";
            this.TxtUserName.Location = new System.Drawing.Point(11, 117);
            this.TxtUserName.MaxLength = 32767;
            this.TxtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.SelectionLength = 0;
            this.TxtUserName.SelectionStart = 0;
            this.TxtUserName.Size = new System.Drawing.Size(132, 23);
            this.TxtUserName.TabIndex = 20;
            this.TxtUserName.TabStop = false;
            this.TxtUserName.UseSystemPasswordChar = false;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Depth = 0;
            this.LbUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbUserName.Location = new System.Drawing.Point(12, 81);
            this.LbUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(141, 19);
            this.LbUserName.TabIndex = 19;
            this.LbUserName.Text = "Estudiante a buscar";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Depth = 0;
            this.TxtMateria.Hint = "";
            this.TxtMateria.Location = new System.Drawing.Point(185, 117);
            this.TxtMateria.MaxLength = 32767;
            this.TxtMateria.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.PasswordChar = '\0';
            this.TxtMateria.SelectedText = "";
            this.TxtMateria.SelectionLength = 0;
            this.TxtMateria.SelectionStart = 0;
            this.TxtMateria.Size = new System.Drawing.Size(132, 23);
            this.TxtMateria.TabIndex = 26;
            this.TxtMateria.TabStop = false;
            this.TxtMateria.UseSystemPasswordChar = false;
            this.TxtMateria.TextChanged += new System.EventHandler(this.TxtMateria_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(186, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Materia a buscar";
            // 
            // EliminarRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.LVUsuarios);
            this.Controls.Add(this.LbUserFounds);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LbUserName);
            this.Name = "EliminarRegistroForm";
            this.Text = "EliminarRegistroForm";
            this.Load += new System.EventHandler(this.EliminarRegistroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtCancelar;
        private System.Windows.Forms.ListView LVUsuarios;
        private MaterialSkin.Controls.MaterialLabel LbUserFounds;
        private MaterialSkin.Controls.MaterialRaisedButton BtEliminar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUserName;
        private MaterialSkin.Controls.MaterialLabel LbUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtMateria;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}