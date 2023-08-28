using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Estudiantes : System.Web.UI.Page
    {
        List<oTipoIdentificacion> listaTipoIdentifiacion = new List<oTipoIdentificacion>();
        List<oGenero> listaGenero = new List<oGenero>();
        List<oEstadoCivil> listaCivil = new List<oEstadoCivil>();
        List<oEstado> listaEstado = new List<oEstado>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaTipoIdentifiacion.Add(new oTipoIdentificacion { id = 1, tipoIdentificacion = "Cédula nacional" });
                listaTipoIdentifiacion.Add(new oTipoIdentificacion { id = 2, tipoIdentificacion = "DIMEX" });
                listaTipoIdentifiacion.Add(new oTipoIdentificacion { id = 3, tipoIdentificacion = "Pasaporte" });

                foreach (var item in listaTipoIdentifiacion)
                {
                    DDLId.Items.Add(new ListItem(item.tipoIdentificacion, item.id.ToString()));
                }
                //*****************************************************
                //llena la lista de Genero
                listaGenero.Add(new oGenero { id = 1, genero = "Mujer" });
                listaGenero.Add(new oGenero { id = 2, genero = "Hombre" });
                listaGenero.Add(new oGenero { id = 3, genero = "Otro" });

                foreach (var item in listaGenero)
                {
                    DDLGenero.Items.Add(new ListItem(item.genero, item.id.ToString()));
                }

                listaCivil.Add(new oEstadoCivil { id = 1, estado = "Soltero(a)" });
                listaCivil.Add(new oEstadoCivil { id = 2, estado = "Casado(a)" });
                listaCivil.Add(new oEstadoCivil { id = 3, estado = "Divorciado(a)" });
                

                foreach (var item in listaCivil)
                {
                    DDLCivil.Items.Add(new ListItem(item.estado, item.id.ToString()));
                }

                listaEstado.Add(new oEstado { id = 1, estado = "Activo" });
                listaEstado.Add(new oEstado { id = 2, estado = "Matriculado" });
                listaEstado.Add(new oEstado { id = 3, estado = "Graduado" });
                listaEstado.Add(new oEstado { id = 3, estado = "Inactivo" });

                foreach (var item in listaEstado) {
                    DDLEstado.Items.Add(new ListItem(item.estado, item.id.ToString()));
                }

            }
        }

        private int devolverTipo(string valor)
        {
            int tipo = 0;
            if (valor.Equals("Cédula nacional"))
                tipo = 1;
            else if(valor.Equals("DIMEX"))
                tipo = 2;
            else
                tipo = 3;
            return tipo;
        }

        private int devolverGenero(string valor)
        {
            int tipo = 0;
            if (valor.Equals("Mujer"))
                tipo = 1;
            else if (valor.Equals("Hombre"))
                tipo = 2;
            else
                tipo = 3;
            return tipo;
        }

        private int devolverCivil(string valor)
        {
            int tipo = 0;
            if (valor.Equals("Soltero(a)"))
                tipo = 1;
            else if (valor.Equals("Casado(a)"))
                tipo = 2;
            else
                tipo = 3;
            return tipo;
        }

        private int devolverEstado(string valor)
        {
            int tipo = 0;
            if (valor.Equals("Activo"))
                tipo = 1;
            else if (valor.Equals("Matriculado"))
                tipo = 2;
            else if(!valor.Equals("Graduado"))
                tipo = 3;
            else
                tipo = 4;
            return tipo;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            

                try
                {
                    Negocios.LnEstudiantes estudiantes = new Negocios.LnEstudiantes();
                    // Negocios.LnMetodosAgenda negocios = new Negocios.LnMetodosAgenda();

                    //definir las variables
                    string user = txt_user.Text;
                
                    string nombre = txt_Nombre.Text;
                    string apellidos = txt_apellidos.Text;
                    string id = txt_identi.Text;
                    int tipo = devolverTipo(DDLId.SelectedItem.Text);
                    int genero = devolverGenero(DDLGenero.SelectedItem.Text);
                    int civil = devolverCivil(DDLCivil.SelectedItem.Text);
                    string nacimiento = txtFN.Text;
                    string carrera = txt_carrera.Text;
                    string year = txt_anio.Text;
                    int estado = devolverEstado(DDLEstado.SelectedItem.Text);




                    
                    var resultado = estudiantes.InsertarEstudiante(user, carrera, nombre, apellidos, id, tipo, genero, civil, nacimiento, year, estado);
                    //negocios.InsertarEstadoCivil(nombre);

                    if (resultado)
                    {    // Establecer el texto del mensaje
                        mensajeTexto.InnerText = "Se almacenó la información correctamente";
                        // Mostrar el cuadro de mensaje
                        divMensaje.Style["display"] = "block";

                        // CargaTabla();
                    }
                    else
                    {
                        // Establecer el texto del mensaje
                        mensajeTexto.InnerText = "Ocurrió un error al guardar la información, intentelo más tarde.";
                        // Mostrar el cuadro de mensaje
                        divMensaje.Style["display"] = "block";
                    }
                }
                catch (Exception ex)
                {
                    // Establecer el texto del mensaje
                    mensajeTexto.InnerText = "Ocurrió un error. (Error: " + ex.Message + ")";
                    // Mostrar el cuadro de mensaje
                    divMensaje.Style["display"] = "block";
                }
            }

       

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Prin_Admi.aspx");
        }

        protected void btnVisualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/VerEstudiante.aspx");
        }
    }
}