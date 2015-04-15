using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class SuperHumanos : Personajes, IFicha
    {
        #region Atributos

        private string planetaOrigen;

        #endregion

        #region Propiedades
        public string PlanetaOrigen
        {
            get { return planetaOrigen; }
            set { planetaOrigen = value; }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de SuperHumanos.
        /// </summary>
        public SuperHumanos() : base() { }
        /// <summary>
        /// Contructor de inicialización de un SuperHumano
        /// </summary>
        /// <param name="nombre">Nombre del SuperHumano</param>
        /// <param name="genero">Genero del SuperHumano</param>
        /// <param name="planetaOrigen">Planeta de Origen del SuperHumano</param>
        public SuperHumanos(string nombre, char genero, string planetaOrigen) :
            base(nombre, genero)
        {
            this.planetaOrigen = planetaOrigen;
        }

        #endregion

        #region Metodos Sobreescritos
        /// <summary>
        /// Retorna la descripición del SuperHumano
        /// </summary>
        /// <returns>Retorna la descripición del SuperHumano</returns>
        public override string ToString()
        {
            return base.ToString() + "Planeta de Origen: " + planetaOrigen + "\n\n" + Caracteristicas + "\n" + Enemigos;
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            SuperHumanos sh = (SuperHumanos)obj;
            bool result = false;

            if (base.Equals(sh) && this.planetaOrigen == sh.planetaOrigen)
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

        #region Metodo Abstrabto sobreescrito
        /// <summary>
        /// Metodo Abstrabto del personaje para saber que clase es...
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