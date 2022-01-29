using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEstatusAlumnos
{
    public partial class CrudEstatus : Form
    {
        ADOEstatus ado = new ADOEstatus();
        List<Estatus> listEstatus = new List<Estatus>();
        public CrudEstatus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            listEstatus = ado.Consultar();
            cmbEstatus.DataSource = listEstatus;
            cmbEstatus.DisplayMember = "nombre";
            cmbEstatus.ValueMember = "id";

            dgvEstatus.DataSource = listEstatus;
            panel1.Visible=false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnModificar.Enabled= false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Enabled == false)
            {
                string nommbre = txtNombre.Text;
                string clave = txtAbreviatura.Text;
                Estatus estatus = new Estatus { clave = clave, nombre = nommbre };
                ado.Agregar(estatus);
                txtAbreviatura.Clear();
                txtNombre.Clear();
                panel1.Visible = false;
                btnModificar.Enabled = true;
                MessageBox.Show("Registro Agregado Exitosamente.");
            }
            else if(btnModificar.Enabled == true)
            {
                string nom = txtNombre.Text;
                string abrev = txtAbreviatura.Text;
                var idN = (Int32)cmbEstatus.SelectedValue;
                Estatus Nestatus = new Estatus { id = idN, nombre= nom, clave= abrev };
                ado.Actualizar(Nestatus);
                MessageBox.Show("Registro Actualizado Exitosamente.");
                txtAbreviatura.Clear();
                txtNombre.Clear();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            panel1.Visible = true;
            var id =(Int32) cmbEstatus.SelectedValue;
            Estatus item = ado.Consultar(id);
            txtNombre.Text = item.nombre;
            txtAbreviatura.Text = item.clave;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = (Int32)cmbEstatus.SelectedValue;
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ado.Eliminar(id);
                MessageBox.Show("Registro eliminado Exitosamente.");

                listEstatus = ado.Consultar();
                cmbEstatus.DataSource = listEstatus;
                //cmbEstatus.DisplayMember = "nombre";
                //cmbEstatus.ValueMember = "id";

                //dgvEstatus.DataSource = listEstatus;
                //panel1.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

    
    }
}
