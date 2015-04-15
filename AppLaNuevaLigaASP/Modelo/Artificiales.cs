using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class Artificiales : Personajes, IFicha
    {
        #region Atributos
        private double version;
        #endregion

        #region Propiedades
        public double Version
        {
            get { return version; }
            set { version = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de un Artificial
        /// </summary>
        public Artificiales() : base() { }
        /// <summary>
        /// Contructor de inicialización de un Artificial
        /// </summary>
        /// <param name="nombre">Nombre del Artificial</param>
        /// <param name="genero">Genero del Artificial</param>
        /// <param name="vitalidad">Vitalidad del Artificial</param>
        /// <param name="energia">Energia del Artificial</param>
        /// <param name="fuerza">Fuerza del Artificial</param>
        public Artificiales(string nombre, char genero, double version) :
            base(nombre, genero)
        {
            this.version = version;
        }

        #endregion

        #region Metodos Sobreescritos
        /// <summary>
        /// Retorna la descripición del Artificial
        /// </summary>
        /// <returns>Retorna la descripición del Artificial</returns>
        public override string ToString()
        {
            return base.ToString() + "Version: " + this.version + "\n\n" + Caracteristicas + "\n" + Enemigos;
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Artificiales a = (Artificiales)obj;
            bool result = false;

            if (base.Equals(a) && this.version == a.version)
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