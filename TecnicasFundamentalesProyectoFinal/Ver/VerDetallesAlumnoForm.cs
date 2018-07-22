using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal.Ver
{
    public partial class VerDetallesAlumnoForm : Material
    {
        public VerDetallesAlumnoForm(string nombre,string apellido,string estado,string fecha,string carrera,string identificador,Image photo,string indice,string honor)
        {
            InitializeComponent();
            TxtApellido.Text = apellido;
            TxtCarrera.Text = carrera;
            TxtEstado.Text = estado;
            TxtIdentificadorNacial.Text = identificador;
            TxtNombre.Text = nombre;
            MTBFecha.Text = fecha;
            PBImage.Image = photo;
            LbHonor.Text = honor;
            LbIndice.Text = indice;
        }

        private void VerDetallesAlumnoForm_Load(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
