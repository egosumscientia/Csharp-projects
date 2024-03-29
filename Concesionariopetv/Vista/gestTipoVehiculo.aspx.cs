﻿using Controlador.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
             
        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            int carTypeId = Int32.Parse(txtId.Text);

            string typeName = txtName.Text;

            logicaControladorTipoVehiculo negocioAddTipoVehiculo = new logicaControladorTipoVehiculo();

            int resultadoAddTipoVehiculo = negocioAddTipoVehiculo.NegociarInsertTipoVehiculo(carTypeId, typeName);

            if (resultadoAddTipoVehiculo > 0)
            {
                lblMensaje.Text = "Registro insertado";
            }
            else
            {
                lblMensaje.Text = "No se pudo registrar";
            }

            negocioAddTipoVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            //Cuando se le de click al boton "List" debe recibir los datos que neogcio el controlador y despues enviarlos a la grilla (ID=GridView).
            GridView.DataSource = logicaControladorTipoVehiculo.NegociarSelectTipoVehiculo();

            //Llenar cada columna con su respectivo valor y va llenando los registros.
            GridView.DataBind();

            //Los que no tengan datos los deja en blanco.
            txtId.Text = "";
            txtName.Text = "";

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            int carTypeId = Int32.Parse(txtId.Text);

            string typeName = txtName.Text;

            logicaControladorTipoVehiculo negocioUpdateTipoVehiculo = new logicaControladorTipoVehiculo();

            int resultadoUpdateTipoVehiculo = negocioUpdateTipoVehiculo.NegociarUpdateTipoVehiculo(carTypeId, typeName);

            if (resultadoUpdateTipoVehiculo > 0)
            {
                lblMensaje.Text = "Registro actualizado";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar";
            }

            negocioUpdateTipoVehiculo = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int carTypeId = Int32.Parse(txtId.Text);

            logicaControladorTipoVehiculo negocioDeleteTipoVehiculo = new logicaControladorTipoVehiculo();

            int resultadoDeleteTipoVehiculo = negocioDeleteTipoVehiculo.NegociarDeleteTipoVehiculo(carTypeId);

            if (resultadoDeleteTipoVehiculo > 0)
            {
                lblMensaje.Text = "Registro eliminado";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar";
            }

            negocioDeleteTipoVehiculo = null;

        }
    }
}