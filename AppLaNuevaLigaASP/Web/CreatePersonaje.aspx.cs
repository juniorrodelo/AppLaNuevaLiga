using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppLaNuevaLigaASP.Datos;
using AppLaNuevaLigaASP.Modelo;

namespace AppLaNuevaLigaASP.Web
{
    public partial class CreatePersonaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            #region "Atributos"

            string nombre = Convert.ToString(tbNombre.Text);
            string nacionalidad = Convert.ToString(tbNacionalidad.Text);
            char genero = Convert.ToChar(dlGenero.SelectedItem.Value);
            

            #endregion

            #region "Carácteristicas"

            string liga = rbLiga.SelectedItem.Value;
            string typePersonaje = TypePersonaje.SelectedItem.Value;

            #endregion

            ////Creando los Enemigos por defecto
            Humanos flash = new Humanos("flash", 'M', "USA");
            Humanos mujerMaravilla = new Humanos("mujerMaravilla", 'M', "USA");
            Aliens superMan = new Aliens("superMan", 'M', "Martes");
            Aliens hulk = new Aliens("hulk", 'M', "Martes");

            //Insertando enemigos a la Lista
            PersonajesRepositories ppp = new PersonajesRepositories();
            ppp.addEnemigos(flash, mujerMaravilla, superMan, hulk);


            if (typePersonaje == "humano") 
            {
                Humanos personaje = new Humanos(nombre, genero, nacionalidad);

                //iniciando Caracteristicas
                Caracterizacion armasPerson = new Armas();

                // Añadiendo Armas
                if (chCatana.Checked)
                {
                    armasPerson = new Catana(armasPerson);
                }

                if (chAk47.Checked)
                {
                    armasPerson = new Ak47(armasPerson);
                }

                if (chManun.Checked)
                {
                    armasPerson = new ArmaManun(armasPerson);
                }

                if (chEspada.Checked)
                {
                    armasPerson = new Espada(armasPerson);
                }

                //Añadiendo las Armas a Batman
                personaje.add(armasPerson);

                ppp.addPersonaje(personaje);
                Response.Redirect("Default.aspx");
                
            }

            if (typePersonaje == "shumano")
            {
                SuperHumanos personaje = new SuperHumanos(nombre, genero, nacionalidad);
            }

            if (typePersonaje == "aliens")
            {
                Aliens personaje = new Aliens(nombre, genero, nacionalidad);
            }

            if (typePersonaje == "artificiales")
            {
                double version = Convert.ToDouble(tbVersion);
                Artificiales personaje = new Artificiales(nombre, genero, version);
            }


            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
} 