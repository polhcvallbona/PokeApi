using PokeApiBack.Models;
using PokeApiBack.Repositories;
using PokeApiFront.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeApiFront.Controller
{
    public class FrontController
    {
        WelcomeForm welcomeForm = new WelcomeForm();
        MainForm mainForm = new MainForm();

        public FrontController()
        {
            SetListeners();
            LoadData();
            welcomeForm.Show();
        }

        private void SetListeners()
        {
            welcomeForm.bEntrar.Click += BEntrar_Click;
            mainForm.cbPokemonName1.SelectedIndexChanged += CbPokemonName1_SelectedIndexChanged;
            mainForm.cbPokemonName2.SelectedIndexChanged += CbPokemonName2_SelectedIndexChanged;
            mainForm.bComparar.Click += BComparar_Click;
        }

        private void BComparar_Click(object sender, EventArgs e)
        {
            if (mainForm.cbPokemonName1 != null && mainForm.cbPokemonName2 != null)
            {

            }
        }

        private async void CbPokemonName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetPokemonCard1();
        }

        private async Task GetPokemonCard1()
        {
            if (mainForm.cbPokemonName1.Text != "" && mainForm.cbPokemonName1.Text != null)
            {
                var result = await PokemonRepository.GetAllPokemonsByName(mainForm.cbPokemonName1.Text);
                mainForm.cbPokemonCard1.DataSource = result;
                string imageUrl = result[0].images.small;
                mainForm.pbPokemonCard1.ImageLocation = imageUrl;
            }
        }

        private async void CbPokemonName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetPokemonCard2();
        }

        private async Task GetPokemonCard2()
        {
            if (mainForm.cbPokemonName2.Text != "" && mainForm.cbPokemonName2.Text != null)
            {
                var result = await PokemonRepository.GetAllPokemonsByName(mainForm.cbPokemonName2.Text);
                mainForm.cbPokemonCard2.DataSource = result;
                string imageUrl = result[0].images.small;
                mainForm.pbPokemonCard2.ImageLocation = imageUrl;
            }
        }

        private void BEntrar_Click(object sender, EventArgs e)
        {
            welcomeForm.Hide();
            mainForm.ShowDialog();
            welcomeForm.Close();
            Application.Exit();
        }

        private async void LoadData()
        {
            mainForm.cbPokemonName1.DataSource = await PokemonRepository.GetAllPokemonNames();
            mainForm.cbPokemonName2.DataSource = await PokemonRepository.GetAllPokemonNames();
        }
    }
}
