using System;
using Campeon;
using Interfaces;

namespace AccionCampeones
{
    public class Hechizo: Ihabilidades
    {
        public bool hechizos(campeon Campeon)
        {
            Console.WriteLine("La campeona {0} lanzó el hechizo de {1}", Campeon.Nombre, Campeon.Hechizo);
            return true;

        }
    }
}
