using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppLaNuevaLigaASP.Modelo;

namespace AppLaNuevaLigaASP.Datos
{
    public class PersonajesRepositories
    {
        public IEnumerable<Personajes> getPersonaje()
        {
            List<Personajes> lista = new List<Personajes>();

            //Creando los Personajes
            Humanos batman = new Humanos("Batman", 'M', "USA");
            Humanos wason = new Humanos("Wasson", 'M', "USA");
            Aliens alien = new Aliens("Alien129", 'M', "Martes");

            //Creando Las Caracterizaciones
            Caracterizacion armasWason = new Armas();
            Caracterizacion armaBat = new Armas();
            Caracterizacion poderes = new Poderes();

            //Aplicando el patron decorator
            poderes = new LanzaLlama(poderes);
            armasWason = new Espada(armasWason);
            armaBat = new Espada(armaBat);
            armaBat = new Pistola(armaBat);

            //Añadiendo las Armas a Batman
            batman.add(armaBat);

            //Añadiendo las Armas a Wason
            wason.add(armasWason);

            //Añadiendo Poderes a Alien
            alien.add(poderes);

            //Añadiendo un Enemigo a Batman
            batman.enemigo(wason);
            batman.enemigo(alien);

            //Añadiendo Un Enemigo a Wason
            wason.enemigo(alien);

            //Insertando en la Lista
            lista.Add(batman);
            lista.Add(wason);
            lista.Add(alien);

            return lista;
        }
    }
}