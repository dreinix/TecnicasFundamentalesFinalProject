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
    public partial class VerDetallesMaestro : Material
    {
        public VerDetallesMaestro(string nombre,string id,Image photo)
        {
            InitializeComponent();
            TxtID.Text = id;
            TxtNombre.Text = nombre;
            PBImage.Image = photo;
           
        }

        private void VerDetallesMaestro_Load(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
