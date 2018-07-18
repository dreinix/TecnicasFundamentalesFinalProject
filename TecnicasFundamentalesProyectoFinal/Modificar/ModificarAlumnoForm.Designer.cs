namespace TecnicasFundamentalesProyectoFinal.Modificar
{
    partial class ModificarAlumnoForm
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
            this.LbBuscar = new MaterialSkin.Controls.MaterialLabel();
            this.TxtFiltrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DGVAlumnos = new System.Windows.Forms.DataGridView();
            this.BtEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BTExaminar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSalir
            // 
            this.BtSalir.AutoSize = true;
            this.BtSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtSalir.Depth = 0;
            this.BtSalir.Icon = null;
            this.BtSalir.Location = new System.Drawing.Point(1519, 680);
            this.BtSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Primary = true;
            this.BtSalir.Size = new System.Drawing.Size(58, 36);
            this.BtSalir.TabIndex = 18;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.Depth = 0;
            this.LbBuscar.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbBuscar.Location = new System.Drawing.Point(12, 83);
            this.LbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(134, 19);
            this.LbBuscar.TabIndex = 17;
            this.LbBuscar.Text = "Elemento a buscar";
            // 
            // TxtFiltrar
            // 
            this.TxtFiltrar.Depth = 0;
            this.TxtFiltrar.Hint = "";
            this.TxtFiltrar.Location = new System.Drawing.Point(12, 117);
            this.TxtFiltrar.MaxLength = 32767;
            this.TxtFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFiltrar.Name = "TxtFiltrar";
            this.TxtFiltrar.PasswordChar = '\0';
            this.TxtFiltrar.SelectedText = "";
            this.TxtFiltrar.SelectionLength = 0;
            this.TxtFiltrar.SelectionStart = 0;
            this.TxtFiltrar.Size = new System.Drawing.Size(203, 23);
            this.TxtFiltrar.TabIndex = 16;
            this.TxtFiltrar.TabStop = false;
            this.TxtFiltrar.UseSystemPasswordChar = false;
            this.TxtFiltrar.Click += new System.EventHandler(this.TxtFiltrar_Click);
            this.TxtFiltrar.TextChanged += new System.EventHandler(this.TxtFiltrar_TextChanged);
            // 
            // DGVAlumnos
            // 
            this.DGVAlumnos.AllowUserToAddRows = false;
            this.DGVAlumnos.AllowUserToDeleteRows = false;
            this.DGVAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlumnos.Location = new System.Drawing.Point(12, 156);
            this.DGVAlumnos.Name = "DGVAlumnos";
            this.DGVAlumnos.Size = new System.Drawing.Size(1565, 507);
            this.DGVAlumnos.TabIndex = 15;
            this.DGVAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAlumnos_CellContentClick);
            // 
            // BtEditar
            // 
            this.BtEditar.AutoSize = true;
            this.BtEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtEditar.Depth = 0;
            this.BtEditar.Icon = null;
            this.BtEditar.Location = new System.Drawing.Point(1598, 198);
            this.BtEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Primary = true;
            this.BtEditar.Size = new System.Drawing.Size(68, 36);
            this.BtEditar.TabIndex = 19;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BTExaminar
            // 
            this.BTExaminar.AutoSize = true;
            this.BTExaminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTExaminar.Depth = 0;
            this.BTExaminar.Icon = null;
            this.BTExaminar.Location = new System.Drawing.Point(1598, 156);
            this.BTExaminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTExaminar.Name = "BTExaminar";
            this.BTExaminar.Primary = true;
            this.BTExaminar.Size = new System.Drawing.Size(145, 36);
            this.BTExaminar.TabIndex = 20;
            this.BTExaminar.Text = "Examinar Imagen";
            this.BTExaminar.UseVisualStyleBackColor = true;
            this.BTExaminar.Click += new System.EventHandler(this.BTExaminar_Click);
            // 
            // ModificarAlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 875);
            this.Controls.Add(this.BTExaminar);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.LbBuscar);
            this.Controls.Add(this.TxtFiltrar);
            this.Controls.Add(this.DGVAlumnos);
            this.Name = "ModificarAlumnoForm";
            this.Text = "ModificarAlumnosForm";
            this.Load += new System.EventHandler(this.ModificarAlumnosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtSalir;
        private MaterialSkin.Controls.MaterialLabel LbBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFiltrar;
        private System.Windows.Forms.DataGridView DGVAlumnos;
        private MaterialSkin.Controls.MaterialRaisedButton BtEditar;
        private MaterialSkin.Controls.MaterialRaisedButton BTExaminar;
    }
}