using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class Humanos : Personajes, IFicha
    {
        #region Atributos

        private string nacionalidad;

        #endregion

        #region Propiedades
        /// <summary>
        /// Establece y Obtiene la nacionalidad del Humano
        /// </summary>
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de Humanos.
        /// </summary>
        public Humanos()
            : base()
        {
            this.nacionalidad = "Mi Nacionalidad";
        }

        /// <summary>
        /// Contructor de inicialización de un Humano
        /// </summary>
        /// <param name="nombre">Nombre del Humano</param>
        /// <param name="genero">Genero del Humano</param>
        /// <param name="nacionalidad">Nacionalidad del Humano</param>
        public Humanos(string nombre, char genero, string nacionalidad) :
            base(nombre, genero)
        {
            this.nacionalidad = nacionalidad;
        }

        #endregion

        #region Metodos Sobreescritos

        /// <summary>
        /// Retorna la descripición del Humano
        /// </summary>
        /// <returns>Retorna la descripición del Humano</returns>
        public override string ToString()
        {
            return base.ToString() + "Nacionalidad: " + this.nacionalidad + "\n\n" + Caracteristicas + "\n" + Enemigos;
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Humanos h = (Humanos)obj;
            bool result = false;

            if (base.Equals(h) && this.nacionalidad == h.nacionalidad)
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
        /// <summary>
        /// Metodo Abstrabto del personaje para saber que clase es...
        /// </summary>
        /// <param name="clase">Clase de personaje</param>

        #endregion

        #region Metodo Abstrabto Sobreescrito
        /// <summary>
        /// Metodo Abstrabto del personaje para saber que clase es...
        /// <returns>Clase que pertenece dicho personaje</returns>
        /// </summary>
        public override string Clase()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementacion de la Interfaz

        List<Caracterizacion> caracteristicas = new List<Caracterizacion>();
        List<Personajes> enemigos = new List<Personajes>();


        public string Enemigos
        {
            get
            {
                string salida = "Enemigos: \n";
                foreach (Personajes value in enemigos)
                    salida += value.Nombre + "\n";

                return salida;
            }
        }

        public string Caracteristicas
        {
            get
            {
                string salida = "Caracterizacion: \n";
                foreach (Caracterizacion value in caracteristicas)
                    salida += value.descripcion() + "\n";

                return salida;
            }

        }

        //Metodos de la Interfaz
        /// <summary>
        /// Añade una caracteristica al Personaje
        /// </summary>
        /// <param name="caracterizacion">Una Caracterizacion</param>
        public void add(Caracterizacion caracterizacion)
        {
            this.caracteristicas.Add(caracterizacion);


        }
        /// <summary>
        /// Establece la Liga del Personaje
        /// </summary>
        /// <param name="liga">Liga del Personaje</param>
        public void liga(string liga)
        {
            System.Console.WriteLine("Pertenezco a la Liga: " + liga);
        }
        /// <summary>
        /// Establece o Añade un o Varios enemigos del Personaje
        /// </summary>
        /// <param name="enemigo">Enemigos del Personaje</param>
        public void enemigo(Personajes enemigo)
        {
            this.enemigos.Add(enemigo);
        }

        #endregion

    }
}