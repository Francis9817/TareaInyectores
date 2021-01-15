using System;
using Interfaces;
using Campeon;
using LogicaNegocio;
using AccionCampeones;
using Ninject;

namespace Tarea.Inyectores
{
    class Program
    {
        static void Main(string[] args)
            
        {
            
            Console.WriteLine("Elige a tu Campeón");
            var opcionUsuario = 0;
            var kernel = new StandardKernel();

            Console.WriteLine("Escoje tu campeon de League Of Legends");
            Console.WriteLine("1.- Katarina");
            Console.WriteLine("2.- Anivia");
            Console.WriteLine("3.- Ahri");
            Console.WriteLine("4.- Miss Fortune");
            Console.WriteLine("5.- Lux");
            Console.WriteLine("6.- Annie");
            Console.WriteLine("7.- Akali");
            Console.WriteLine("8.- Cassiopeia");
            opcionUsuario = int.Parse(Console.ReadLine());



            if (opcionUsuario == 1)
            {
                campeon campeon1 = new campeon("Katarina", "su daga, la cual disminuye 15% en daño magico");
                kernel.Bind<Ihabilidades>().To<Hechizo>();
                var jugador1 = kernel.Get<LeagueOfLegends>();
                jugador1.EjecucionHechizo(campeon1);
            }
            if (opcionUsuario == 2) 
            {
                campeon campeon2 = new campeon("Anivia", "una esfera de hielo que vuela hacia sus enemigos, de modo que enfría y enfliye daño magico");
                kernel.Bind<Ihabilidades>().To<Hechizo>();
                var jugador2 = kernel.Get<LeagueOfLegends>();
                jugador2.EjecucionHechizo(campeon2);
            }
            if (opcionUsuario == 3)
            {
                campeon campeon3 = new campeon("Ahri"," una bola que inflige daño mágico al lanzarlo y daño verdadero al recuperarlo");
                kernel.Bind<Ihabilidades>().To<Hechizo>();
                var jugador3 = kernel.Get<LeagueOfLegends>();
                jugador3.EjecucionHechizo(campeon3);

            }
            if (opcionUsuario == 4)
            {
                campeon campeon4 = new campeon("Miss Fortune","dispar una bala a un enemigo y inflige daño fisico");
                kernel.Bind<Ihabilidades>().To<Hechizo>();
                var jugador4 = kernel.Get<LeagueOfLegends>();
                jugador4.EjecucionHechizo(campeon4);
            }
            if (opcionUsuario == 5)
            {
                campeon campeon5 = new campeon("Lux", "una esfera de luz que inmoviliza y causa daño magico");
                kernel.Bind<Ihabilidades>().To<Hechizo>();
                var jugador5 = kernel.Get<LeagueOfLegends>();
                jugador5.EjecucionHechizo(campeon5);
            }
            if (opcionUsuario == 6)
            {
                campeon campeon6 = new campeon("Annie", "una bola de fuego imbuida de maná que daña al objetivo y le devuelve el maná gastado si este resulta destruido");
                kernel.Bind<Ihabilidades>().To<Hechizo>();
                var jugador6 = kernel.Get<LeagueOfLegends>();
                jugador6.EjecucionHechizo(campeon6);

            }
            if (opcionUsuario == 7)
            {
                campeon campeon7 = new campeon("Akali"," cinco kunais que ralentizan e infligen daño magico");
                kernel.Bind<Ihabilidades>().To<Hechizo>();
                var jugador7 = kernel.Get<LeagueOfLegends>();
                jugador7.EjecucionHechizo(campeon7);

            }
            if (opcionUsuario == 8)
            {
                campeon campeon8 = new campeon("Cassiopeia", "una granada temporal que, al alcanzar a un campeón enemigo e infligen daño magico");
                kernel.Bind<Ihabilidades>().To<Hechizo>();
                var jugador8 = kernel.Get<LeagueOfLegends>();
                jugador8.EjecucionHechizo(campeon8);      
            }  
        }
    }
}
