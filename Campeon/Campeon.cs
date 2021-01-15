using System;

namespace Campeon
{
    public class campeon
    {
        public string Nombre { get; set; }
        public string Hechizo { get; set; }
        

        public campeon(string nombre, string hechizo)
        {
            Nombre = nombre;
            Hechizo = hechizo;
        }
    }
}
