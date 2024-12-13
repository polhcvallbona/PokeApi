using PokeApiBack.Repositories;
using PokeApiFront.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeApiFront.Model
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
                //mainForm.cbPokemonCard1.DataSource = result;
            }
        }

        private async void CbPokemonName2_SelectedIndexChanged(object sender, EventArgs e)
            await GetPokemonNameCard1();
        }

        private async Task GetPokemonNameCard1()
        {
            await GetPokemonCard2();
        }

        private async Task GetPokemonCard2()
        {
            if (mainForm.cbPokemonName2.Text != "" && mainForm.cbPokemonName2.Text != null)
            {
                var result = await PokemonRepository.GetAllPokemonsByName(mainForm.cbPokemonName2.Text);
            }
        }

        private async void CbPokemonName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetPokemonNameCard2();
        }

        private async Task GetPokemonNameCard2()
        {
            if (mainForm.cbPokemonName2.Text != "" && mainForm.cbPokemonName2.Text != null)
            {
                mainForm.cbPokemonCard2.DataSource = await PokemonRepository.GetAllPokemonsByName(mainForm.cbPokemonName2.Text);
            }
        }

        private void BEntrar_Click(object sender, EventArgs e)
        {
            welcomeForm.Hide();
            mainForm.Show();
            welcomeForm.Close();
        }

        private async Task LoadData()
        {
            mainForm.cbPokemonName1.DataSource = await PokemonRepository.GetAllPokemonNames();
            mainForm.cbPokemonName2.DataSource = await PokemonRepository.GetAllPokemonNames();
        }

    }
}
