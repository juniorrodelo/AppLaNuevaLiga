using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class ArmaManun : DecoratorCaract
    {
        public ArmaManun(Caracterizacion c)
            {
                this.caracteristica = c;
            }

            public override string descripcion()
            {
                return caracteristica.descripcion() + "Arma MAnun 40 , ";
            }
    }
}