using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace Presentacion.Alumnos
{
    public partial class Create : System.Web.UI.Page
    {
        NAlumno nAlumno = new NAlumno();
        NEstado nEstado = new NEstado();
        NEstatus nStatus = new NEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Estado> listEstado = nEstado.Consultar();
                List<EstatusAlum> listEstatus = nStatus.Consultar();
                ddlEstado.DataSource = listEstado;
                ddlEstado.DataTextField = "NombreEstado";
                ddlEstado.DataValueField = "IdEstado";
                ddlEstado.DataBind();

                ddlEstatus.DataSource = listEstatus;
                ddlEstatus.DataTextField = "nombreEstatus";
                ddlEstatus.DataValueField = "IdEstatus";
                ddlEstatus.DataBind();

            }
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idEstado = Convert.ToInt32(ddlEstado.SelectedValue);
            var idEstatus = Convert.ToInt32(ddlEstatus.SelectedValue);

            Alumno alumno = new Alumno
            {
                Nombre = txtNombre.Text,
                primerApellido = txtPApellido.Text,
                segunndoApellido = txtSApelllido.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                fechaNacimiento = Convert.ToDateTime(txtFNacimiento.Text),
                Curp = txtCurp.Text,
                sueldo = 0.0m,
                idEstado = idEstado,
                idEstatus = idEstatus
            };
            nAlumno.Agregar(alumno);
            Response.Redirect("Index.aspx");
        }
    }
}