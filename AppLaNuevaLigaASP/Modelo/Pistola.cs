using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class Pistola : DecoratorCaract
    {
        public Pistola(Caracterizacion c)
        {
            this.caracteristica = c;
        }

        public override string descripcion()
        {
            return caracteristica.descripcion() + "Pistola con Balas de calibre 40";
        }
    }
}