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
    public partial class Edit : System.Web.UI.Page
    {
        NAlumno nAlumno = new NAlumno();
        NEstado nEstado = new NEstado();
        NEstatus nStatus = new NEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ////////////////////////llenando las listas de valores falta filtrar//////////////////////////////////
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
                //////////////////////recuperando datos del Alumno///////////////////////////////////////////////////////
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Alumno alumno = nAlumno.Consultar(id);
                int idEstado = Convert.ToInt32(alumno.idEstado);
                int idEstatus = Convert.ToInt32(alumno.idEstatus);
                EstatusAlum estatus = nStatus.Consultar(idEstatus);
                Estado estado = nEstado.Consultar(idEstado);

                txtId.Text = alumno.ID.ToString();
                txtNombre.Text = alumno.Nombre.ToString();
                txtPApellido.Text = alumno.primerApellido.ToString();
                txtSApelllido.Text = alumno.segunndoApellido.ToString();
                txtFNacimiento.Text = alumno.fechaNacimiento.ToString("yyyy-MM-dd");
                //txtFNacimiento.Text = "1993-12-04";
                txtCurp.Text = alumno.Curp.ToString();
                txtCorreo.Text = alumno.Correo.ToString();
                txtTelefono.Text = alumno.Telefono.ToString();
                ddlEstado.SelectedValue = idEstado.ToString();
                ddlEstatus.SelectedValue = idEstatus.ToString();
                

            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int idEstado = Convert.ToInt32(ddlEstado.SelectedValue);
            var idEstatus = Convert.ToInt32(ddlEstatus.SelectedValue);
            Alumno Alum = new Alumno
            {
                ID = id,
                Nombre = txtNombre.Text,
                primerApellido = txtPApellido.Text,
                segunndoApellido = txtSApelllido.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                fechaNacimiento = Convert.ToDateTime(txtFNacimiento.Text),
                Curp = txtCurp.Text,
                sueldo = 0m,
                idEstado = idEstado,
                idEstatus = idEstatus
            };

            nAlumno.Actualizar(Alum);
            Response.Redirect("Index.aspx");
        }
    }
}