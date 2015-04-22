using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppLaNuevaLigaASP.Modelo;

namespace AppLaNuevaLigaASP.Datos
{
    public class PersonajesRepositories
    {
        private static List<Personajes> lista = new List<Personajes>();

        public PersonajesRepositories()
        {
            xD
        }

        public IEnumerable<Personajes> getPersonaje()
        {
            //Creando los Enemigos por defecto
            Humanos flash = new Humanos("flash", 'M', "USA");
            Humanos mujerMaravilla = new Humanos("mujerMaravilla", 'M', "USA");
            Aliens superMan = new Aliens("superMan", 'M', "Martes");
            Aliens hulk = new Aliens("hulk", 'M', "Martes");

            


            return lista;
        }

        public void addPersonaje(Personajes p)
        {
            lista.Add(p);
        }

        public void addEnemigos(Personajes flash, Personajes mujerMaravilla, Personajes superMan, Personajes hulk)
        {
            lista.Add(flash);
            lista.Add(mujerMaravilla);
            lista.Add(superMan);
            lista.Add(hulk);
        }
    }
}