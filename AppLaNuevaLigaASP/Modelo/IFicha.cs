using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLigaASP.Modelo
{
    public interface IFicha
    {
        void add(Caracterizacion caracteristica);

        void liga(string liga);

        void enemigo(Personajes enemigo);
    }
}