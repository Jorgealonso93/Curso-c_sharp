using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusWF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ADOEstatus ado = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Estatus> estatusList = new List<Estatus>();
                estatusList = ado.Consultar();
                ddlEstatus.DataSource = estatusList;
                ddlEstatus.DataTextField = "nombre";
                ddlEstatus.DataValueField = "id";
                ddlEstatus.DataBind();
            }
            
        }

        protected void ddlEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string url = "Create.aspx";
            Response.Redirect(url);
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            string url = $"Details.aspx?id={id}";
            Response.Redirect(url,true);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            string url = $"Delete.aspx?id={id}";
            Response.Redirect(url, true);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            string url = $"Edit.aspx?id={id}";
            Response.Redirect(url, true);
        }
    }
}