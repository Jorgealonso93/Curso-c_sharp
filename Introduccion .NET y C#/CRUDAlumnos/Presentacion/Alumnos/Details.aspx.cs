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
    public partial class Details : System.Web.UI.Page
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
           
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //}

        //protected void Button1_Click1(object sender, CommandEventArgs e)
        //{
        //    String codigo = e.CommandArgument.ToString();
        //    int id = Convert.ToInt32(Request.QueryString["id"]);
        //    Alumno alumno = nAlumno.Consultar(id);
        //    decimal sueldo = alumno.sueldo;
        //    TablaISR alumISR = nAlumno.CalcularISR(sueldo);

        //    lblImpuesto.Text = alumISR.impuesto.ToString();
        //}

        //protected void ShowPopup(object sender, EventArgs e)
        //{

        //}

        protected void btnIsr_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(Request.QueryString["id"]);
            //Alumno alumno = nAlumno.Consultar(id);
            //decimal sueldo = alumno.sueldo;
            //TablaISR alumISR = nAlumno.CalcularISR(sueldo);

            //lblImpuesto.Text = alumISR.impuesto.ToString();
            //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        }

        protected void btnImms_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(Request.QueryString["id"]);
            //Alumno alumno = nAlumno.Consultar(id);
            //decimal sueldo = alumno.sueldo;
            //AportacionesIMSS immsElem = nAlumno.CalcularIMMS(sueldo);

            //lblMaternidad.Text = immsElem.enfermedadMaternidad.ToString();
            //lblInvalidez.Text = immsElem.invalidezVida.ToString();
            //lblRetiro.Text = immsElem.retiro.ToString();
            //lblCesantia.Text = immsElem.cesantia.ToString();
            //lblInfonavit.Text = immsElem.infonavit.ToString();
            //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "immsModal", "$('#immsModal').modal();", true);
        }
    }
}