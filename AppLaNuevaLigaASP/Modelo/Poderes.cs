using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class Poderes : Caracterizacion
    {

        #region Atributos
        private string efecto;
        private int nivel;
        private double consumo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Establece y Obtiene el Efecto del Poder
        /// </summary>
        public string Efecto
        {
            get { return efecto; }
            set { efecto = value; }
        }

        /// <summary>
        /// Establece y Obtiene el Nivel del Poder
        /// </summary>
        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        /// <summary>
        /// Establece y Obtiene el Consumo del Poder
        /// </summary>
        public double Consumo
        {
            get { return consumo; }
            set { consumo = value; }
        }

        #endregion

        #region Constructres
        /// <summary>
        /// Constructor por defecto de un Poder.
        /// </summary>
        public Poderes()
            : base()
        {

            efecto = " Efecto del poder";
            nivel = 1;
            consumo = 0.2;
        }
        /// <summary>
        /// Constructor de Inicializacion de Un Poder
        /// </summary>
        /// <param name="nombre">Nombre del Poder</param>
        /// <param name="tipo">Tipo de Poder</param>
        /// <param name="efecto">Efecto del Poder</param>
        /// <param name="nivel">Nivel del Poder</param>
        /// <param name="consumo">Consumo que genera el Poder</param>
        public Poderes(string nombre, string tipo, string efecto, int nivel, double consumo)
            : base(nombre, tipo)
        {
            this.efecto = efecto;
            this.nivel = nivel;
            this.consumo = consumo;
        }
        #endregion

        #region Metodos Override Object

        /// <summary>
        /// Retorna la descripición del Poder
        /// </summary>
        /// <returns>Retorna un string con la descripición del Poder</returns>
        public override string ToString()
        {
            return base.ToString() + "\n Efecto del porder : " + this.efecto +
                                     "\n Nivel del poder : " + this.nivel +
                                     "\n Consumo de energia del poder : " + this.consumo;
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Poderes p = (Poderes)obj;
            bool result = false;

            if (base.Equals(p) && this.efecto == p.efecto && this.nivel == p.nivel && this.consumo == p.consumo)
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

        #region Metodos override

        /// <summary>
        /// Descripcion del Poder.
        /// </summary>
        /// <returns>Un string con la descripcion del Poder</returns>
        public override string descripcion()
        {
            return "\nPoderes: \n";
        }

        #endregion


    }
}