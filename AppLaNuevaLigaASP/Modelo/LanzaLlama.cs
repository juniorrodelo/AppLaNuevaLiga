using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public class LanzaLlama : DecoratorCaract
    {
        public LanzaLlama(Caracterizacion caracteristica)
        {
            this.caracteristica = caracteristica;
        }

        public override string descripcion()
        {
            return caracteristica.descripcion() + "Lanza llamas hasta 20Km/h";
        }
    }
}