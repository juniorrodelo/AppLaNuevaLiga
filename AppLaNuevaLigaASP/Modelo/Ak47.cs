using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class Ak47 : DecoratorCaract
    {
        public Ak47(Caracterizacion c)
        {
            this.caracteristica = c;
        }

        public override string descripcion()
        {
            return caracteristica.descripcion() + "Ak47 de largo alcance. , ";
        }
    }
}