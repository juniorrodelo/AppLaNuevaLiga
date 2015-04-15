using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class Espada : DecoratorCaract
    {

        public Espada(Caracterizacion c)
        {
            this.caracteristica = c;
        }

        public override string descripcion()
        {
            return caracteristica.descripcion() + "Espada del Exilio 23\n";
        }
    }
}