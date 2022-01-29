using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusWF
{
    public partial class Delete : System.Web.UI.Page
    {
        ADOEstatus ado = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Estatus item = ado.Consultar(id);
                txtIdElim.Text = Request.QueryString["id"];
                txtNomelim.Text = item.nombre;
                txtClaElim.Text = item.clave;
            }
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ado.Eliminar(id);
        }
    }
}