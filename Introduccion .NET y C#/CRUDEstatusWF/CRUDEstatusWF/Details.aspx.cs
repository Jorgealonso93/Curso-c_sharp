using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusWF
{
    public partial class Details : System.Web.UI.Page
    {
        ADOEstatus ado = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id= Convert.ToInt32( Request.QueryString["id"]);
            Estatus item= ado.Consultar(id);
            txtIdDet.Text=Request.QueryString["id"];
            txtClaveDet.Text = item.clave;
            txtNomDet.Text = item.nombre;
        }
    }
}