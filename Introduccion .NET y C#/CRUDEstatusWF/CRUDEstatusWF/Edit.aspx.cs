using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusWF
{
    public partial class Edit : System.Web.UI.Page
    {
        ADOEstatus ado = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Estatus item = ado.Consultar(id);
                txtIdAct.Text = Request.QueryString["id"];
                txtNomAct.Text = item.nombre;
                txtClaAct.Text = item.clave;
            }
            
        }

        protected void btnAct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string nom = txtNomAct.Text;
            string clav= txtClaAct.Text;
            Estatus Nestatus = new Estatus { id = id, nombre = nom, clave = clav};
            ado.Actualizar(Nestatus);
        }
    }
}