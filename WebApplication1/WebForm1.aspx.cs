using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1Client cliente = new Service1Client();
            DropDownList1.DataSource = cliente.mostrarTodos(0, "", 0, 1);
            DropDownList1.DataTextField = "descripcion";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            
        }
        protected void BtnConsultarid_Click(object sender, EventArgs e)
        {
            Service1Client cliente = new Service1Client();
            misDatos Datos = new misDatos();

            if (txtID.Text.Trim() != "")
            {
                int id = int.Parse(txtID.Text);
                string descripcion = "d";
                int tipo = 0;
                int tipoConsulta = 5;
                Datos = cliente.consultar(id, descripcion, tipo, tipoConsulta);
                //llenar los datos en los textbox

                txtDescripcion.Text = Datos.Descripcion;
                txtTipo.Text = Datos.Tipo.ToString();
            }
            else
            {
                lblId.Text = "Escriba el id";

            }
        }

        protected void BtnConsultarTodo_Click(object sender, EventArgs e)
        {
            Service1Client cliente = new Service1Client();
            GridView1.DataSource = cliente.mostrarTodos(0, "", 0, 1);
            GridView1.DataBind();
        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Service1Client cliente = new Service1Client();
            misDatos Datos = new misDatos();

            int id = int.Parse(txtID.Text);
            string descripcion = txtDescripcion.Text.ToString();
            int tipo = int.Parse(txtTipo.Text);
            int tipoConsulta = 2;
            int respuesta = cliente.insertar(id, descripcion, tipo, tipoConsulta);

            if (respuesta > 0)
            {
                lblId.Text = "contacto agregao con exito";
            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            Service1Client cliente = new Service1Client();
            misDatos Datos = new misDatos();

            int id = int.Parse(txtID.Text);
            string descripcion = txtDescripcion.Text.ToString();
            int tipo = int.Parse(txtTipo.Text);
            int tipoConsulta = 3;
            int respuesta = cliente.insertar(id, descripcion, tipo, tipoConsulta);

            if (respuesta > 0)
            {
                lblId.Text = "contacto modificado con exito";
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Service1Client cliente = new Service1Client();
            misDatos Datos = new misDatos();

            int id = int.Parse(txtID.Text);
            string descripcion = "";
            int tipo = 0;
            int tipoConsulta = 4;
            int respuesta = cliente.insertar(id, descripcion, tipo, tipoConsulta);

            if (respuesta > 0)
            {
                lblId.Text = "contacto eliminado con exito";
            }
        }
    }
}