using System;
using Campeon;
using Interfaces;


namespace LogicaNegocio
{
    public class LeagueOfLegends 
    {
        Ihabilidades Habilidades;
        public LeagueOfLegends(Ihabilidades Hechizo)
        {
            this.Habilidades = Hechizo; 
        }
        public void EjecucionHechizo(campeon campeon)
        {
            Habilidades.hechizos(campeon);
        }
    }
}
