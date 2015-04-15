using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public abstract class DecoratorCaract : Caracterizacion
    {
        protected Caracterizacion caracteristica;

        public override abstract string descripcion();
    }
}