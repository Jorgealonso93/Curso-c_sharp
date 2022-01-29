using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusWF
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ADOEstatus ado = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string clave = txtClave.Text;
            Estatus estatus = new Estatus
            {
                nombre = nombre,
                clave = clave
            };
            ado.Agregar(estatus);
            txtNombre.Text= String.Empty;
            txtClave.Text = String.Empty;
        }
    }
}