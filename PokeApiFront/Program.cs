<<<<<<< HEAD
﻿using PokeApiFront.Model;
=======
﻿using PokeApiBack.Repositories;
>>>>>>> origin/main
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeApiFront
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            new FrontController();
            Application.Run();
=======
            Application.Run(new Form1());*/
            await GetPokemons();
        }

        public static async Task GetPokemons()
        {
            var res = await PokemonRepository.GetAllPokemonsByName("gardevoir");
            return;
>>>>>>> origin/main
        }
    }
}
