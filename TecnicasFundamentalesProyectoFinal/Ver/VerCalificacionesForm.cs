using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal
{
    public partial class VerCalificacionesForm : Material
    {
        public VerCalificacionesForm()
        {
            InitializeComponent();
        }
        private void VerCalificacionesForm_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            BindingSource CalSource = new BindingSource();
            CalSource.DataSource = DBControl.ObtenerTabla("Select * from Calificaciones");
            DGVCalificacion.DataSource = CalSource;
            DGVCalificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCalificacion.ReadOnly = true;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
