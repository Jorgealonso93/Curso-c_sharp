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
    public partial class WebForm1 : System.Web.UI.Page
    {
        NAlumno nAlumno = new NAlumno();
        NEstado nEstado = new NEstado();
        NEstatus nStatus = new NEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGV();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LlenarGV()
        {
            List<Alumno> listAlumnos = nAlumno.Consultar();
            List<Estado> listestados = nEstado.Consultar();
            List<EstatusAlum> listEstatus = nStatus.Consultar();
            //Estado estado = nEstado.Consultar(listAlumnos[0]);
            var Alum = from alumno in listAlumnos
                       join estado in listestados on alumno.idEstado equals estado.IdEstado
                       join estatus in listEstatus on alumno.idEstatus equals estatus.IdEstatus
                       select new {ID= alumno.ID,Nombre= alumno.Nombre, primerApellido=alumno.primerApellido, segunndoApellido=alumno.segunndoApellido, Correo=alumno.Correo, Telefono=alumno.Telefono, Estado=estado.NombreEstado, Estatus=estatus.nombreEstatus };

            dgvAlumno.DataSource = Alum.ToList();
            dgvAlumno.DataBind();
        }

        protected void dgvAlumno_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Page") return;
                int iren = Convert.ToInt32(e.CommandArgument);
                GridViewRow renglon = dgvAlumno.Rows[iren];
                TableCell celda = renglon.Cells[0];
                string id = celda.Text;

                switch (e.CommandName)
                {
                    case "Consultar":
                        Response.Redirect($"Details.aspx?id={id}");
                        break;
                    case "Update":
                        Response.Redirect($"Edit.aspx?id={id}");
                        break;
                    case "Delete":
                        Response.Redirect($"Delete.aspx?id={id}");
                        break;
                }
            }catch (Exception)
            {
                throw;
            }
        }

        protected void dgvAlumno_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvAlumno.PageIndex = e.NewPageIndex;
            LlenarGV();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx");
        }
    }
}