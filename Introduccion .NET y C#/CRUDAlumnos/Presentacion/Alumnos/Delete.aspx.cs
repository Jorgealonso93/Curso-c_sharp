using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.Alumnos
{
    public partial class Delete : System.Web.UI.Page
    {
        NAlumno nAlumno = new NAlumno();
        NEstado nEstado = new NEstado();
        NEstatus nStatus = new NEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Alumno alumno = nAlumno.Consultar(id);
                int idEstado = Convert.ToInt32(alumno.idEstado);
                int idEstatus = Convert.ToInt32(alumno.idEstatus);
                EstatusAlum estatus = nStatus.Consultar(idEstatus);
                Estado estado = nEstado.Consultar(idEstado);
                lblId.Text = alumno.ID.ToString();
                lblNombre.Text = alumno.Nombre.ToString();
                lblPApellido.Text = alumno.primerApellido.ToString();
                lblSApellido.Text = alumno.segunndoApellido.ToString();
                lblFNacimiento.Text = alumno.fechaNacimiento.ToString("dd/MM/yyyy");
                lblCurp.Text = alumno.Curp.ToString();
                lblCorreo.Text = alumno.Correo.ToString();
                lblTelefono.Text = alumno.Telefono.ToString();
                lblEstado.Text = estado.NombreEstado.ToString();
                lblEstatus.Text = estatus.nombreEstatus.ToString();
            }
            //nAlumno.Eliminar(id);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            nAlumno.Eliminar(id);
            Response.Redirect("Index.aspx");
        }
    }
}