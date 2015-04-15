using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class Armas : Caracterizacion
    {

        #region Atributos

        private double alcanze;
        private double velocidad;
        private double calibre;
        private double poder_destruccion;

        #endregion

        #region Propiedades

        public double Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }


        public double Poder_destruccion
        {
            get { return poder_destruccion; }
            set { poder_destruccion = value; }
        }

        public double Alcanze
        {
            get { return alcanze; }
            set { alcanze = value; }
        }


        public double Calibre
        {
            get { return calibre; }
            set { calibre = value; }
        }
        #endregion

        #region Constructor

        public Armas()
            : base()
        {

            alcanze = 0.0;
            velocidad = 0.0;
            calibre = 0.0;
            poder_destruccion = 0.0;


        }

        public Armas(string nombre, string tipo, double alcanze, double velocidad, double calibre, double poder)
            : base(nombre, tipo)
        {

            this.alcanze = alcanze;
            this.velocidad = velocidad;
            this.calibre = calibre;
            this.poder_destruccion = poder;
        }

        #endregion

        #region Metodos override base

        public override string ToString()
        {
            return base.ToString() + "\n Alcanze : " + this.alcanze +
                                     "Velocidad : " + this.velocidad +
                                     "Calibre : " + this.calibre +
                                     "Poder de destruccion : " + this.poder_destruccion;
        }

        public override bool Equals(object obj)
        {
            Armas a = (Armas)obj;
            bool result = false;
            if (base.Equals(a) && this.alcanze == a.alcanze && this.velocidad == a.alcanze && this.calibre == a.calibre && this.poder_destruccion == a.poder_destruccion)
                result = true;
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region Metodos abstractos

        public override string descripcion()
        {
            return "\nArmas: \n";
        }

        #endregion

    }
}