using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estatus edo = new Estatus();
            string nombre = txtNombre.Text;
            nombre = "Reyna";
            string id = cmbEstatus.SelectedValue.ToString();
            txtNombre.Text = nombre;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            List<Estatus> listEstatus = new List<Estatus>
            {
                new Estatus { id = 1, clave = "U", nombre = "Uno" },
                new Estatus { id = 2, clave = "D", nombre = "Dos" },
                new Estatus { id = 3, clave = "T", nombre = "Tres" },
                new Estatus { id = 4, clave = "C", nombre = "Cuatro" }
            };
            cmbEstatus.DataSource = listEstatus;
            cmbEstatus.DisplayMember = "nombre";
            cmbEstatus.ValueMember = "id";
        }
    }
}
