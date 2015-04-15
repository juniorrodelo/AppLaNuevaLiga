using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public abstract class Personajes
    {
        #region Atributos
        private string nombre;
        private char genero;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o Estable el Nombre del Personaje
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Obtiene o Establece el Genero del Personaje 'M' o 'F'
        /// </summary>
        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de Personaje.
        /// </summary>
        public Personajes()
        {
            nombre = "Personaje Name";
            genero = 'M';

        }
        /// <summary>
        /// Contructor de inicialización de Personaje
        /// </summary>
        /// <param name="nombre">Nombre del Personaje</param>
        /// <param name="genero">Genero del Personaje</param>
        public Personajes(string nombre, char genero)
        {
            this.nombre = nombre;
            this.genero = genero;
        }

        #endregion

        #region Metodos Sobrescritos de Object

        /// <summary>
        /// Retorna la descripición del Personaje
        /// </summary>
        /// <returns>Retorna la descripición del Personaje</returns>
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" +
                   "Genero: " + this.genero + "\n";

        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Personajes p = (Personajes)obj;
            bool result = false;

            if ((this.nombre == p.nombre) && (this.genero == p.genero))
                result = true;

            return result;
        }
        ///<summary>
        ///Retorna Codigo Has del objeto
        ///</summary>
        ///<return> Retorna hasCode del objeto</return>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region Metodo Abstrabto...
        /// <summary>
        /// Metodo Abstrabto del personaje para saber que clase es...
        /// </summary>
        public abstract string Clase();
        #endregion
    }
}