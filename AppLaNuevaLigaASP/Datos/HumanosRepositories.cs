using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppLaNuevaLigaASP.Modelo;

namespace AppLaNuevaLigaASP.Datos
{
    public class HumanosRepositories
    {
        private static List<Humanos> lista = new List<Humanos>();

        public HumanosRepositories()
        {

        }

        public IEnumerable<Humanos> getPersonaje()
        {
            
            /*
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
            batman.add(poderes);

            //Añadiendo las Armas a Wason
            wason.add(armasWason);

            //Añadiendo Poderes a Alien
            alien.add(poderes);

            //Añadiendo liga a Batman
            

            //Añadiendo un Enemigo a Batman
            batman.enemigo(wason);
            batman.enemigo(alien);

            //Añadiendo Un Enemigo a Wason
            wason.enemigo(alien);

            //Insertando en la Lista
            lista.Add(batman);
            lista.Add(wason);*/

            return lista;
        }
        
        public void addPersonaje(Humanos p)
        {
            lista.Add(p);
        }
    }

}